using System;
using System.Collections.Generic;

class Program
{
   static void Main(string[] args)
   {
       Dictionary<string, Dictionary<string, string>> pieces = new Dictionary<string, Dictionary<string, string>>();
       int n = int.Parse(Console.ReadLine());
       for (int i = 0; i < n; i++)
       {
           string[] input = Console.ReadLine().Split('|');
           string piece = input[0];
           string composer = input[1];
           string key = input[2];
           pieces[piece] = new Dictionary<string, string> { { "composer", composer }, { "key", key } };
       }

       string command;
       while ((command = Console.ReadLine()) != "Stop")
       {
           string[] details = command.Split('|');
           string commandType = details[0];
           string piece = details[1];
           switch (commandType)
           {
               case "Add":
                  string composer = details[2];
                  string key = details[3];
                  if (pieces.ContainsKey(piece))
                  {
                      Console.WriteLine($"{piece} is already in the collection!");
                  }
                  else
                  {
                      pieces[piece] = new Dictionary<string, string> { { "composer", composer }, { "key", key } };
                      Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                  }
                  break;
               case "Remove":
                  if (pieces.ContainsKey(piece))
                  {
                      pieces.Remove(piece);
                      Console.WriteLine($"Successfully removed {piece}!");
                  }
                  else
                  {
                      Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                  }
                  break;
               case "ChangeKey":
                  string newKey = details[2];
                  if (pieces.ContainsKey(piece))
                  {
                      pieces[piece]["key"] = newKey;
                      Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                  }
                  else
                  {
                      Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                  }
                  break;
           }
       }

       foreach (var piece in pieces)
       {
           Console.WriteLine($"{piece.Key} -> Composer: {piece.Value["composer"]}, Key: {piece.Value["key"]}");
       }
   }
}
