using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryHW_03
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }

        public override string ToString()
        {
            return $"{City}, {Street}, {HouseNumber}";
        }


    }
}
