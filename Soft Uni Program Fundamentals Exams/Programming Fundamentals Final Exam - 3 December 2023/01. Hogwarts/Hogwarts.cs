using System;

class Hogwarts
{
   static void Main()
   {
       string spell = Console.ReadLine();
       string command = Console.ReadLine();

       while (command != "Abracadabra")
       {
           string[] commandParts = command.Split(' ');
           string commandType = commandParts[0];

           switch (commandType)
           {
               case "Abjuration":
                  spell = spell.ToUpper();
                  Console.WriteLine(spell);
                  break;
               case "Necromancy":
                  spell = spell.ToLower();
                  Console.WriteLine(spell);
                  break;
               case "Illusion":
                  int index = int.Parse(commandParts[1]);
                  char newChar = char.Parse(commandParts[2]);
                  if (index >= 0 && index < spell.Length)
                  {
                      spell = spell.Remove(index, 1).Insert(index, newChar.ToString());
                      Console.WriteLine("Done!");
                  }
                  else
                  {
                      Console.WriteLine("The spell was too weak.");
                  }
                  break;
               case "Divination":
                  string firstSubstring = commandParts[1];
                  string secondSubstring = commandParts[2];
                  spell = spell.Replace(firstSubstring, secondSubstring);
                  Console.WriteLine(spell);
                  break;
               case "Alteration":
                  string substring = commandParts[1];
                  spell = spell.Replace(substring, "");
                  Console.WriteLine(spell);
                  break;
               default:
                  Console.WriteLine("The spell did not work!");
                  break;
           }

           command = Console.ReadLine();
       }
   }
}
