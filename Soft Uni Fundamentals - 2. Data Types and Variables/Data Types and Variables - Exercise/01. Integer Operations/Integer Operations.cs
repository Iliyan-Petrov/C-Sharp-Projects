﻿using System;

class Integer_Operations
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int num4 = int.Parse(Console.ReadLine());

        int add = num1 + num2;
        int divide = add/num3;
        int multiply = divide * num4;

        Console.WriteLine(multiply);
    }
}