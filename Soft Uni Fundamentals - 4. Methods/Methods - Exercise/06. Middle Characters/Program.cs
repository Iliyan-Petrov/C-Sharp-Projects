using System;
using System.Reflection.Metadata.Ecma335;

class Middle
{
    static void Main()
    {
        string str = Console.ReadLine();
        PrintMiddleCharacter(str);
    }

    static void PrintMiddleCharacter(string str)
    {
        int length = str.Length;

        
        if (length % 2 == 0)
        {
            int middle1 = length / 2 - 1;
            int middle2 = middle1 + 1;

            Console.WriteLine($"{str[middle1]}{str[middle2]}");
        }
        else
        {
            int middle = length / 2;

            Console.WriteLine($"{str[middle]}");
        }
    }
}