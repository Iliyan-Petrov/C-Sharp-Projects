using System;
using System.Diagnostics.CodeAnalysis;

class Print_and_sum
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        
        int sum = 0;

        for (int i = startNum; i <= endNum; i++)
        {
            Console.Write(i + " ");
            sum += i;
        }

        Console.WriteLine("\nSum: " + sum);
    }
}
