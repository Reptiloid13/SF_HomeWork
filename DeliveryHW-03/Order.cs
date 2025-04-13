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

        private int number;
        public int Number
        {
            get { return number; }
        }

        private Guid _id = Guid.NewGuid();
        public Guid id => _id;


        public string Description; // Нужно ли это поле? 

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

    }
}
