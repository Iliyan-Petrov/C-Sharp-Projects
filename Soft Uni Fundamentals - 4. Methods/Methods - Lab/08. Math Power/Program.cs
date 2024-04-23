using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

class mathPower
{
    static void Main()
    {
        double result = MathPower(double.Parse(Console.ReadLine()),
        double.Parse(Console.ReadLine()));

        Console.WriteLine(result);
    }

    static double MathPower(double num, double pow)
    {
        return Math.Pow(num,pow);
    }
}