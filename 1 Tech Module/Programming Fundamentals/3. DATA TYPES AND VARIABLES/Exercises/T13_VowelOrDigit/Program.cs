using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13_VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            ch = Char.ToLower(ch);

            if (Char.IsDigit(ch))
            {
                Console.WriteLine("digit");
            }
            else if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'y')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
