using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T14_MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var badLetter = char.Parse(Console.ReadLine());

            var startCount = Math.Min((int)firstLetter, (int)secondLetter);
            var endCount = Math.Max((int)firstLetter, (int)secondLetter);
            var str = "";


            for(var i = startCount; i <= endCount; i++)
            {
                for (var y = startCount; y <= endCount; y++)
                {
                    for (var z = startCount; z <= endCount; z++)
                    {
                        str = ((char)i).ToString() + (char)y + (char)z;

                        if (str.Contains(badLetter.ToString()) == false)
                        {
                            Console.Write(str+" ");
                        }
                    }
                }
            }
        }
    }
}
