using System;
using System.Linq;
using System.Text.RegularExpressions;

class DestinationMapper
{
  static void Main()
  {
      string input = Console.ReadLine();
      string pattern = @"(=|/)([A-Z][a-zA-Z]{2,})(\1)";

      MatchCollection matches = Regex.Matches(input, pattern);
      int travelPoints = matches.Cast<Match>().Sum(m => m.Length - 2);

      Console.WriteLine($"Destinations: {string.Join(", ", matches.Cast<Match>().Select(m => m.Value.Substring(1, m.Length - 2)))}");
      Console.WriteLine($"Travel Points: {travelPoints}");
  }
}
