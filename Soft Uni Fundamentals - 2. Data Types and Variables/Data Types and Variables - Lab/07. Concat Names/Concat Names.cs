using System;

class Concat_Names
{
    static void Main()
    {
        string name1 = Console.ReadLine();
        string name2 = Console.ReadLine();
        string delimiter = Console.ReadLine();

        Console.Write($"{name1}{delimiter}{name2}");
    }

}
