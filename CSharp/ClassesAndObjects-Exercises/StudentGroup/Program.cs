using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace StudentGroup
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public List<Student> students { get; set; }
    }

    class Group
    {
        public string Town { get; set; }
        public List<Student> Students { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = new List<Town>();
            string commandLine = Console.ReadLine();
            while (commandLine != "End")
            {
                if (commandLine.Contains("=>"))
                {
                    string[] commandLineString = commandLine.Split(new string[] {"=>", "seats" }, StringSplitOptions.RemoveEmptyEntries);
                    string townName = commandLineString[0];
                    int seats = int.Parse(commandLineString[1]);
                    Town temp = new Town();
                    temp.Name = townName;
                    temp.Seats = seats;
                    temp.students = new List<Student>();
                    towns.Add(temp);
                    commandLine = Console.ReadLine();
                    while (!commandLine.Contains("=>") && commandLine!="End")
                    {
                        string[] students = commandLine.Split('|').ToArray();
                        string studentName = students[0].Trim();
                        string studentEmail = students[1].Trim();
                        DateTime studentDate = DateTime.ParseExact(students[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);
                        temp.students.Add(new Student { Name = studentName, Email = studentEmail, RegistrationDate = studentDate });
                        commandLine = Console.ReadLine();
                    }
                }
            }

            List<Group> groups = DistributeStudentsIntoGroups(towns);

            Console.WriteLine("Created {0} groups in {1} towns:", groups.Count, towns.Count);
            foreach (var group in groups)
            {
                Console.Write("{0} => ", group.Town);
                StringBuilder sb = new StringBuilder();
                foreach (var student in group.Students)
                {
                    sb.Append($"{student.Email}, ");
                }
                sb.Remove(sb.Length - 2, 2);
                Console.WriteLine(sb);
            }

            //int groupCount = 1;
            //string town = groups[0].Town;
            //foreach (var group in groups)
            //{
            //    if (town != group.Town)
            //    {
            //        groupCount = 1;
            //        town = group.Town;
            //    }
            //    Town temp = towns.Where(x => x.Name == group.Town).First();
            //    Console.WriteLine($"{group.Town} (group {groupCount} - {group.Students.Count}/{temp.Seats} students)");
            //    foreach (var student in group.Students)
            //    {
            //        Console.WriteLine($"{student.Name} | {student.Email} | {student.RegistrationDate}");
            //    }
            //    groupCount++;
            //}
        }

        static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            towns = towns.OrderBy(x => x.Name).ToList();
            List<Group> groups = new List<Group>();
            foreach (var town in towns)
            {
                town.students = town.students.OrderBy(x => x.RegistrationDate).ThenBy(x => x.Name).ThenBy(x => x.Email).ToList();
                int index = 0;
                List<Student> temp = new List<Student>();
                while (index + town.Seats < town.students.Count)
                {
                    temp = new List<Student>();
                    for (int i = index; i < index + town.Seats; i++)
                    {
                        temp.Add(town.students[i]);
                    }
                    groups.Add(new Group { Town = town.Name, Students = temp });
                    index += town.Seats;
                }
                temp = new List<Student>();
                for (int i = index; i < town.students.Count; i++)
                {
                    temp.Add(town.students[i]);    
                }
                groups.Add(new Group { Town = town.Name, Students = temp });
            }
            return groups;
        }
    }
}
