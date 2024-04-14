using System;
using System.Collections.Generic;

class Dictionary
{
   static void Main()
   {
       Dictionary<string, List<string>> notebook = new Dictionary<string, List<string>>();

       string[] wordPairs = Console.ReadLine().Split(" | ");
       foreach (string pair in wordPairs)
       {
           string[] wordAndDefinition = pair.Split(": ");
           string word = wordAndDefinition[0];
           string definition = wordAndDefinition[1];

           if (!notebook.ContainsKey(word))
           {
               notebook[word] = new List<string>();
           }

           notebook[word].Add(definition);
       }

       string[] testWords = Console.ReadLine().Split(" | ");
       string command = Console.ReadLine();

       if (command == "Test")
       {
           foreach (string word in testWords)
           {
               if (notebook.ContainsKey(word))
               {
                  Console.WriteLine(word + ":");
                  foreach (string definition in notebook[word])
                  {
                      Console.WriteLine(" -" + definition);
                  }
               }
           }
       }
       else if (command == "Hand Over")
       {
           foreach (string word in notebook.Keys)
           {
               Console.Write(word + " ");
           }
       }
   }
}
