using System;
using System.Collections.Generic;
using System.Linq;

class PlantDiscovery
{
   static void Main()
   {
       int n = int.Parse(Console.ReadLine());
       Dictionary<string, int> plants = new Dictionary<string, int>();
       for (int i = 0; i < n; i++)
       {
           string[] input = Console.ReadLine().Split(new string[] { "<->" }, StringSplitOptions.None);
           string plant = input[0];
           int rarity = int.Parse(input[1]);
           plants[plant] = rarity;
       }

       Dictionary<string, List<int>> ratings = new Dictionary<string, List<int>>();
       string command = Console.ReadLine();
       while (command != "Exhibition")
       {
           string[] commandParts = command.Split(':');
           string action = commandParts[0];
           string[] actionParts = commandParts[1].Split('-');
           string plant = actionParts[0].Trim();
           if (!plants.ContainsKey(plant))
           {
               Console.WriteLine("error");
           }
           else
           {
               switch (action)
               {
                  case "Rate":
                      int rating = int.Parse(actionParts[1].Trim());
                      if (!ratings.ContainsKey(plant))
                      {
                          ratings[plant] = new List<int>();
                      }
                      ratings[plant].Add(rating);
                      break;
                  case "Update":
                      int newRarity = int.Parse(actionParts[1].Trim());
                      plants[plant] = newRarity;
                      break;
                  case "Reset":
                      if (ratings.ContainsKey(plant))
                      {
                          ratings[plant].Clear();
                      }
                      break;
               }
           }
           command = Console.ReadLine();
       }

       Console.WriteLine("Plants for the exhibition:");
       foreach (KeyValuePair<string, int> plant in plants)
       {
        double averageRating = 0;
        if (ratings.ContainsKey(plant.Key))
        { averageRating = ratings[plant.Key].DefaultIfEmpty(0).Average(); }
        Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value}; Rating: {averageRating:F2}");
        }
   }
}
