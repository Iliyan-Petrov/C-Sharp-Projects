using System;

class Train
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] passengers = new int[n];
        int total = 0;

        for (int i = 0; i < n; i++)
        {
            passengers[i] = int.Parse(Console.ReadLine());
            total += passengers[i];
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(passengers[i] + " ");
        }

        Console.WriteLine("\n" + total);
    }   
}