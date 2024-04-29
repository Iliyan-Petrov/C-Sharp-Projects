using System;
using System.Numerics;

class RandomizeWords
{
    static void Main()
    {
       int n = int.Parse(Console.ReadLine());
       BigInteger f = 1;
       for (int i = 2; i <= n; i++)
       { f *= i; }

       Console.WriteLine(f);
    }
}