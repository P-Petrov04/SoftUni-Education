using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Team
    {
        public Team(string teamName, string creatorName)
        {
            this.TeamName = teamName;
            this.CreatorName = creatorName;

            this.Members = new List<string>();
        }
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> allTeams = new List<Team>();
            int countTeams = int.Parse(Console.ReadLine());
            for (int i = 0; i < countTeams; i++)
            {
                string[] teamArgs = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
                string creator = teamArgs[0];
                string teamName = teamArgs[1];

                if (allTeams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (allTeams.Any(t => t.CreatorName == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team newTeam = new Team(teamName, creator);
                    allTeams.Add(newTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                string[] userArgs = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string userName = userArgs[0];
                string teamName = userArgs[1];
                
                if (!allTeams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (allTeams.Any(t => t.Members.Contains(userName) || t.CreatorName == userName))
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                }
                else
                {
                    Team currTeam = allTeams.FirstOrDefault(t => t.TeamName == teamName);
                    currTeam.Members.Add(userName);
                }
                
                input = Console.ReadLine();
            }

            List<Team> teamsToDisband = allTeams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.TeamName)
                .ToList();
            List<Team> validTeams = allTeams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.TeamName)
                .ToList();

            foreach (Team team in validTeams)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.CreatorName}");
                team.Members.Sort();
                foreach (string member in team.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team team in teamsToDisband)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
}
