using System;
using System.Linq;

class AppendArrays
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arrayStrings = input.Split('|');
        int[] resultArray = new int[0];
        for (int i = arrayStrings.Length - 1; i >= 0; i--)
        {
            string arrayString = arrayStrings[i].Trim();
            if (!string.IsNullOrWhiteSpace(arrayString))
            {
                int[] numbers = arrayString.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToArray();
                resultArray = resultArray.Concat(numbers).ToArray();
            }
        }
        Console.WriteLine(string.Join(" ", resultArray));
    }
}
