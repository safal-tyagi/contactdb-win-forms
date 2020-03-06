using System;
using System.Collections.Generic;

namespace ContactDbWFA.Models
{
    public partial class Phone
    {
        public int PhoneId { get; set; }
        public int ContactId { get; set; }
        public int PhoneType { get; set; }
        public string AreaCode { get; set; }
        public string Number { get; set; }

        public virtual Contact Contact { get; set; }

        public bool Find(string toFind)
        {
            string fullNumber = AreaCode + Number;
            return (PhoneType.ToString() == toFind ||
                AreaCode == toFind ||
                Number == toFind ||
                fullNumber == toFind);
        }

        public string GetFullNumber()
        {
            return AreaCode + Number;
        }
    }
}
