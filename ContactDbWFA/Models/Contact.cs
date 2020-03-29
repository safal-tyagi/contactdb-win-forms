using System.Collections.Generic;

namespace ContactDbWFA.Models
{
    public partial class Contact
    {
        public Contact()
        {
            Address = new HashSet<Address>();
            Date = new HashSet<Date>();
            Phone = new HashSet<Phone>();
        }

        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<Date> Date { get; set; }
        public virtual ICollection<Phone> Phone { get; set; }

        public bool Find(string toFind)
        {
            toFind = toFind.ToLower();
            return (FirstName.ToLower().Contains(toFind) ||
                MiddleName.ToLower().Contains(toFind) ||
                LastName.ToLower().Contains(toFind));
        }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }
    }
}
