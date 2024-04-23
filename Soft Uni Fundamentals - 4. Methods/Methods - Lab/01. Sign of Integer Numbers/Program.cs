using System;

class SignOfIntegerNumber
{
    static void Main()
    {
        SignInteger(int.Parse(Console.ReadLine()));
    }

    static void SignInteger(int number)
    {
        if (number > 0)
        {Console.WriteLine($"The number {number} is positive.");}
        else if(number < 0)
        {Console.WriteLine($"The number {number} is negative.");}
        else if(number == 0)
        {Console.WriteLine($"The number {number} is zero.");}
    }
}