
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
            toFind = toFind.ToLower();
            return (AddressType.ToString().ToLower() == toFind ||
                StreetApt.ToLower().Contains(toFind) ||
                City.ToLower().Contains(toFind) ||
                State.ToLower().Contains(toFind) ||
                Zip.ToString().ToLower() == toFind);
        }

        public string GetFullAddress()
        {
            return StreetApt + " " + City + " " + State + " " + Zip;
        }
    }
}
