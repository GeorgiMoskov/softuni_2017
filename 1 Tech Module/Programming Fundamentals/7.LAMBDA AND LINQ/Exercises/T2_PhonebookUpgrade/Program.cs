using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> Phonebook = new SortedDictionary<string, string>();

            string[] Input = Console.ReadLine().Split();

            while (true)
            {

                if (Input[0] == "A")
                {
                    Phonebook[Input[1]] = Input[2];
                }
                else if (Input[0] == "S")
                {
                    if (Phonebook.ContainsKey(Input[1]))
                    {
                        Console.WriteLine("{0} -> {1}", Input[1], Phonebook[Input[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", Input[1]);
                    }
                }
                else if (Input[0] == "ListAll")
                {
                    foreach (var item in Phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", item.Key,item.Value);
                    }
                }
                else
                {
                    break;
                }

                Input = Console.ReadLine().Split();
            }
        }
    }
}
