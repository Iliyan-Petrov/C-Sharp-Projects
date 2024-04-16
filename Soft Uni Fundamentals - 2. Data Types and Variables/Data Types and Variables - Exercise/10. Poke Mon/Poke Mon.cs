using System;

class Poke_Mon
{
    static void Main()
    {
        int pokePower = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int exhaustionFactor = int.Parse(Console.ReadLine());

        double originalPokePower = pokePower;
        int targetsPoked = 0;

        while (pokePower >= distance)
        {
            pokePower -= distance;
            targetsPoked++;

            if (pokePower == 0.5*originalPokePower && exhaustionFactor != 0)
            {
                pokePower /= exhaustionFactor;
                if (pokePower < distance){break;}
            }
        }

        Console.WriteLine(pokePower);
        Console.WriteLine(targetsPoked);
    }
}
