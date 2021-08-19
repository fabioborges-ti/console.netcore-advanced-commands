using AdvancedCode.Base;
using System;

namespace AdvancedCode.Classes
{
    public class ExtensionMethods : IClassRoom
    {
        public void RunTest()
        {
            // sample 1
            const string test = "This is a test";
            test.WriteInConsole();

            // sample 2            
            const string customerName = "John Doe";
            customerName.WriteInConsole();

            // sample 3
            const int myAge = 26;
            myAge.WriteInConsole();

            // sample 4
            const decimal myMonew = 1200.88m;
            myMonew.WriteInConsole();
        }
    }

    public static class Extensions
    {
        public static void WriteInConsole(this string text)
        {
            Console.WriteLine(text);
        }

        public static void WriteInConsole(this int number)
        {
            Console.WriteLine(number);
        }

        public static void WriteInConsole(this decimal price)
        {
            Console.WriteLine(price.ToString("C2"));
        }
    }
}
