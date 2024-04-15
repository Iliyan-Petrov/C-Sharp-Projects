using System;

class English_Name_Of_The_Last_Digit
{
    static string GetLastDigitSpelling(int number)
    {
        string[] digitSpellings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        int lastDigit = Math.Abs(number) % 10;

        return digitSpellings[lastDigit];
    }


    static void Main()
    {
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            string lastDigitSpelling = GetLastDigitSpelling(number);
            Console.Write(lastDigitSpelling);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
