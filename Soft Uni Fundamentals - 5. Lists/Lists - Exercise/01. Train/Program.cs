using System;
using System.Collections.Generic;
using System.Linq;

class Train
{
    static void Main()
    {
       List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
       int maxCapacity = int.Parse(Console.ReadLine());

       string command;
       while((command = Console.ReadLine()) != "end")
       {
        if(command.StartsWith("Add"))
        {
            int passengersToAdd = int.Parse(command.Split()[1]);
            wagons.Add(passengersToAdd);
        }
        else
        {
            int passengersToBoard = int.Parse(command);
            for(int i = 0; i < wagons.Count; i++)
            {
                if(wagons[i] + passengersToBoard <= maxCapacity)
                { wagons[i] += passengersToBoard; break; }
            }
        }
       }
       Console.WriteLine(string.Join(" ", wagons));
    }
}
