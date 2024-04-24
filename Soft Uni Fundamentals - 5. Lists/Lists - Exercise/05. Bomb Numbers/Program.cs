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

        int[] bombInfo = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int bombNumber = bombInfo[0];
        int bombPower = bombInfo[1];

        while (numbers.Contains(bombNumber))
        {
            int bombIndex = numbers.IndexOf(bombNumber);
            int leftIndex = Math.Max(bombIndex - bombPower, 0);
            int rightIndex = Math.Min(bombIndex + bombPower, numbers.Count - 1);

            numbers.RemoveRange(leftIndex, rightIndex - leftIndex + 1);
        }

        int sum = numbers.Sum();
        Console.WriteLine(sum);
    }
}
