using System;

class carRace
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        int[] numbers = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        int middleIndex = numbers.Length / 2;

        double leftTotalTime = 0;
        double rightTotalTime = 0;

        for (int i = 0; i < middleIndex; i++)
        {
            leftTotalTime += numbers[i];
            if (numbers[i] == 0)
            {
                leftTotalTime *= 0.8;
            }
        }

        for (int i = numbers.Length - 1; i > middleIndex; i--)
        {
            rightTotalTime += numbers[i];
            if (numbers[i] == 0)
            {
                rightTotalTime *= 0.8;
            }
        }

        string winner;
        double totalTime;

        if (leftTotalTime < rightTotalTime)
        {
            winner = "left";
            totalTime = leftTotalTime;
        }
        else
        {
            winner = "right";
            totalTime = rightTotalTime;
        }

        Console.WriteLine($"The winner is {winner} with total time: {Math.Round(totalTime,1)}");
    }
}
