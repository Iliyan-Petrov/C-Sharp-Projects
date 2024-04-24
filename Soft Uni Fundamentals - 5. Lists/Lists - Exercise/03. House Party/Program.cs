using System;
using System.Collections.Generic;
using System.Linq;

class houseParty
{
    static void Main()
    {
       int commandsCount = int.Parse(Console.ReadLine());
       List<string> guests = new List<string>();

       for (int i = 0; i< commandsCount;i++)
       {
        string[] command = Console.ReadLine().Split();
        string name = command[0];

        if (command.Length == 3)
        {
            if (guests.Contains(name))
            { Console.WriteLine($"{name} is already in the list!"); }
            else
            { guests.Add(name); }
        }

        else if (command.Length == 4)
            {
                if (guests.Contains(name))
                { guests.Remove(name); }
                else
                { Console.WriteLine($"{name} is not in the list!"); }
            }
       }

       foreach (string guest in guests)
        { Console.WriteLine(guest); }
    }
}
