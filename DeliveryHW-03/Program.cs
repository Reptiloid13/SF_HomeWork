namespace DeliveryHW_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer()
            {
                FirstName = " Marty",
                LastName = "Lebovsky",
                PhoneNumber = "+79651111112"




            };

            Address address = new Address
            {
                City = "Moscow",
                Street = "Lenina",
                HouseNumber = "21"
            };

            Courier courier = new Courier()
            {
                FirstName = "Johnabek",
                LastName = "TravoltaOgly",
                PhoneNumber = "+79651111111"


            };


            Product product1 = new Product()
            {
                Name = "Apple",
                Price = 5

            };
            Product product2 = new Product
            {
                Name = "PineApple",
                Price = 15
            };



            var homeDelivery = new HomeDelivery()
            {

                Address = address.ToString()
            };

            Order<HomeDelivery, Customer> order = new Order<HomeDelivery, Customer>(homeDelivery);
            order.AddProduct(product1, 7);
            order.AddProduct(product2, 25);

            order.ShowProducts();
            order.DisplayAddress();

            Console.WriteLine($" ID - {customer.id} / Клиент - {customer.FullName}, {customer.PhoneNumber}, {customer.Address} ");

            Console.WriteLine($"ID - {courier.id} / Курьером назначен  -  {courier.FullName}, {courier.PhoneNumber}, {courier.Address}");
        }
    }
}
