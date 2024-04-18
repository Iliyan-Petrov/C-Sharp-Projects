using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        if (inputArray.Length % 4 != 0)
        {
            Console.WriteLine("Invalid input! The array length must be divisible by 4.");
            return;
        }

        int k = inputArray.Length / 4;
        int[] firstRow = inputArray.Take(k).Reverse().
        Concat(inputArray.Skip(3*k).Take(k).Reverse()).ToArray();
        int[] secondRow = inputArray.Skip(k).Take(2*k).ToArray();

        int[] result = new int[2*k];
        for (int i = 0; i < 2*k; i++)
        {
            result[i] = firstRow[i] + secondRow[i];
        }

        Console.WriteLine(string.Join(" ", result));
    }
}
