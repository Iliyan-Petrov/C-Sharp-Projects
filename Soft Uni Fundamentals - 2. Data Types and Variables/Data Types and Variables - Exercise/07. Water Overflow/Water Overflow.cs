using System;

class Water_Overflow
{
    static void Main()
    {
        int tankCapacity = 255;
        int n = int.Parse(Console.ReadLine());
        int currentLiters = 0;

        for (int i = 0; i < n; i++)
        {
            int litersToAdd = int.Parse(Console.ReadLine());
            if (currentLiters + litersToAdd > tankCapacity)
            {Console.WriteLine("Insufficient capacity!");}
            else
            {currentLiters += litersToAdd;}
        }
        Console.WriteLine(currentLiters);
    }
}
