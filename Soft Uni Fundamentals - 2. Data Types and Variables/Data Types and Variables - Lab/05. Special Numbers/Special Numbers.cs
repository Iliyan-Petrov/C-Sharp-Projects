using System;

class Special_Numbers
{
    static int SumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int sum = SumOfDigits(i);
            bool isSpecial = (sum == 5 || sum == 7 || sum == 11);

            Console.WriteLine($"{i} -> {isSpecial}");
        }
    }
}
