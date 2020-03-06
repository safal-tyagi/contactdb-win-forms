using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactDbWFA.Models;
using System.Text.RegularExpressions;

namespace ContactDbWFA
{
    public partial class MainForm : Form
    {
        ContactDbContext _context;
        List<Contact> _contacts;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _contacts = new List<Contact>();

            using (_context = new ContactDbContext())
            {
                List<Contact> allContacts = _context.Contact.ToList();
                List<Address> allAddresses = _context.Address.ToList();
                List<Phone> allPhones = _context.Phone.ToList();
                List<Date> allDates = _context.Date.ToList();

                foreach (Contact contact in allContacts)
                {
                    List<Address> addresses = allAddresses.FindAll(delegate (Address address) { return address.ContactId == contact.ContactId; });
                    foreach (Address address in addresses)
                        contact.Address.Add(address);

                    List<Phone> phones = allPhones.FindAll(delegate (Phone phone) { return phone.ContactId == contact.ContactId; });
                    foreach (Phone phone in phones)
                        contact.Phone.Add(phone);

                    List<Date> dates = allDates.FindAll(delegate (Date date) { return date.ContactId == contact.ContactId; });
                    foreach (Date date in dates)
                        contact.Date.Add(date);

                    _contacts.Add(contact);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstSearchResults.Clear();
            ClearForm();

            using (_context = new ContactDbContext())
            {
                string searchString = tbSearch.Text;
                string[] subStrings = Regex.Split(searchString, " ");

                List<string> relevantContacts = new List<string>();
                foreach (Contact contact in _contacts)
                {
                    foreach (string substr in subStrings)
                    {
                        bool strFound = false;
                        if (contact.Find(substr)) strFound = true;
                        foreach (Address address in contact.Address)
                            if (address.Find(substr)) strFound = true;
                        foreach (Phone phone in contact.Phone)
                            if (phone.Find(substr)) strFound = true;
                        foreach (Date date in contact.Date)
                            if (date.Find(substr)) strFound = true;

                        if (strFound)
                        {
                            string fullName = contact.FirstName + " " + contact.MiddleName + " " + contact.LastName;
                            relevantContacts.Add(fullName);
                        }
                    }
                }

                IEnumerable<string> uniqueContacts = relevantContacts.Distinct();

                foreach(string contact in uniqueContacts)
                {
                    lstSearchResults.Items.Add(contact);
                }
            }
        }

        private void lstSearchResults_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string curItem = lstSearchResults.SelectedItems[0].Text;
            Contact curContact = _contacts.Find(delegate (Contact contact) { return curItem == contact.GetFullName(); });
            
            FillForm(curContact);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstSearchResults.SelectedItems.Count == 0) return;

            ClearForm();

            string curItem = lstSearchResults.SelectedItems[0].Text;
            Contact curContact = _contacts.Find(delegate (Contact contact) { return curItem == contact.GetFullName(); });
            _context.Contact.Remove(curContact);

            foreach (Address address in curContact.Address)
                _context.Address.Remove(address);
            foreach (Phone phone in curContact.Phone)
                _context.Phone.Remove(phone);
            foreach (Date date in curContact.Date)
                _context.Date.Remove(date);

            _context.SaveChanges();
        }



        private void FillForm(Contact contact)
        {
            ClearForm();

            tbFirstName.Text = contact.FirstName;
            tbMiddleName.Text = contact.MiddleName;
            tbLastName.Text = contact.LastName;

            foreach (Address address in contact.Address)
            {
                string[] row = { address.AddressType.ToString(), address.StreetApt, address.City, address.State, address.Zip.ToString() };
                gridAddresses.Rows.Add(row);
            }

            foreach (Phone phone in contact.Phone)
            {
                string[] row = { phone.PhoneType.ToString(), phone.AreaCode, phone.Number };
                gridPhones.Rows.Add(row);
            }

            foreach (Date date in contact.Date)
            {
                string[] row = { date.DateType.ToString(), date.Date1.Date.ToString() };
                gridDates.Rows.Add(row);
            }
        }

        private void ClearForm()
        {
            tbFirstName.Clear();
            tbMiddleName.Clear();
            tbLastName.Clear();

            gridAddresses.Rows.Clear();
            gridAddresses.Refresh();

            gridPhones.Rows.Clear();
            gridPhones.Refresh();

            gridDates.Rows.Clear();
            gridDates.Refresh();
        }

        private void gridAddresses_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Context == DataGridViewDataErrorContexts.Parsing)
            {
            }
        }
        private void gridDates_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Context == DataGridViewDataErrorContexts.Parsing)
            {
            }
        }
        private void gridPhones_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Context == DataGridViewDataErrorContexts.Parsing)
            {
            }
        }
    }
}
