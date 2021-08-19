using AdvancedCode.Base;
using System;

namespace AdvancedCode.Classes
{
    public class MethodWithNamedParams : IClassRoom
    {
        public void RunTest()
        {
            // sample 1
            WriteDetails("John Doe", "Last Av.", "London", 30, 1000m);
            // sample 2
            WriteDetails("Mary", "Last Av.", "London", 30);
            // sample 3
            WriteDetails("Peter", "Last Av.", "Paris");
            // sample 4
            WriteDetails("Luke", "Last Av.", "Paris", totalPurchased: 1500m);
        }

        private static void WriteDetails(string customerName, string address, string city, int age = 0, decimal totalPurchased = 0)
        {
            Console.WriteLine($"Customer name: {customerName}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"City: {city}");

            if (age > 0)
            {
                Console.WriteLine($"Age: {age}");
            }

            if (totalPurchased > 0)
            {
                Console.WriteLine($"Total purchased: {totalPurchased:C2}");
            }

            Console.WriteLine("*************************************");
        }
    }
}
