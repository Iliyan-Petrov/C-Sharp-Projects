using System;
using System.Linq;

class LadyBugs
{
    static void Main(string[] args)
    {
        int fieldSize = int.Parse(Console.ReadLine());
        int[] bugIndices = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int[] field = InitializeField(fieldSize, bugIndices);

        string command = Console.ReadLine();

        while (command != "end")
        {
            field = MoveBugs(field, command);
            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", field));
    }

    static int[] InitializeField(int size, int[] bugIndices)
    {
        int[] field = new int[size];
        
        foreach (int index in bugIndices)
        {
            if (index >= 0 && index < size)
            {
                field[index] = 1;
            }
        }

        return field;
    }

    static int[] MoveBugs(int[] field, string command)
    {
        string[] commands = command.Split();

        int bugIndex = int.Parse(commands[0]);
        string direction = commands[1];
        int flightLength = int.Parse(commands[2]);

        if (bugIndex >= 0 && bugIndex < field.Length && field[bugIndex] == 1)
        {
            field[bugIndex] = 0;

            int step = direction == "right" ? 1 : -1;
            int newPosition = bugIndex;

            while (true)
            {
                newPosition += step * flightLength;

                if (newPosition < 0 || newPosition >= field.Length)
                {
                    break;
                }

                if (field[newPosition] == 0)
                {
                    field[newPosition] = 1;
                    break;
                }
            }
        }

        return field;
    }
}
