using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string[] namesAndEmails = File.ReadAllLines("D:\\Programing\\Tech Module\\CSharp\\FilesAndExeptions-Exercises\\FixEmails\\input.txt");
            string name = namesAndEmails[0];
            int index = 0;
            string email = "";
            while (name != "stop")
            {
                email = namesAndEmails[index+1];
                string emailToLower = email.ToLower();
                if (!emailToLower.EndsWith("us") && !emailToLower.EndsWith("uk"))
                {
                    emails.Add(name, email);
                }
                name = namesAndEmails[index+2];
                index += 2;
            }
            string[] output = new string[emails.Count];
            int indexer = 0;
            foreach (var pair in emails)
            {
                output[indexer] = $"{pair.Key} -> {pair.Value}";
                indexer++;
            }
            File.WriteAllLines("D:\\Programing\\Tech Module\\CSharp\\FilesAndExeptions-Exercises\\FixEmails\\output.txt", output);
        }
    }
}
