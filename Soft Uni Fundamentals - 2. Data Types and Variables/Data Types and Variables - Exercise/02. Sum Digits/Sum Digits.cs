﻿using System;

class Sum_Digits
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        Console.WriteLine(sum);
    }
}