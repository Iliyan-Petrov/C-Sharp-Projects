using System;
using System.Reflection.Metadata.Ecma335;

class Palindrome
{
    static void Main()
    {
        string input;
        while((input = Console.ReadLine()) != "END")
        {
            bool isNumPalindrome = IsPalindrome(input);
            Console.WriteLine(isNumPalindrome);
        }
    }

    static bool IsPalindrome(string symbols)
    {
        int left = 0;
        int right = symbols.Length - 1;

        while (left < right)
        {
            if (symbols[left] != symbols[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

}