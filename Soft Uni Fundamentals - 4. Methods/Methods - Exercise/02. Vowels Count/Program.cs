using System;
using System.Reflection.Metadata.Ecma335;

class Vowels
{
    static void Main()
    {
        string input = Console.ReadLine();

        int vowels = CountVowels(input);
        Console.WriteLine(vowels);
    }

    static int CountVowels(string input)
    {
        int count = 0;

        foreach (char c in input.ToLower())
        {
            if("aeiou".Contains(c)){count++;}
        }
    
    return count;
    }
}