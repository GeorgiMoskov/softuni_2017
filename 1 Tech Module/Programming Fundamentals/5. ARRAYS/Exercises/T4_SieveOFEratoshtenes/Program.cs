using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_SieveOFEratoshtenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = n + 1;
            bool[] arr = new bool[n];

            for(int i = 0; i < n; i++)
            {
                arr[i] = true;
            }

            arr[0] = false;
            arr[1] = false;

            for(int i = 0; i < n; i++)
            {
                if (arr[i] == true)
                {
                    for(int y = i+i;y< n; y=y+i)
                    {
                        arr[y] = false;
                    }
                }
            }

            for(int i = 0; i < n; i++)
            {
                if(arr[i] == true)
                {
                    Console.Write("{0} ",i);
                }
            }
        }
    }
}
