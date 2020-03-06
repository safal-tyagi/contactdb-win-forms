using System;
using System.Collections.Generic;

namespace ContactDbWFA.Models
{
    public enum AddressType
    {
        Home = 1,
        Work = 2,
        Fax = 3
    }

    public partial class Address
    {
        public int AddressId { get; set; }
        public int ContactId { get; set; }
        public int AddressType { get; set; }
        public string StreetApt { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        public virtual Contact Contact { get; set; }

        public bool Find(string toFind)
        {
            return (AddressType.ToString() == toFind ||
                StreetApt.Contains(toFind) ||
                City.Contains(toFind) ||
                State.Contains(toFind) ||
                Zip.ToString() == toFind);
        }

        public string GetFullAddress()
        {
            return StreetApt + " " + City + " " + State + " " + Zip;
        }
    }
}
