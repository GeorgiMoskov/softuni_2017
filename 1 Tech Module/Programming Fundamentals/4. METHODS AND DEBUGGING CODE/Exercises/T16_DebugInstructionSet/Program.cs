using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T16_DebugInstructionSet
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = 0;
            while (true)
            {
                string opCode = Console.ReadLine();
                string[] codeArgs = opCode.Split(' ');
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne +1;
                            Console.WriteLine(result);
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne -1;
                            Console.WriteLine(result);
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            Console.WriteLine(result);
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne * operandTwo;
                            Console.WriteLine(result);
                            break;
                        }
                    case "END":
                        return;
                }

            }

        }
    }
}
