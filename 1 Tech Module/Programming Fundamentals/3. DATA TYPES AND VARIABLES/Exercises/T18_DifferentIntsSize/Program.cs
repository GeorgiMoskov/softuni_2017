using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace T18_DifferentIntsSize
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger num = BigInteger.Parse(Console.ReadLine());

            if (num <= long.MaxValue && num >= long.MinValue)
            {
                Console.WriteLine("{0} can fit in:",num);
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type",num);
                return;
            }

            if (num<= sbyte.MaxValue && num >= sbyte.MinValue)
             {
                Console.WriteLine("* sbyte");
             }
            if (num <= byte.MaxValue && num >= byte.MinValue)
            {
                Console.WriteLine("* byte");
            }
            if (num <= short.MaxValue && num >= short.MinValue)
            {
                Console.WriteLine("* short");
            }
            if (num <= ushort.MaxValue && num >= ushort.MinValue)
            {
                Console.WriteLine("* ushort");
            }
            if (num <= int.MaxValue && num >= int.MinValue)
            {
                Console.WriteLine("* int");
            }
            if (num <= uint.MaxValue && num >= uint.MinValue)
            {
                Console.WriteLine("* uint");
            }
            Console.WriteLine("* long");


        }

    }
}

