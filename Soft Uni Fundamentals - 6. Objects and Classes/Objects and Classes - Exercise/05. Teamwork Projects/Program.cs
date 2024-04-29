using System;
using System.Collections.Generic;
using System.Linq;

class TeamworkProjects
{
    static void Main()
    {
Dictionary<string, List<string>> teams = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
Dictionary<string, string> teamCreators = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        int numberOfTeams = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfTeams; i++)
        {
            string[] input = Console.ReadLine().Split('-');
            string teamName = input[1];
            string creator = input[0];

            if (teams.ContainsKey(teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
                continue;
            }

            if (teamCreators.ContainsKey(creator))
            {
                Console.WriteLine($"{creator} cannot create another team!");
                continue;
            }

            teams.Add(teamName, new List<string> { creator });
            teamCreators.Add(creator, teamName);
            Console.WriteLine($"Team {teamName} has been created by {creator}!");
        }

        string joinRequest;
        while ((joinRequest = Console.ReadLine()) != "end of assignment")
        {
            string[] input = joinRequest.Split("->");
            string user = input[0];
            string teamName = input[1];

            if (!teams.ContainsKey(teamName))
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                continue;
            }

            if (teams.Any(t => t.Value.Contains(user)) || teamCreators.ContainsKey(user))
            {
                Console.WriteLine($"Member {user} cannot join team {teamName}!");
                continue;
            }

            teams[teamName].Add(user);
        }

        var validTeams = teams
            .Where(t => t.Value.Count > 1)
            .OrderByDescending(t => t.Value.Count)
            .ThenBy(t => t.Key)
            .ToDictionary(t => t.Key, t => t.Value);

        var teamsToDisband = teams
            .Where(t => t.Value.Count == 1)
            .OrderBy(t => t.Key)
            .ToDictionary(t => t.Key, t => t.Value);

        foreach (var team in validTeams)
        {
            Console.WriteLine(team.Key);
            Console.WriteLine($"- {team.Value[0]}");
            foreach (var member in team.Value.Skip(1).OrderBy(m => m))
            {
                Console.WriteLine($"-- {member}");
            }
        }

        Console.WriteLine("Teams to disband:");
        foreach (var team in teamsToDisband)
        {
            Console.WriteLine(team.Key);
        }
    }
}
