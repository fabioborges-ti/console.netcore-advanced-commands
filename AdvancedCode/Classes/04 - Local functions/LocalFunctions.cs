using AdvancedCode.Base;
using System;

namespace AdvancedCode.Classes
{
    public class LocalFunctions : IClassRoom
    {
        public void RunTest()
        {
            // sample 1
            var total1 = CalculateTax(1500);

            Console.WriteLine("Sample 1");
            Console.WriteLine("************");
            Console.WriteLine($"Total value with Tax is: {total1:C2}");
            Console.WriteLine('\n');

            // sample 2
            var total2 = CalculateTax(500);

            Console.WriteLine("Sample 2");
            Console.WriteLine("************");
            Console.WriteLine($"Total value with Tax is: {total2:C2}");
            Console.WriteLine('\n');

            // sample 3
            var total3 = CalculateTax(1800);

            Console.WriteLine("Sample 3");
            Console.WriteLine("************");
            Console.WriteLine($"Total value with Tax is: {total3:C2}");
            Console.WriteLine('\n');

            static decimal CalculateTax(decimal totalValue)
            {
                if (totalValue < 1000)
                {
                    return totalValue + 5;
                }

                return totalValue + 10;
            }
        }
    }
}
