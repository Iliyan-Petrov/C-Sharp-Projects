using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class ListManipulationBasics
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split()
        .Select(int.Parse)
        .ToList();

        while(true)
        {
            string line = Console.ReadLine();
            if (line == "end")
            { break; }

            string[] tokens = line.Split();

            switch (tokens[0])
            {
                case "Add":
                int numberToAdd = int.Parse(tokens[1]);
                nums.Add(numberToAdd);
                break;

                case "Remove":
                int numberToremove = int.Parse(tokens[1]);
                nums.Remove(numberToremove);
                break;

                case "RemoveAt":
                int indexToRemove = int.Parse(tokens[1]);
                nums.RemoveAt(indexToRemove);
                break;

                case "Insert":
                int numberToInsert = int.Parse(tokens[1]);
                int indexToInsert = int.Parse(tokens[2]);
                nums.Insert(indexToInsert, numberToInsert);
                break;
            }
        }

        Console.WriteLine(string.Join(" ", nums));
    }
}
