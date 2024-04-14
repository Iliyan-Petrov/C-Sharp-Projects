using System;
using System.Collections.Generic;
using System.Linq;

class Numbers
{
    static void Main()
    {
        List<int> sequence = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        string command = Console.ReadLine();

        while (command != "Finish")
        {
            string[] commandParts = command.Split(' ');

            switch (commandParts[0])
            {
                case "Add":
                    int valueToAdd = int.Parse(commandParts[1]);
                    sequence.Add(valueToAdd);
                    break;

                case "Remove":
                    int valueToRemove = int.Parse(commandParts[1]);
                    sequence.Remove(valueToRemove);
                    break;

                case "Replace":
                    int valueToReplace = int.Parse(commandParts[1]);
                    int replacement = int.Parse(commandParts[2]);
                    int indexToReplace = sequence.IndexOf(valueToReplace);
                    if (indexToReplace != -1)
                    { sequence[indexToReplace] = replacement; }
                    break;

                case "Collapse":
                    int valueToCollapse = int.Parse(commandParts[1]);
                    sequence = sequence.Where(x => x >= valueToCollapse).ToList();
                    break;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", sequence));
    }
}
