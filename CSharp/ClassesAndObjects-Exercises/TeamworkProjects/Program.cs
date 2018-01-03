using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkProjects
{
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
        public int Count { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> allTeams = new List<Team>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputTeam = Console.ReadLine().Split('-').ToArray();
                string creator = inputTeam[0];
                string team = inputTeam[1];
                if (allTeams.Any(x => x.Name == team))
                {
                    Console.WriteLine(" Team {0} was already created!", team);
                    continue;
                }
                else if (allTeams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine("{0} cannot create another team!", creator);
                    continue;
                }
                else
                {
                    Team temp = new Team();
                    temp.Name = team;
                    temp.Creator = creator;
                    allTeams.Add(temp);
                    Console.WriteLine("Team {0} has been created by {1}!", team, creator);
                }
            }

            for(int i = 0; i < allTeams.Count; i++)
            {
                allTeams[i].Members = new List<string>();
            }

            string[] input = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (input[0] != "end of assignment")
            {
                string member = input[0];
                string team = input[1];
                if (!allTeams.Any(x => x.Name == team))
                {
                    Console.WriteLine("Team {0} does not exist!", team);
                }
                else if (allTeams.Any(x => x.Members.Contains(member)) || allTeams.Any(x => x.Creator == member))
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", member, team);
                }
                else
                {
                    Team temp = allTeams.Where(x => x.Name == team).First();
                    temp.Members.Add(member);
                    
                }
                input = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            List<Team> teams = new List<Team>();
            List<Team> disband = new List<Team>();

            foreach (var team in allTeams)
            {
                if (team.Members.Count == 0)
                {
                    disband.Add(team);
                }
                else
                {
                    teams.Add(team);
                }
            }

            teams = teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();
            foreach (var team in teams)
            {
                team.Members = team.Members.OrderBy(x => x).ToList();
            }
            disband = disband.OrderBy(x => x.Name).ToList();

            foreach (var team in teams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- {0}", team.Creator);
                foreach (var member in team.Members)
                {
                    Console.WriteLine("-- {0}", member);
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in disband)
            {
                Console.WriteLine(team.Name);
            }

        }
    }
}
