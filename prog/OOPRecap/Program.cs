// See https://aka.ms/new-console-template for more information
using System.Collections.ObjectModel;

namespace OOPRecap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Collection<Orders> ordersCollection = new Collection<Orders>();

            Console.Write("What is the order id> ");
            string? orderId = Console.ReadLine();

            Console.Write("What is the customer name> ");
            string? customerName = Console.ReadLine();

            Console.Write("What is the number of burgers> ");
            int numberOfBurgers = Int32.Parse(Console.ReadLine());

            Console.Write("What is the number of drinks> ");
            int numberOfDrinks = Int32.Parse(Console.ReadLine());

            ordersCollection.Add(new Orders(orderId, customerName, numberOfBurgers, numberOfDrinks));

            foreach (var order in ordersCollection)
            {
                Console.WriteLine(order.ToString());
            }

            Console.ReadLine();
        }
    }
}