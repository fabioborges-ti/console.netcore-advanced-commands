using AdvancedCode.Base;
using System;

namespace AdvancedCode.Classes
{
    public class UsingDelegate : IClassRoom
    {
        private delegate void WriteInConsole();

        private static void WriteWelcome()
        {
            Console.WriteLine("Welcome to our class!");
        }

        private static void WriteMessage()
        {
            Console.WriteLine("Today we'll talk about delegates!");
        }

        private static void WriteBye()
        {
            Console.WriteLine("Bye!!");
        }

        public void RunTest()
        {
            WriteInConsole writeInConsole = WriteWelcome;
            writeInConsole();

            writeInConsole = WriteMessage;
            writeInConsole();
            
            writeInConsole = WriteBye;
            writeInConsole();
        }
    }
}
