using System;
using System.Linq;

class Numbers
{
   static void Main()
   {
       string[] input = Console.ReadLine().Split(' ');
       int[] numbers = Array.ConvertAll(input, int.Parse);
       double average = numbers.Average();
       var greaterNumbers = numbers.Where(n => n > average);
       var sortedNumbers = greaterNumbers.OrderByDescending(n => n);

       if (sortedNumbers.Any())
       { Console.WriteLine(string.Join(" ", sortedNumbers.Take(5))); }
       else
       { Console.WriteLine("No"); }
   }
}
