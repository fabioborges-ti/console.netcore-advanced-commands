using AdvancedCode.Base;
using System;

namespace AdvancedCode.Classes
{
    public class UsingDelegateWithLambda : IClassRoom
    {
        private delegate void WriteTextInConsole(string text);

        public void RunTest()
        {
            WriteTextInConsole writeInConsole = customerName => Console.WriteLine($"Welcome {customerName}");

            writeInConsole("John Doe");

            // -------------------------------

            writeInConsole = message => Console.WriteLine($"Message: {message}");

            writeInConsole("This is a message for you");

            // -------------------------------
            
            writeInConsole = customerName => Console.WriteLine($"Bye, {customerName}");

            writeInConsole("John");
        }
    }
}
