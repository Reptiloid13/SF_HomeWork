using System.Security.Cryptography.X509Certificates;
using Task1;
using Task2;

namespace DZSkilFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task1();
            Task2();

        }



        public static void Task1()
        {
            Exceptions exceptions = new Exceptions();

            foreach (Exception ex in exceptions.ExceptionsArray)
            {
                try
                {
                    throw ex;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }
            }
        }

        public static void Task2()

        {
            LastNamesCollection lastNames = new LastNamesCollection();

            InputReader inputReader = new InputReader();
            inputReader.NumberEnter += lastNames.Sort;

            inputReader.ReeadInput();

            foreach (string name in lastNames.Items)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
