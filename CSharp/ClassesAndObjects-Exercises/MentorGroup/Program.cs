using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MentorGroup
{
    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string[] info = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (info[0] != "end")
            {
                string name = info[0];
                if (!students.Any(x => x.Name == name))
                {
                    Student temp = new Student();
                    temp.Name = name;
                    List<DateTime> tempList = new List<DateTime>();
                    for (int i = 1; i < info.Length; i++)
                    {
                        tempList.Add(DateTime.ParseExact(info[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                    temp.Dates = tempList;
                    students.Add(temp);
                }
                else
                {
                    Student temp = students.Where(x => x.Name == name).First();

                    for (int i = 1; i < info.Length; i++)
                    {
                        temp.Dates.Add(DateTime.ParseExact(info[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                }
                info = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            }

            string[] comments = Console.ReadLine().Split('-').ToArray();
            while (comments[0] != "end of comments")
            {
                string name = comments[0];
                string comment = comments[1];
                if (students.Any(x => x.Name == name))
                {
                    Student student = students.Where(x => x.Name == name).First();
                    if (student.Comments == null)
                    {
                        List<string> temp = new List<string>();
                        temp.Add(comment);
                        student.Comments = temp;
                    }
                    else
                    {
                        student.Comments.Add(comment);
                    }
                }
                comments = Console.ReadLine().Split('-').ToArray();
            }
            students = students.OrderBy(x => x.Name).ToList();
            
            for (int i = 0; i < students.Count; i++)
            {
                students[i].Dates = students[i].Dates.OrderBy(x => x).ToList();
            }
            foreach (var student in students)
            {
                
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                if (student.Comments != null)
                {
                    foreach (var comment in student.Comments)
                    {
                        Console.WriteLine("-- {0}", comment);
                    }
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Dates)
                {
                    Console.WriteLine("-- {0}", date.ToString(@"dd\/MM\/yyyy"));
                }
            }
        }
    }
}