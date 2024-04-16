using System;

class Prime_Checker
{
    static void Main()
    {
        int limit = int.Parse(Console.ReadLine());

        for (int number = 2; number <= limit; number++)
        {
            bool isPrime = IsPrime(number);
            Console.WriteLine("{0} -> {1}", number, isPrime.ToString().ToLower());
        }
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        for (int divisor = 2; divisor * divisor <= num; divisor++)
        {
            if (num % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }
}
