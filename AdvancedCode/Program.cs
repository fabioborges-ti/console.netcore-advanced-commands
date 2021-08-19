using AdvancedCode.Classes;
using System;

namespace AdvancedCode
{
    internal static class Program
    {
        private static void Main()
        {
            var classRoom = new MyFirstCode();
            //var classRoom = new StringInterpolation();
            //var classRoom = new VerbatimStringLiteral();
            //var classRoom = new MethodWithTuples();
            //var classRoom = new LocalFunctions();
            //var classRoom = new MethodWithNamedParams();
            //var classRoom = new MethodWithParams();
            //var classRoom = new ExtensionMethods();
            //var classRoom = new Yields();
            //var classRoom = new UsingDelegate();
            //var classRoom = new UsingDelegateWithParams();
            //var classRoom = new UsingDelegateWithReturns();
            //var classRoom = new UsingDelegateWithLambda();
            //var classRoom = new UsingDelegateWithFunc();
            //var classRoom = new Func();

            classRoom.RunTest();

            Console.ReadLine();
        }
    }
}
