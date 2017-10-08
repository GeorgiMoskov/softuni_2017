using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "Amanda";
            string lName = "Jonson";
            byte age = 27;
            char gender = 'f';
            long personId = 8306112507;
            uint uniqueEmployeeNum = 27563571;

            Console.WriteLine($"First name: {fName}");
            Console.WriteLine($"Last name: {lName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personId}");
            Console.WriteLine($"Unique Employee number: {uniqueEmployeeNum}");
        }
    }
}
