using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        string command = Console.ReadLine();

        while (command != "End")
        {
            string[] cmdArgs = command.Split();
            string action = cmdArgs[0];

            if (action == "Add")
            {
                int numberToAdd = int.Parse(cmdArgs[1]);
                numbers.Add(numberToAdd);
            }
            else if (action == "Insert")
            {
                int numberToInsert = int.Parse(cmdArgs[1]);
                int index = int.Parse(cmdArgs[2]);

                if (IsValidIndex(index, numbers.Count))
                {
                    numbers.Insert(index, numberToInsert);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
            else if (action == "Remove")
            {
                int index = int.Parse(cmdArgs[1]);

                if (IsValidIndex(index, numbers.Count))
                {
                    numbers.RemoveAt(index);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
            else if (action == "Shift")
            {
                int count = int.Parse(cmdArgs[2]);

                if (cmdArgs[1] == "left")
                {
                    for (int i = 0; i < count; i++)
                    {
                        int firstElement = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(firstElement);
                    }
                }
                else if (cmdArgs[1] == "right")
                {
                    for (int i = 0; i < count; i++)
                    {
                        int lastElement = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, lastElement);
                    }
                }
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }

    static bool IsValidIndex(int index, int count)
    {
        return index >= 0 && index < count;
    }
}
