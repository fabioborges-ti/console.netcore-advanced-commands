using AdvancedCode.Base;
using System;
using System.Collections.Generic;

namespace AdvancedCode.Classes
{
    public enum Banks
    {
        BancoDoBrasil = 1,
        Cef = 2,
        Itau = 3,
        Bradesco = 4,
        Santander = 5
    }

    public class Yields : IClassRoom
    {
        public void RunTest()
        {
            #region sample 1

            foreach (var bank in AllBanks())
            {
                Console.WriteLine(bank.ToString());
            }

            Console.WriteLine('\n');
            
            #endregion

            #region sample 2

            Console.WriteLine("before...");

            foreach (var digit in GetSingleDigits())
            {
                Console.WriteLine($"# {digit}");
            }

            Console.WriteLine("after...");
            Console.WriteLine('\n');

            #endregion
        }

        private static IEnumerable<Banks> AllBanks()
        {
            yield return Banks.BancoDoBrasil;
            yield return Banks.Cef;
            yield return Banks.Itau;
            yield return Banks.Bradesco;
            yield return Banks.Santander;
        }

        private static IEnumerable<int> GetSingleDigits()
        {
            for (var count = 0; count <= 9; count++)
            {
                yield return count;
            }
        }
    }
}
