
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
            toFind = toFind.ToLower();
            string fullNumber = AreaCode + Number;
            return (PhoneType.ToString().ToLower() == toFind ||
                AreaCode.ToLower() == toFind ||
                Number.ToLower() == toFind ||
                fullNumber.ToLower() == toFind);
        }

        public string GetFullNumber()
        {
            return AreaCode + Number;
        }
    }
}
