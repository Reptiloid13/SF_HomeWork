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



                Address = new Address()
                {
                    City = "Moscow",
                    Street = "Lenina",
                    HouseNumber = 21
                }
            };

            Console.WriteLine($"{customer.id}: {customer.FullName}, {customer.Address}");
        }
    }
}
