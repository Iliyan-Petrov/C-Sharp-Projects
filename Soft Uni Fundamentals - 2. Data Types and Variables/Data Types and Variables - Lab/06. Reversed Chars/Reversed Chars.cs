using System;

class Reversed_Chars
{
    static string[] ReverseLines(string[] lines)
    {
        string[] reversedLines = new string[3];
        for (int i = 0; i < 3; i++)
        {reversedLines[i] = lines[2 - i];}
        return reversedLines;
    }
    static void Main()
    {
        string[] lines = new string[3];
        for (int i = 0; i < 3; i++)
        {lines[i] = Console.ReadLine();}
        Console.WriteLine(string.Join(" ", ReverseLines(lines)));
    }

}
