using System;

class Pounds_to_Dollars
{
    static void Main()
    {
        double GBP = double.Parse(Console.ReadLine());
        double USD = GBP*1.31;
        Console.WriteLine($"{USD:F3}");
    }
}
