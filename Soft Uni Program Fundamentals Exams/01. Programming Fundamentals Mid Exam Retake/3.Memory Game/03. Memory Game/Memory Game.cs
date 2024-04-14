using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> sequence = new List<string>(Console.ReadLine().Split());
        int moves = 0;

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end")
            {
                break;
            }

            string[] indexes = input.Split();
            int index1 = int.Parse(indexes[0]);
            int index2 = int.Parse(indexes[1]);

            if (index1 < 0 || index1 >= sequence.Count || index2 < 0 || index2 >= sequence.Count || index1 == index2)
            {
                sequence.Insert(sequence.Count / 2, $"-{moves + 1}a");
                sequence.Insert(sequence.Count / 2, $"-{moves + 1}a");
                Console.WriteLine("Invalid input! Adding additional elements to the board");
            }
            else
            {
                if (sequence[index1] == sequence[index2])
                {
                    string element = sequence[index1];
                    sequence.RemoveAt(Math.Max(index1, index2));
                    sequence.RemoveAt(Math.Min(index1, index2));
                    moves++;
                    Console.WriteLine($"Congrats! You have found matching elements - {element}!");
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }

            if (sequence.Count == 0)
            {
                Console.WriteLine($"You have won in {moves} turns!");
                break;
            }
        }

        if (sequence.Count > 0)
        {
            Console.WriteLine($"Sorry you lose :(\n{string.Join(" ", sequence)}");
        }
    }
}
