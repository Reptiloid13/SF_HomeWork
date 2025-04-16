using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
            Console.WriteLine($"Адрес доставки - {Delivery.Address}");
        }

        public Order(TDelivery delivery)
        {
            Delivery = delivery;
            Products = new Dictionary<Product, int>();
        }
        public void AddProduct(Product product, int quantity)
        {
            if (Products.ContainsKey(product))
                Products[product] += quantity;
            else
                Products.Add(product, quantity);
        }
        public void ShowProducts()
        {
            Console.WriteLine($"Заказ - {id}");
            foreach (var product in Products)
            {
                Console.WriteLine($"{product.Key} {product.Value} шт.");
            }
        }
    }
}
