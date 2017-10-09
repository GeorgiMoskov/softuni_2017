using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T15_DebuggingSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int subStrLen =jump;

                    if (subStrLen >= text.Length- i)
                    {
                        subStrLen = text.Length - i-1;
                    }

                    string matchedString = text.Substring(i,subStrLen+1);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (hasMatch == false)
            {
                Console.WriteLine("no");
            }

        }
    }
}
