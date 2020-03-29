using ContactDbWFA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();

            lstSearchResults.Clear();
            ClearForm();

            string searchString = tbSearch.Text;
            List<Tuple<int, string>> relevantContacts = new List<Tuple<int, string>>();
            if (searchString == "*")
            {
                foreach (Contact contact in _contacts)
                {
                    string fullName = contact.FirstName + " " + contact.MiddleName + " " + contact.LastName;
                    var tuple = Tuple.Create(contact.ContactId, fullName);
                    relevantContacts.Add(tuple);
                }
            }
            else
            {
                string[] subStrings = Regex.Split(searchString, " ");

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
                            var tuple = Tuple.Create(contact.ContactId, fullName);
                            relevantContacts.Add(tuple);
                        }
                    }
                }
            }

            var uniqueContacts = relevantContacts.Distinct();
            foreach (var contact in uniqueContacts)
            {
                string[] subItems = { contact.Item2 , contact.Item1.ToString()};
                ListViewItem item = new ListViewItem(subItems, "");
                lstSearchResults.Items.Add(item);
            }
        }

        private void lstSearchResults_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lstSearchResults.SelectedItems.Count == 0) return;
            int selContactId = int.Parse(lstSearchResults.SelectedItems[0].SubItems[1].Text);
            Contact curContact = _contacts.Find(delegate (Contact contact) { return selContactId == contact.ContactId; });

            FillForm(curContact);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Contact contact = ReadForm();
            using (_context = new ContactDbContext())
            {
                _context.Contact.Add(contact);
                _context.Address.AddRange(contact.Address);
                _context.Date.AddRange(contact.Date);
                _context.Phone.AddRange(contact.Phone);
                _context.SaveChanges();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstSearchResults.SelectedItems.Count == 0) return;
            Contact contact = ReadForm();
            using (_context = new ContactDbContext())
            {
                _context.Contact.Update(contact);
                _context.Address.UpdateRange(contact.Address);
                _context.Phone.UpdateRange(contact.Phone);
                _context.Date.UpdateRange(contact.Date);
                _context.SaveChanges();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstSearchResults.SelectedItems.Count == 0) return;

            string curItem = lstSearchResults.SelectedItems[0].Text;
            Contact curContact = _contacts.Find(delegate (Contact contact) { return curItem == contact.GetFullName(); });
            using (_context = new ContactDbContext())
            {
                _context.Address.RemoveRange(curContact.Address);
                _context.Phone.RemoveRange(curContact.Phone);
                _context.Date.RemoveRange(curContact.Date);
                _context.Contact.Remove(curContact);
                _context.SaveChanges();
            }

            lstSearchResults.Refresh();
            ClearForm();
        }


        private void LoadData()
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

        private Contact ReadForm()
        {
            Contact contact = new Contact();

            contact.ContactId = 0; // CLR default
            contact.FirstName = tbFirstName.Text;
            contact.MiddleName = tbMiddleName.Text;
            contact.LastName = tbLastName.Text;
            List<Address> addresses = new List<Address>();
            for (int rowId = 0; rowId < gridAddresses.Rows.Count - 1; rowId++)
            {
                DataGridViewRow row = gridAddresses.Rows[rowId];
                int addressId = 0;
                if (row.Cells["colAddressId"].FormattedValue.ToString() == "") addressId = 0;
                else addressId = int.Parse(row.Cells["colAddressId"].FormattedValue.ToString());

                Address address = new Address
                {
                    AddressId = addressId,
                    AddressType = int.Parse(row.Cells["colAddressType"].Value.ToString()),
                    StreetApt = row.Cells["colStreetApt"].Value.ToString(),
                    City = row.Cells["colCityName"].Value.ToString(),
                    State = row.Cells["colStateName"].Value.ToString(),
                    Zip = int.Parse(row.Cells["colZipCode"].Value.ToString())
                };
                addresses.Add(address);
            }

            var thTH = new System.Globalization.CultureInfo("th-TH");
            List<Date> dates = new List<Date>();
            for (int rowId = 0; rowId < gridDates.Rows.Count - 1; rowId++)
            {
                DataGridViewRow row = gridDates.Rows[rowId];
                int dateId = 0;
                if (row.Cells["colDateId"].FormattedValue.ToString() == "") dateId = 0;
                else dateId = int.Parse(row.Cells["colDateId"].FormattedValue.ToString());

                Date date = new Date
                {
                    DateId = dateId,
                    DateType = int.Parse(row.Cells["colDateType"].Value.ToString()),
                    Date1 = DateTime.ParseExact(row.Cells["colDate"].Value.ToString(), "MM/dd/yyyy", thTH)
                };
                dates.Add(date);
            }

            List<Phone> phones = new List<Phone>();
            for (int rowId = 0; rowId < gridPhones.Rows.Count - 1; rowId++)
            {
                DataGridViewRow row = gridPhones.Rows[rowId];
                int phoneId = 0;
                if (row.Cells["colPhoneId"].FormattedValue.ToString() == "") phoneId = 0;
                else phoneId = int.Parse(row.Cells["colPhoneId"].FormattedValue.ToString());
                string phoneNo = row.Cells["colPhoneNumber"].Value.ToString();

                Phone phone = new Phone
                {
                    PhoneId = phoneId,
                    PhoneType = int.Parse(row.Cells["colPhoneType"].Value.ToString()),
                    //AreaCode = row.Cells["colAreaCode"].Value.ToString(),
                    AreaCode = phoneNo.Substring(0, 3),
                    //Number = row.Cells["colPhoneNumber"].Value.ToString()
                    Number = phoneNo.Substring(3)
                };
                phones.Add(phone);
            }

            contact.Address = addresses;
            contact.Date = dates;
            contact.Phone = phones;
            
            return contact;
        }

        private void FillForm(Contact contact)
        {
            ClearForm();

            tbFirstName.Text = contact.FirstName;
            tbMiddleName.Text = contact.MiddleName;
            tbLastName.Text = contact.LastName;

            foreach (Address address in contact.Address)
            {
                string[] row = { address.AddressId.ToString(), address.AddressType.ToString(), address.StreetApt, address.City, address.State, address.Zip.ToString() };
                gridAddresses.Rows.Add(row);
            }

            foreach (Phone phone in contact.Phone)
            {
                string[] row = { phone.PhoneId.ToString(), phone.PhoneType.ToString(), phone.AreaCode, phone.GetFullNumber() };
                gridPhones.Rows.Add(row);
            }

            foreach (Date date in contact.Date)
            {
                string[] row = { date.DateId.ToString(), date.DateType.ToString(), date.Date1.Date.ToString("MM/dd/yyyy") };
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
    }
}
