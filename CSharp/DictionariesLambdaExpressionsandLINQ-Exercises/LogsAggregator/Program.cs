using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> usersAndsessions = new SortedDictionary<string, SortedDictionary<string, int>>();
            SortedDictionary<string, int> users = new SortedDictionary<string, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] session = Console.ReadLine().Split().ToArray();
                string user = session[1];
                string ip = session[0];
                int timeSpent = int.Parse(session[2]);

                if (usersAndsessions.ContainsKey(user))
                {
                    if (usersAndsessions[user].ContainsKey(ip))
                    {
                        usersAndsessions[user][ip] += timeSpent;
                    }
                    else
                    {
                        usersAndsessions[user].Add(ip, timeSpent);
                    }
                }
                else
                {
                    usersAndsessions.Add(user, new SortedDictionary<string, int>());
                    usersAndsessions[user].Add(ip, timeSpent);
                }
            }

            foreach (var user in usersAndsessions)
            {
                int allTimeSpent = 0;
                foreach (var ipAndTime in user.Value)
                {
                    allTimeSpent += ipAndTime.Value;
                }
                users.Add(user.Key, allTimeSpent);
            }



            foreach (var user in users)
            {
                Console.Write("{0}: {1} ", user.Key, user.Value);
                StringBuilder sb = new StringBuilder();
                sb = sb.Append("[");
                foreach (var ip in usersAndsessions[user.Key])
                {
                    sb = sb.Append(ip.Key + ", ");
                }
                sb.Remove(sb.Length - 2, 2);
                sb = sb.Append("]");
                Console.Write(sb + "\r\n");
            }
        }
    }
}
