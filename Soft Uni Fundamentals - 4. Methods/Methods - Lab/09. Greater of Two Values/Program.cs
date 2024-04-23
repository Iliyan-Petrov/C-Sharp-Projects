using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

class Greater
{
    static void Main()
    {
        string type = Console.ReadLine();
        string val1 = Console.ReadLine();
        string val2 = Console.ReadLine();

        string result = GetMax(type,val1,val2);
        Console.WriteLine(result);
    }

    static string GetMax(string type, string value1, string value2)
    {
        if (type == "int")
        {
            int int1 = int.Parse(value1);
            int int2 = int.Parse(value2);
            int max = GetMax(int1, int2);
            return max.ToString();
        }
        else if (type == "char")
        {
            char char1 = char.Parse(value1);
            char char2 = char.Parse(value2);
            char max = GetMax(char1, char2);
            return max.ToString();
        }
        else if (type == "string")
        {
            return GetMax(value1, value2);
        }
        else
        {
            return "Invalid type";
        }
    }

    static int GetMax(int a, int b)
    { return Math.Max(a, b); }

    static char GetMax(char a, char b)
    { return a > b ? a : b; }

    static string GetMax(string a, string b)
    {
        return string.Compare(a, b) > 0 ? a : b;
    }

}