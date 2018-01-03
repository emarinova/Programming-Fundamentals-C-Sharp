using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            string[] input = File.ReadAllLines("D:\\Programing\\Tech Module\\CSharp\\FilesAndExeptions-Exercises\\AverageGrades\\input.txt");
            
            List<Student> students = new List<Student>();
            for (int i = 1; i < input.Length; i++)
            {
                List<double> grades = new List<double>();
                string[] studentData = input[i].Split().ToArray();
                for (int j = 1; j < studentData.Length; j++)
                {
                    grades.Add(double.Parse(studentData[j]));
                }
                students.Add(new Student { Name = studentData[0], Grades = grades });
            }
            students = students.OrderByDescending(x => x.Name).ThenBy(x => x.AvGrade).ToList();
            List<string> output = new List<string>();
            for (int i = students.Count - 1; i >= 0; i--)
            {
                if (students[i].AvGrade >= 5)
                {
                    output.Add($"{students[i].Name} -> {students[i].AvGrade:F2}");
                }

            }
            File.WriteAllLines("D:\\Programing\\Tech Module\\CSharp\\FilesAndExeptions-Exercises\\AverageGrades\\output.txt", output);
        }
    }
}
