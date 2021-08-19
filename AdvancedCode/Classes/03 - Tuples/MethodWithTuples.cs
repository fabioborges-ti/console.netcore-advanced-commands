using AdvancedCode.Base;
using System;
using System.Collections.Generic;

namespace AdvancedCode.Classes
{
    public class MethodWithTuples : IClassRoom
    {
        public void RunTest()
        {
            #region sample 1

            var data1 = GetCustomerTotalValue();

            Console.WriteLine("Sample 1...");
            Console.WriteLine("**************************");
            Console.WriteLine("Customer name: " + data1.Item1);
            Console.WriteLine("Total: " + data1.Item2.ToString("C0"));
            Console.WriteLine('\n');

            #endregion

            #region sample 2
            
            var data2 = GetCustomerTotalValueWithName();
            
            Console.WriteLine("Sample 2...");
            Console.WriteLine("**************************");
            Console.WriteLine("Customer name: " + data2.CustomerName);
            Console.WriteLine("Total: " + data2.TotalValue.ToString("C0"));
            Console.WriteLine('\n');

            #endregion

            #region sample 3

            var data3 = GetCustomerTotalValues();

            foreach (var customer in data3)
            {
                Console.WriteLine("Sample 3...");
                Console.WriteLine("**************************");
                Console.WriteLine("Customer name: " + customer.CustomerName);
                Console.WriteLine("Total: " + customer.TotalValue.ToString("C0"));
                Console.WriteLine('\n');
            }

            #endregion
        }

        private (string, decimal) GetCustomerTotalValue()
        {
            return ("John", 1000m);
        }

        private (string CustomerName, decimal TotalValue) GetCustomerTotalValueWithName()
        {
            return (CustomerName:"Doe", TotalValue: 2500m);
        }

        public IEnumerable<(string CustomerName, decimal TotalValue)>  GetCustomerTotalValues()
        {
            var customers = new List<(string CustomerName, decimal TotalValue)>
            {
                ("John", 1500m), 
                ("Doe", 2000m), 
                ("Peter", 1800m), 
                ("Eddie", 1200m)
            };

            return customers;
        }
    }
}
