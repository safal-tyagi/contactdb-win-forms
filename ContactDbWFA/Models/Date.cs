using System;
using System.Collections.Generic;

namespace ContactDbWFA.Models
{
    public partial class Date
    {
        public int DateId { get; set; }
        public int ContactId { get; set; }
        public int DateType { get; set; }
        public DateTime Date1 { get; set; }

        public virtual Contact Contact { get; set; }

        public bool Find(string toFind)
        {
            return (DateType.ToString() == toFind ||
                Date1.ToString() == toFind);
        }
    }
}
