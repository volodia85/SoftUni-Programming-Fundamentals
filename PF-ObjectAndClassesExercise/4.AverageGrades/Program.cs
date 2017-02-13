using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _4.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int inp = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();
            for (int i = 0; i < inp; i++)
            {

                string[] input = Console.ReadLine().Split();
                string studentName = input[0];

                List<double> grades = new List<double>();
                for (int j = 1; j < input.Length; j++)
                {
                    double grade = double.Parse(input[j]);
                    grades.Add(grade);
                }
                Student student = new Student();
                student.Name = studentName;
                student.Grades = grades;

                students.Add(student);
            }

            foreach (Student student in students.Where(s => s.AverageGrades >= 5).OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrades))
            {
                Console.WriteLine("{0} -> {1:f2}", student.Name, student.AverageGrades);
            }
        }


    }
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrades
        {
            get { return Grades.Average(); }

        }
    }
}
