using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

class CalculateRectangleArea
{
    static void Main()
    {
        double area = RectangleArea(double.Parse(Console.ReadLine()), 
        double.Parse(Console.ReadLine()));

        Console.WriteLine(area);
    }

    static double RectangleArea(double width, double height)
    {
        return width * height;
    }
}