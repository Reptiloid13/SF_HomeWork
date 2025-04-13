using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryHW_03
{
    public abstract class Delivery
    {

        public string Address;



    }

    public class HomeDelivery : Delivery
    {
        Courier Courier;


    }

    public class PickPointDelivery : Delivery
    {
        public PickPointDelivery(string address)
        {
            Address = address;
        }
    }

    public class ShopDelivery : Delivery
    {

    }
}
