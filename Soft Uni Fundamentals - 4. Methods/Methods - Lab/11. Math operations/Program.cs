using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.XPath;

class Multiply
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        string @operator = Console.ReadLine();
        int num2 = int.Parse(Console.ReadLine());

        double result = Calculate(num1, @operator, num2);
        Console.WriteLine(result);
    }

    static double Calculate(int a, string @operator, int b)
    {
        double result = 0;

        switch(@operator)
        {
            case "+":
            result = a + b;
            break;

            case "-":
            result = a - b;
            break;

            case "*":
            result = a * b;
            break;

            case "/":
            result = a / b;
            break;
        }
        return result;
    }
}