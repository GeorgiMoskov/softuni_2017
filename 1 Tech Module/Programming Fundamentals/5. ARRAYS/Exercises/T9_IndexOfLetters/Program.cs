using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9_IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charIndex = new char[123 - 97];

            for(int i = 0; i <= 122-97; i++)
            {
                charIndex[i] = (char)(i + 97);
            }

            string word = Console.ReadLine().ToLower();

            for (int i = 0; i < word.Length; i++)
            {
                for(int y = 0; y < charIndex.Length; y++)
                {
                    if(word[i] == charIndex[y])
                    {
                        Console.WriteLine("{0} -> {1}", word[i], y);
                        break;
                    }
                }
            }
        }
    }
}
