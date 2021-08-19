using AdvancedCode.Base;
using System;

namespace AdvancedCode.Classes
{
    public class UsingDelegateWithReturns : IClassRoom
    {
        private delegate double Operation(double num1, double num2);

        public void RunTest()
        {
            #region sample 1

            Operation oper = Sum;

            var sum = oper(20, 5);

            Console.WriteLine($"Sum result: {sum}");

            #endregion

            #region sample 2

            oper = Multiply;

            var multiply = oper(10, 5);

            Console.WriteLine($"Multiply result: {multiply}");

            #endregion

            #region sample 3

            oper = Divide;

            var divide = oper(30, 3);

            Console.WriteLine($"Divide result: {divide}");

            #endregion

            #region sample 4

            DoOperation(Sum, 30, 10);
            DoOperation(Multiply, 30, 10);
            DoOperation(Divide, 30, 10);

            #endregion
        }

        #region PRIVATES METHODS

        private static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        private static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        private static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        private static void DoOperation(Operation operation, double num1, double num2)
        {
            Console.WriteLine("\n");

            Console.WriteLine($"This is an operation {operation.Method.Name}");

            Console.WriteLine($"Number 1: {num1}");
            Console.WriteLine($"Number 2: {num2}");

            var result = operation(num1, num2);

            Console.WriteLine($"Result: {result}");
        }

        #endregion
    }
}
