using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());


            Console.WriteLine(NameofLastDigit(num));
        }

        static string NameofLastDigit(long num)
        {
            num = Math.Abs(num);
            num = num % 10;
            string strNum = "";
            switch (num)
            {
                case 0:
                    strNum = "zero";
                    break;
                case 1:
                    strNum = "one";
                    break;
                case 2:
                    strNum = "two";
                    break;
                case 3:
                    strNum = "three";
                    break;
                case 4:
                    strNum = "four";
                    break;
                case 5:
                    strNum = "five";
                    break;
                case 6:
                    strNum = "six";
                    break;
                case 7:
                    strNum = "seven";
                    break;
                case 8:
                    strNum = "eight";
                    break;
                case 9:
                    strNum = "nine";
                    break;
                default:
                    strNum = "ERROR";
                    break;
            }

            return strNum;
        }
    }
}
