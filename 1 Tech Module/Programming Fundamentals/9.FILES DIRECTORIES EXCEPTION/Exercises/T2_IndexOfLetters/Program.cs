using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace T2_IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26]; 

            for(int i = 0; i <= 25; i++)
            {
                alphabet[i] = (char)(i + 97);
            }

            string input = File.ReadAllText("input.txt");

            List <string> outputLines = new List<string>();

            for(int i = 0; i < input.Length; i++)
            {
                for(int y = 0; y <= 25; y++)
                {
                    if(input[i] == alphabet[y])
                    {
                        string output = input[i] + " -> " + y;
                        outputLines.Add(output);
                        break;
                    }
                }
                
            }

            File.WriteAllLines("output.txt", outputLines);

        }
    }
}
