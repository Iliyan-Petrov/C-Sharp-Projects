using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
        static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> copiedNums = new List<int>(nums);

            List<int> evenNums = new List<int>();
            List<int> oddNums = new List<int>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                List<string> commands = input
                    .Split()
                    .ToList();

                string command = commands[0];

                List<int> filteredNumbers = new List<int>();

                if (command == "Add")
                {
                    int numberToAdd = int.Parse(commands[1]);
                    copiedNums.Add(numberToAdd);
                }
                else if (command == "Remove")
                {
                    int numberToRemove = int.Parse(commands[1]);
                    copiedNums.Remove(numberToRemove);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(commands[1]);
                    copiedNums.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    int numberToInsert = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    copiedNums.Insert(index, numberToInsert);
                }
                else if (command == "Contains")
                {
                    int containedNumber = int.Parse(commands[1]);

                    if (nums.Contains(containedNumber))
                    { Console.WriteLine("Yes"); }
                    else
                    { Console.WriteLine("No such number"); }
                }
                else if (command == "PrintEven")
                { PrintingEvenNumbers(nums, evenNums); }
                else if (command == "PrintOdd")
                { PrintingOddNumbers(nums, oddNums); }
                else if (command == "GetSum")
                { Console.WriteLine(nums.Sum()); }
                else if (command == "Filter")
                { FilterCommand(nums, commands, filteredNumbers); }

                input = Console.ReadLine();
            }

            ChangesCheck(nums, copiedNums);
        }

        private static void ChangesCheck(List<int> originalNumbers, List<int> copiedNumbers)
        {
            if (originalNumbers.Count == copiedNumbers.Count)
            {
                bool areEqual = false;

                for (int i = 0; i < originalNumbers.Count; i++)
                {
                    for (int j = i; j < copiedNumbers.Count; j++)
                    {
                        if (originalNumbers[i] == copiedNumbers[j])
                        { areEqual = true; }
                        else
                        { areEqual = false; }
                    }
                }

                if (!areEqual)
                { Console.WriteLine(string.Join(" ", copiedNumbers)); }
            }
            else
            { Console.WriteLine(string.Join(" ", copiedNumbers)); }
        }

        private static void FilterCommand(List<int> numbers, List<string> commands, List<int> filteredNumbers)
        {
            string condition = commands[1];

            int filterNumber = int.Parse(commands[2]);

            if (condition == "<")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < filterNumber)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }

                Console.WriteLine(string.Join(" ", filteredNumbers));
            }
            else if (condition == ">")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > filterNumber)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }

                Console.WriteLine(string.Join(" ", filteredNumbers));
            }
            else if (condition == ">=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] >= filterNumber)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }

                Console.WriteLine(string.Join(" ", filteredNumbers));
            }
            else if (condition == "<=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= filterNumber)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }

                Console.WriteLine(string.Join(" ", filteredNumbers));
            }
        }

        private static void PrintingOddNumbers(List<int> numbers, List<int> oddNumbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", oddNumbers));
        }

        private static void PrintingEvenNumbers(List<int> numbers, List<int> evenNumbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", evenNumbers));
        }
}
