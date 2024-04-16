using System;

class Town_Info
{
    static void Main()
    {
        string town_name = Console.ReadLine();
        string population = Console.ReadLine();
        string area = Console.ReadLine();

        Console.Write($"Town {town_name} has population of {population} and area {area} square km.");
    }

}
