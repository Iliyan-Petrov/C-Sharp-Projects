using System;
using System.Numerics;

class Snowballs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger highestSnowballValue = int.MinValue;
        int bestSnowballSnow = 0;
        int bestSnowballTime = 0;
        int bestSnowballQuality = 0;

        for (int i = 0; i < n; i++)
        {
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());

            BigInteger currentSnowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

            if (currentSnowballValue > highestSnowballValue)
            {
                highestSnowballValue = currentSnowballValue;
                bestSnowballSnow = snowballSnow;
                bestSnowballTime = snowballTime;
                bestSnowballQuality = snowballQuality;
            }
        }

        Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {highestSnowballValue} ({bestSnowballQuality})");
    }
}
