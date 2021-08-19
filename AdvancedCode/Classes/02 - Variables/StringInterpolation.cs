using AdvancedCode.Base;
using System;

namespace AdvancedCode.Classes
{
    public class StringInterpolation : IClassRoom
    {
        public void RunTest()
        {
            const string customerName = "John Doe";

            #region sample 1

            var description = "Customer Name: " + customerName + ". He is a customer since " + DateTime.Now.ToString("dd/MM/yyyy") + "";
            var anotherWay = $"Customer Name: {customerName}. He is a customer since {DateTime.Now:dd/MM/yyyy} ";

            Console.WriteLine(description);
            Console.WriteLine(anotherWay);
            Console.WriteLine('\n');

            #endregion

            #region sample 2 

            var leftText = $"Customer name (left): {customerName,-20}."; // texto alinhado a esquerda
            var rightText = $"Customer name (right): {customerName,20}."; // texto alinhado a direita

            Console.WriteLine(leftText);
            Console.WriteLine(rightText);
            Console.WriteLine('\n');

            #endregion

            #region sample 3

            const decimal value1 = 29800.899m;
            const decimal value2 = 450.900m;

            var order1 = $"This customer purchase:{value1,20:F2}"; // formatação com arredondamento
            var order2 = $"This customer purchase:{value2,20:F2}"; // formatação com arredondamento

            Console.WriteLine(order1);
            Console.WriteLine(order2);
            Console.ReadLine();

            #endregion
        }
    }
}
