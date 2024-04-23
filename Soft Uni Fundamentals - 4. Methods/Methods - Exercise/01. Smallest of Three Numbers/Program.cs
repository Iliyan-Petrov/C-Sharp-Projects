using System;

class Smallest
{
    static void Main()
    {
        int smallest = FindSmallest(int.Parse(Console.ReadLine()),
        int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));

        Console.WriteLine(smallest);
    }

    static int FindSmallest(int a, int b, int c)
    {
        int smallest = a;
        if(b < smallest) {smallest = b;}
        if (c < smallest) {smallest = c;}

        return smallest;
    }
}