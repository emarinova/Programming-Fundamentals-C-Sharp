using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();
            //Dictionary<string, int> temp = new Dictionary<string, int>();
            while (input[0] != "end")
            {
                string name = input[2].Substring(5);
                string IP = input[0].Substring(3);
                
                if (users.ContainsKey(name))
                {
                    if (users[name].ContainsKey(IP))
                    {
                        users[name][IP] = users[name][IP] + 1;
                    }
                    else
                    {
                        users[name].Add(IP, 1);
                    }
                }
                else
                {
                    
                    //temp.Add(IP, 1);
                    users.Add(name, new Dictionary<string, int>());
                    users[name].Add(IP, 1);
                }
                input = Console.ReadLine().Split().ToArray();
            }
            foreach (var user in users)
            {
                Console.WriteLine(user.Key + ":");
                StringBuilder sb = new StringBuilder();
                foreach(var ip in user.Value)
                {
                    sb.Append(ip.Key + " => " + ip.Value + ", ");
                }

                sb.Remove(sb.Length - 2, 2);
                sb.Append(".");
                Console.WriteLine(sb);
            }
        }
    }
}
