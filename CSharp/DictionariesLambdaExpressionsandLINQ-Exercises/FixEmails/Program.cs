using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string name = Console.ReadLine();
            string email = "";
            while(name != "stop")
            {
                email = Console.ReadLine();
                string domain = email.Reverse().Take(2).ToString().ToLower();
                if (domain != "us" && domain != "uk")
                {
                    emails.Add(name, email);
                }
                name = Console.ReadLine();
            }

            //emails = emails.Where(pair => !pair.Value.EndsWith(".us") && !pair.Value.EndsWith(".uk")).ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (var pair in emails)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }

        
    }
}
