using System;

class Meters_To_Kilometers
{
    static void Main()
    {
        double meters = int.Parse(Console.ReadLine());
        double kilometers = meters/1000;
        Console.WriteLine($"{kilometers:F2}");
    }
}
