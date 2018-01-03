using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO2
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }

      //public Student(string name, int age, int id)
      //{
      //    this.name = name;
      //    this.age = age;
      //    this.id = id;
      //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student { Name = "Clint", Age = 23, Id = 1222 };
            //Student s = new Student("Gosho", 25, 123);
            //Student s = new Student();
            //s.name = "Clint Eastwood";
            //s.age = 89;
            Console.WriteLine(s.Name);
            Console.WriteLine(s.Age);
            Console.WriteLine(s.Id);
        }
    }
}
