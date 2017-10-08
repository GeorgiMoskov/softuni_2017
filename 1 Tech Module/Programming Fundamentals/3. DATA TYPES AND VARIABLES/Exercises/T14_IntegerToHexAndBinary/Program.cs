using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T14_IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string numInHex = Convert.ToString(num, 16);
            string numInBin = Convert.ToString(num, 2);

            Console.WriteLine( numInHex.ToUpper() ) ;
            Console.WriteLine(numInBin);

        }
    }
}
