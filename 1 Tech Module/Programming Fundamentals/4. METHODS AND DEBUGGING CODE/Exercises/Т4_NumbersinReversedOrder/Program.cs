using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т4_NumbersinReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());

            NumberinReversedOrder(num);
        }

        private static void NumberinReversedOrder(decimal num)
        {
            string strNum = num.ToString();

            for (int y = strNum.Length-1; y >= 0; y--)
            {
                Console.Write(strNum.ElementAt(y));
            }
            

        }
    }
}
