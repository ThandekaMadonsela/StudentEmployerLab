using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEmployerLab.Models
{
    internal class Address
    {
        public string AddressName { get; set; }
        public string Street { get; set; }
        public string CityOrTown { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }

        public override string ToString()
        {
            return $"{AddressName}, {Street}, {CityOrTown}, {Province}, {PostalCode}";
        }
    }
}
