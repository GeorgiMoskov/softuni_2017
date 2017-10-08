using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T17_PrintPartOfTheAscii
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch1Code = int.Parse(Console.ReadLine());
            int ch2Code = int.Parse(Console.ReadLine());

            for(int i = ch1Code; i <= ch2Code; i++)
            {
                Console.Write("{0} ", (char)i);
            }
        }
    }
}
