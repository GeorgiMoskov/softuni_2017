using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrome(i) && IsumOfDigitsDividableBySeven(i) && IsContainsEvenDigits(i))
                {
                    Console.WriteLine(i);
                }
            }

        }

        static bool IsPalindrome(int num)
        {
            string numStr = num.ToString();
            int numStrLen = numStr.Length;
            int endLoop = numStrLen / 2;

            for (int i = 0; i <= endLoop; i++)
            {
                if (numStr[i] == numStr[numStrLen - i - 1])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;


        }


        static bool IsumOfDigitsDividableBySeven(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static bool IsContainsEvenDigits(int num)
        {
            while (num > 0)
            {
                if ((num % 10) % 2 == 0)
                {
                    return true;
                }
                num = num / 10;
            }

            return false;
        }
    }



}
