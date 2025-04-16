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


            Product apple = new Product()
            {
                Name = "Apple",
                Price = 5

            };
            Product pineapple = new Product
            {
                Name = "PineApple",
                Price = 15
            };



            var homeDelivery = new HomeDelivery()
            {

                Address = address.ToString()
            };

            Order<HomeDelivery, Customer> order = new Order<HomeDelivery, Customer>(homeDelivery);
            order.AddProduct(apple, 7);
            order.AddProduct(pineapple, 25);

            order.ShowProducts();
            order.DisplayAddress();

            Console.WriteLine($" {customer.id} / Клиент - {customer.FullName}, {customer.PhoneNumber}, {customer.Address} ");

            Console.WriteLine($"{courier.id} / Курьером назначен  -  {courier.FullName}, {courier.PhoneNumber}, {courier.Address}");
        }
    }
}
