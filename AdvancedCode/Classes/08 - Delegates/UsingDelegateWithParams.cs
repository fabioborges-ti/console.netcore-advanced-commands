using AdvancedCode.Base;
using System;

namespace AdvancedCode.Classes
{
    public class UsingDelegateWithParams : IClassRoom
    {
        private delegate void WriteInConsole(string text);

        public void RunTest()
        {
            WriteInConsole writeInConsole = WriteWelcome;
            writeInConsole("John Doe");

            writeInConsole = WriteMessage;
            writeInConsole($"{DateTime.Now:d} - You purchased today");

            writeInConsole = WriteBye;
            writeInConsole("John");
        }

        #region PRIVATES METHOS

        private static void WriteWelcome(string customerName)
        {
            Console.WriteLine($"Welcome {customerName}!");
        }

        private static void WriteMessage(string text)
        {
            Console.WriteLine(text);
        }

        private static void WriteBye(string text)
        {
            Console.WriteLine($"Bye, {text}");
        }

        #endregion
    }
}
