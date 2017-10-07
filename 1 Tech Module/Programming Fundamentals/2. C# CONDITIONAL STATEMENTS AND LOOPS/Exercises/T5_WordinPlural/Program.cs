using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_WordinPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            if(str[str.Length-1] == 'y')
            {
                str = str.Remove(str.Length - 1);
                str = str + "ies";
            }
            else if( str.EndsWith("o") || str.EndsWith("ch") || str.EndsWith("s") || str.EndsWith("sh") || str.EndsWith("x") || str.EndsWith("z"))
            {
                str = str + "es";
            }
            else
            {
                str = str + "s";
            }

            Console.WriteLine(str);
            
        }
    }
}
