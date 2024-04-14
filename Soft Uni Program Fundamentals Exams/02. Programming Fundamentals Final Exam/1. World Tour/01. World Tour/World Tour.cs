using System;
using System.Text;

class WorldTour
{
  static void Main()
  {
      StringBuilder stops = new StringBuilder(Console.ReadLine());

      string command = Console.ReadLine();
      while (command != "Travel")
      {
          string[] commandParts = command.Split(':');
          string commandType = commandParts[0];

          switch (commandType)
          {
              case "Add Stop":
                int addIndex = int.Parse(commandParts[1]);
                string addString = commandParts[2];
                if (addIndex >= 0 && addIndex <= stops.Length)
                {
                    stops.Insert(addIndex, addString);
                }
                break;

              case "Remove Stop":
                int removeStartIndex = int.Parse(commandParts[1]);
                int removeEndIndex = int.Parse(commandParts[2]);
                if (removeStartIndex >= 0 && removeStartIndex <= stops.Length &&
                    removeEndIndex >= 0 && removeEndIndex <= stops.Length &&
                    removeStartIndex <= removeEndIndex)
                {
                    stops.Remove(removeStartIndex, removeEndIndex - removeStartIndex + 1);
                }
                break;

              case "Switch":
                string oldString = commandParts[1];
                string newString = commandParts[2];
                stops.Replace(oldString, newString);
                break;
          }

          Console.WriteLine(stops.ToString());
          command = Console.ReadLine();
      }

      Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
  }
}