using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T18_SequenceOfCommands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string[] line = Console.ReadLine().Split(ArgumentsDelimiter);
            string command = line[0];

            while (!command.Equals("stop"))
            {
                //string line = Console.ReadLine().Trim();
                int[] args = new int[2];

                if (command.Equals("add") ||
                    command.Equals("subtract") ||
                    command.Equals("multiply"))
                {
                    args[0] = int.Parse(line[1]);
                    args[1] = int.Parse(line[2]);

                    PerformAction(array, command, args);
                }
                else
                {
                    PerformAction(array, command, args);
                }

                PrintArray(array);
                Console.WriteLine();

                line = Console.ReadLine().Split(ArgumentsDelimiter);
                command = line[0];
            }
        }

        static void PerformAction(long[] array, string action, int[] args)
        {
            //long[] array = (long[])arr.Clone();
            int pos = args[0] -1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long[] arrayClone = (long[])array.Clone();

            for (int i = 0; i < array.Length; i++)
            {
                array[(i + 1) % array.Length] = arrayClone[i];
            }
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long[] arrayClone = (long[])array.Clone();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = arrayClone[(i + 1) % array.Length];
            }
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
