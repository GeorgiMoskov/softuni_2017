using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List < int > numList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int startPos = 0;
            int length = 1;
            int maxStartPos = 0;
            int maxLength = 1;

            for(int i = 1; i < numList.Count; i++)
            {
                if(numList[startPos] == numList[i])
                {
                    length++;
                    if(length > maxLength)
                    {
                        maxLength = length;
                        maxStartPos = startPos;
                    }
                }
                else
                {
                    startPos = i;
                    length = 1;
                }
            }

            for(int i = 0; i < maxLength; i++)
            {
                Console.Write("{0} ", numList[i + maxStartPos]);
            }


        }
    }
}
