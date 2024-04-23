using System;
using System.Linq;
using System.Collections.Generic;

class TopNumber
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

        string commands;
        while((commands = Console.ReadLine()) != "end")
        {
            string[] arguements = commands.Split();

            switch (arguements[0])
            {
                case "exchange":
                int index = int.Parse(arguements[1]);
                numbers = Exchange(numbers, index);
                break;

                case "max":
                string maxType = arguements[1];
                PrintMaxNumber(numbers, maxType);
                break;

                case "min":
                string minType = arguements[1];
                PrintMinNumber(numbers, minType);
                break;

                case "first":
                int FirstLength = int.Parse(arguements[1]);
                string firstType = arguements[2];
                PrintFirstElements(numbers, FirstLength, firstType);
                break;

                case "last":
                int LastLength = int.Parse(arguements[1]);
                string lastType = arguements[2];
                PrintLastElements(numbers, LastLength, lastType);
                break;
            }
        }

        Console.WriteLine($"[{string.Join(", ", numbers)}]");
    }

    static int[] Exchange(int[] numbers, int index)
    {
        if (CheckForOutOfBounds(numbers, index))
        {
            Console.WriteLine("Invalid index");
            return numbers;
        }
        else
        {
            int[] changedArray = new int[numbers.Length];
            int changedArrayIndex = 0;
            for (int i = index + 1; i< numbers.Length; i++)
            { 
                changedArray[changedArrayIndex] = numbers[i]; 
                changedArrayIndex++;
            }

            for (int i = 0; i<= index; i++)
            { 
                changedArray[changedArrayIndex] = numbers[i]; 
                changedArrayIndex++;
            }

            numbers = changedArray;
            return numbers;
        }
    }

    static void PrintMaxNumber(int[] numbers, string type)
    {
        int maxIndex = -1;
        int maxNumber = int.MinValue;

        for(int i = 0; i < numbers.Length; i++)
        {
            if ((type == "odd" && numbers[i] % 2 != 0) || 
            (type == "even" && numbers[i] % 2 == 0))
            {
                if(numbers[i] >= maxNumber)
                {
                    maxNumber = numbers[i];
                    maxIndex = i;
                }
            }
        }

        PrintIndex(maxIndex);
    }

    static void PrintMinNumber(int[] numbers, string type)
    {
        int minIndex = -1;
        int minNumber = int.MaxValue;

        for(int i = 0; i < numbers.Length; i++)
        {
            if ((type == "odd" && numbers[i] % 2 != 0) || 
            (type == "even" && numbers[i] % 2 == 0))
            {
                if(numbers[i] <= minNumber)
                {
                    minNumber = numbers[i];
                    minIndex = i;
                }
            }
        }

        PrintIndex(minIndex);
    }

    static void PrintFirstElements(int[] numbers, int length, string type)
    {
        if (length > numbers.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }
        string firstElements = "";
        int elementCount=0;
        for (int i = 0; i< numbers.Length;i++)
        {
            if ((type == "odd" && numbers[i] % 2 != 0) || 
            (type == "even" && numbers[i] % 2 == 0))
            {
                firstElements += $"{numbers[i]}, ";
                elementCount++;
                if(elementCount >=length) {break;}
            }
        }
        if(firstElements == "")
        {
            Console.WriteLine("[]");
        }
        else
        {
            Console.WriteLine($"[{firstElements.Trim(' ', ',')}]");
        }
    }

    static void PrintLastElements(int[] numbers, int length, string type)
    {
        if (length > numbers.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }
        List<int> lastElementsList = new List<int>();
        int elementCount=0;
        for (int i = numbers.Length -1; i >= 0;i--)
        {
            if ((type == "odd" && numbers[i] % 2 != 0) || 
            (type == "even" && numbers[i] % 2 == 0))
            {
                lastElementsList.Add(numbers[i]);
                elementCount++;
                if(elementCount >=length) {break;}
            }
        }
        lastElementsList.Reverse();
        if(lastElementsList.Count == 0)
        {
            Console.WriteLine("[]");
        }
        else
        {
            Console.WriteLine($"[{string.Join(", ", lastElementsList)}]");
        }
    }

    static bool CheckForOutOfBounds(int[] numbers, int index)
    {
        return index < 0 || index >= numbers.Length;
    }

    static void PrintIndex(int index)
    {
       if(index == -1)
        {Console.WriteLine("No matches");}
        else
        {Console.WriteLine(index);}
    }
}
