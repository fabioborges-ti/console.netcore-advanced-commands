using AdvancedCode.Base;
using System;

namespace AdvancedCode.Classes
{
    public class Func : IClassRoom
    {
        public void RunTest()
        {
            #region sample 1

            Func<int> calculate = () => 10 + 20;

            var sum1 = calculate();

            Console.WriteLine(sum1);

            #endregion

            #region sample 2

            Func<int, int, int> calculateArgs = (num1, num2) => num1 + num2;

            var sum2 = calculateArgs(50, 20);

            Console.WriteLine(sum2);

            #endregion

            #region sample 3

            Func<int, int, string> calculateAndWriteResult = (num1, num2) =>
            {
                var sum = num1 + num2;

                return "The result is " + sum;
            };

            CalculateAndWriteNumbers(calculateAndWriteResult);

            #endregion

            #region sample 4

            var multiplyFunc = GetMultiplyFunc();

            var result = multiplyFunc(10, 5);

            Console.WriteLine($"Total: {result}");

            #endregion
        }

        private static void CalculateAndWriteNumbers(Func<int, int, string> calculateAndWriteResult)
        {
            var message = calculateAndWriteResult(32, 35);

            Console.WriteLine(message);
        }

        private static Func<int, int, int> GetMultiplyFunc()
        {
            Func<int, int, int> multiply = (num1, num2) => num1 * num2;

            return multiply;
        }
    }
}
