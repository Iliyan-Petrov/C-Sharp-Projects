using System;

class Messaging
{
    static void Main()
    {
        string numbersInput = Console.ReadLine();
        string[] numbers = numbersInput.Split(' ');

        string text = Console.ReadLine();

        string output = GenerateOutput(numbers, text);
        Console.WriteLine(output);
    }

    static string GenerateOutput(string[] numbers, string text)
    {
        string output = "";
        int textLength = text.Length;

        foreach (string number in numbers)
        {
            int sum = CalculateSumOfDigits(number);
            int index = sum % textLength;

            char character = text[index];
            output += character;

            text = text.Remove(index, 1);
            textLength--;
        }

        return output;
    }

    static int CalculateSumOfDigits(string number)
    {
        int sum = 0;
        foreach (char digitChar in number)
        {
            int digit = digitChar - '0';
            sum += digit;
        }
        return sum;
    }
}
