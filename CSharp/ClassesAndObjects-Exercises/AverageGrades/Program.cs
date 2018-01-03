using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AvGrade
        {
            get
            {
                double grade = 0;
                for (int i = 0; i < Grades.Count; i++)
                {
                    grade += Grades[i];
                }
                return grade / Grades.Count;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                List<double> grades = new List<double>();
                string[] studentData = Console.ReadLine().Split().ToArray();
                for (int j = 1; j < studentData.Length; j++)
                {
                    grades.Add(double.Parse(studentData[j]));
                }
                students.Add(new Student { Name = studentData[0], Grades = grades });
            }
            students = students.OrderByDescending(x => x.Name).ThenBy(x => x.AvGrade).ToList();
            for (int i = students.Count - 1; i >= 0; i--)
            {
                if (students[i].AvGrade >= 5)
                {
                    Console.WriteLine("{0} -> {1:F2}", students[i].Name, students[i].AvGrade);
                }
            }
        }
    }
}
