using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryHW_03
{
    public class Order<TDelivery, TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;



        private Guid _id = Guid.NewGuid();
        public Guid id => _id;

        public Dictionary<Product, int> Products;



        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

    }
}
