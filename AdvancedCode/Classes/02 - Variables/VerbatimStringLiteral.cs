using AdvancedCode.Base;
using System;

namespace AdvancedCode.Classes
{
    public class VerbatimStringLiteral : IClassRoom
    {
        public void RunTest()
        {
            #region sample 1

            // forma tradicional 
            const string sql1 = "   select c.* " +
                                "     from customer c inner join Orders o " +
                                "       on c.CustomerId = o.CustomerId " +
                                "    where c.CustomerId = 15 " +
                                "    order by c.CustomerName ";

            Console.WriteLine(sql1);
            Console.WriteLine('\n');

            // verbatim string
            const string sql2 = @"select c.*                                       
                                   from customer c inner join Orders o 
                                     on c.CustomerId = o.CustomerId 
                                  where c.CustomerId = 15 
                               order by c.CustomerName";

            Console.WriteLine(sql2);
            Console.WriteLine('\n');

            #endregion

            #region sample 2

            // forma tradicional 
            const string path1 = "c:\\documents\\files\\myfiles.txt";
            Console.WriteLine(path1);
            Console.WriteLine('\n');

            // verbatim string
            const string path2 = @"c:\documents\files\myfiles.txt";
            Console.WriteLine(path2);
            Console.WriteLine('\n');

            #endregion

            #region sample 3

            // variáveis nomeadas com palavras reservadas 

            var @for = new[] {"John", "Doe", "Lucy", "Mary"};

            foreach (var @string in @for)
            {   
                Console.WriteLine(@string);
            }

            Console.WriteLine('\n');

            // variáveis nomeadas com palavras reservadas 

            const string @class = "Database Class";

            Console.WriteLine(@class);
            Console.ReadLine();

            #endregion
        }
    }
}
