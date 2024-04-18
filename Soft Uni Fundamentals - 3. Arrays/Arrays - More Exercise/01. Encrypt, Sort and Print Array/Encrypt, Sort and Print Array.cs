using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> encryptedNumbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            int encryptedValue = EncryptString(input);
            encryptedNumbers.Add(encryptedValue);
        }

        encryptedNumbers.Sort();

        foreach (int value in encryptedNumbers)
        {
            Console.WriteLine(value);
        }
    }

    static int EncryptString(string input)
    {
        int vowelSum = 0;
        int consonantSum = 0;

        foreach (char c in input)
        {
            if (IsVowel(c))
            {
                vowelSum += (int)c * input.Length;
            }
            else
            {
                consonantSum += (int)c / input.Length;
            }
        }

        return vowelSum + consonantSum;
    }

    static bool IsVowel(char c)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        return Array.IndexOf(vowels, c) != -1;
    }
}
