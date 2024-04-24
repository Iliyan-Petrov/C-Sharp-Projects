using System;
using System.Collections.Generic;
using System.Linq;

class GaussTrick
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split()
        .Select(int.Parse)
        .ToList();

        int originalLength = numbers.Count;
        for (int i = 0; i < originalLength/2; i++)
        {
            numbers[i] += numbers[numbers.Count - 1];
            numbers.RemoveAt(numbers.Count - 1);
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}