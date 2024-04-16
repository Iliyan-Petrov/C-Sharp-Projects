using System;

class Sum_Of_Chars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int totalSum = 0;

        for (int i = 0; i < n; i++)
        {
            char character = char.Parse(Console.ReadLine());
            totalSum += (int)character;
        }

        Console.WriteLine($"The sum equals: {totalSum}");
    }
}