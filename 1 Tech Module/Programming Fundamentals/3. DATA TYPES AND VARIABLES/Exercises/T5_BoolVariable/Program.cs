using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_BoolVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            if (Convert.ToBoolean(str))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
