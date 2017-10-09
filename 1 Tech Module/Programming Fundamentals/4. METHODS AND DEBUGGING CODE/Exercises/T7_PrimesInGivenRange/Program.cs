using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7_PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            PrintListOfInts(FindPrimesInRange(startNum, endNum));
            



        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> listOfPrimeNums = new List<int>();

            var isPrimeCurrentNum = true;

            if (startNum < 2)
            {
                startNum = 2;
            }

            for (int i = startNum; i <= endNum; i++)
            {
                for (int y = 2; y <= Math.Sqrt(i); y++)
                {
                    isPrimeCurrentNum = true;

                    if (i % y == 0)
                    {
                        isPrimeCurrentNum = false;
                        break;
                    }

                }

                if (isPrimeCurrentNum == true)
                {
                    listOfPrimeNums.Add(i);
                }
            }

            return listOfPrimeNums;


        }

        static void PrintListOfInts(List<int> listOfInts)
        {
            if (listOfInts.Capacity >0)
            {
                for (int i = 0; i < listOfInts.Count - 1; i++)
                {
                    Console.Write(listOfInts.ElementAt(i) + ", ");
                }
                Console.WriteLine(listOfInts.ElementAt(listOfInts.Count-1));
            }
            else
            {
                Console.WriteLine("(empty list)"); 
            }
        }

    }
}
