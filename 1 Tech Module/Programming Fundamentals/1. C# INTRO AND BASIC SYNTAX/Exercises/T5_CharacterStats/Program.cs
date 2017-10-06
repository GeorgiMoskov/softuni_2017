using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var curHp = int.Parse(Console.ReadLine());
            var maxHp = int.Parse(Console.ReadLine());
            var curEng = int.Parse(Console.ReadLine());
            var maxEng = int.Parse(Console.ReadLine());

            
            var dotsHp = new String('.', maxHp - curHp);
            var linesHp = new String('|', curHp);

            var dotsEng = new String('.', maxEng - curEng);
            var linesEng = new String('|', curEng);

            Console.WriteLine("Name: {0}",name);
            Console.WriteLine("Health: |{0}{1}|",linesHp,dotsHp);
            Console.WriteLine("Energy: |{0}{1}|", linesEng, dotsEng);

        }   
    }
}
