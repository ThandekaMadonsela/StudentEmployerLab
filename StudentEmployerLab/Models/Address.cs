
namespace StudentEmployerLab.Models
{
    internal struct Address
    {
        public string AddressName { get; set; }
        public string Street { get; set; }
        public string CityOrTown { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }

        public string ToString()
        {
            return $"{AddressName}, {Street}, {CityOrTown}, {Province}, {PostalCode}";
        }
    }
}
