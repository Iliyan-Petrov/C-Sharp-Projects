using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

class repeatString
{
    static void Main()
    {
        string String = RepeatString(Console.ReadLine(),
        int.Parse(Console.ReadLine()));

        Console.WriteLine(String);
    }

    static string RepeatString(string str, int count)
    {
        string result = "";

        for (int i = 0; i < count; i++)
        {result += str;}
        return result;
    }
}