using AdvancedCode.Base;
using System;

namespace AdvancedCode.Classes
{
    public class UsingDelegateWithFunc : IClassRoom
    {
        private delegate int CalculateAndWrite();

        private delegate int CalculateAndWriteNumber(int num1, int num2);
        
        public void RunTest()
        {
            #region sample 1

            CalculateAndWrite calculateAndWrite = () => 10 + 20;

            var result1 = calculateAndWrite();

            Console.WriteLine($"Total: {result1}");

            #endregion

            #region sample 2

            CalculateAndWriteNumber calculateAndWriteNumber = (num1, num2) => num1 + num2;

            var result2 = calculateAndWriteNumber(10, 50);

            Console.WriteLine($"Total: {result2}");

            #endregion
        }
    }
}
