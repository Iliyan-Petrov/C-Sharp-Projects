﻿using System;

class Sort_Numbers
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());

        double[] numbers = { num1, num2, num3 };

        Array.Sort(numbers);
        Array.Reverse(numbers);

        foreach (double number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
