using System;
using System.Reflection.Metadata.Ecma335;

class FactorialDiv
{
    static void Main()
    {
        double firstFact = Factorial(int.Parse(Console.ReadLine()));
        double secondFact = Factorial(int.Parse(Console.ReadLine()));
        double result = firstFact / secondFact;

        Console.WriteLine($"{result:f2}");
    }

    static double Factorial (int num)
    {
        double Fact=1;
        for (int i=1; i<= num; i++) { Fact *=i; }
        return Fact;
    }
}