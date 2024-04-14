using System;

class BiscuitFactory
{
    static void Main()
    {
        int biscuitsPerDay = int.Parse(Console.ReadLine());
        int workerCount = int.Parse(Console.ReadLine());
        int competingFactoryProduction = int.Parse(Console.ReadLine());

        int totalBiscuits = 0;

        for (int day = 1; day <= 30; day++)
        {
            int biscuitsProduced = biscuitsPerDay * workerCount;

            if (day % 3 == 0)
            { biscuitsProduced = (int)(biscuitsProduced * 0.75); }

            totalBiscuits += biscuitsProduced;
        }

        int difference = totalBiscuits - competingFactoryProduction;
        double percentage = (double)difference / competingFactoryProduction * 100;

        Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");

        if (difference > 0)
        { Console.WriteLine($"You produce {percentage:F2} percent more biscuits."); }
        else
        { Console.WriteLine($"You produce {Math.Abs(percentage):F2} percent less biscuits."); }
    }
}
