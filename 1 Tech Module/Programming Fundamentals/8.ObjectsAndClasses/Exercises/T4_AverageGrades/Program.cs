using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_AverageGrades
{

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int entries = int.Parse(Console.ReadLine());

            for(int i = 0; i < entries; i++)
            {
                List<string> inputStr = Console.ReadLine().Split().ToList();
                string name = inputStr[0];
                inputStr.RemoveAt(0);
                List<double> grades = inputStr.Select(double.Parse).ToList();

                students.Add(new Student { Name = name, Grades = grades });


            }

            foreach (var student in students.OrderBy(x=> x.Name).ThenByDescending(y=>y.AverageGrade))
            {
                if(student.AverageGrade >= 5.00)
                {
                    Console.WriteLine("{0} -> {1:F2}", student.Name, student.AverageGrade);
                }
            }



        }
    }
}
