using System;

class SpecialNumbers
{
    static void Main()
    {
        int kolkko = int.Parse(Console.ReadLine());

        for (int ch = 1; ch <= kolkko; ch++)
        {
            bool isSpecial = IsSpecialNumber(ch);
            Console.WriteLine("{0} -> {1}", ch, isSpecial);
        }
    }

    static bool IsSpecialNumber(int number)
    {
        int sumOfDigits = CalculateSumOfDigits(number);
        return sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;
    }

    static int CalculateSumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}
