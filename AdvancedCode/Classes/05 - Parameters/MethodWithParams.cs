using AdvancedCode.Base;
using System;
using System.Collections.Generic;

namespace AdvancedCode.Classes
{
    public class MethodWithParams : IClassRoom
    {
        public void RunTest()
        {
            #region sample 1

            Console.WriteLine("Sample 1");
            Console.WriteLine("*************");

            DeleteCustormerId(1);
            DeleteCustormerId(2);
            DeleteCustormerId(3);
            DeleteCustormerId(4);
            DeleteCustormerId(5);

            Console.WriteLine('\n');

            #endregion

            #region sample 2

            Console.WriteLine("Sample 2");
            Console.WriteLine("*************");

            DeleteCustormerId(new List<int> { 1, 2, 3, 4, 5 });

            Console.WriteLine('\n');

            #endregion

            #region sample 3

            Console.WriteLine("Sample 3");
            Console.WriteLine("*************");

            DeleteCustormerIdWithParams(1, 2, 3, 4, 5);

            Console.WriteLine('\n');

            #endregion

            #region sample 4

            Console.WriteLine("Sample 4");
            Console.WriteLine("*************");

            DeleteCustormerIdWithParams("Delete customer with id: ", 1, 2, 3, 4, 5);

            Console.WriteLine('\n');

            #endregion
        }

        #region PRIVATES METHODS

        private static void DeleteCustormerId(int id)
        {
            Console.WriteLine("Delete customer with id: " + id);
        }

        private static void DeleteCustormerId(IEnumerable<int> ids)
        {
            foreach (var id in ids)
            {
                Console.WriteLine("Delete customer with id: " + id);
            }
        }

        private static void DeleteCustormerIdWithParams(params int[] ids)
        {
            foreach (var id in ids)
            {
                Console.WriteLine("Delete customer with id: " + id);
            }
        }

        private static void DeleteCustormerIdWithParams(string text, params int[] ids)
        {
            foreach (var id in ids)
            {
                Console.WriteLine($"{text} {id}");
            }
        }

        #endregion
    }
}
