using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10_TriangleofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for(int i = 1; i <=n; i++)
            {
                for(int y = 0; y < i; y++)
                {   
                    
                    Console.Write(i + " ");
                }
                Console.WriteLine();

            }

        }
    }
}
