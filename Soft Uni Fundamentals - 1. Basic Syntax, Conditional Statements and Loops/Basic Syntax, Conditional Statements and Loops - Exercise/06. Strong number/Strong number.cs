using System;

class Strong_Number
{
    static int Factorial(int num)
    {
        if (num <= 1)
            return 1;

        int result = 1;
        for (int i = 2; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }

    static bool IsStrong(int num)
    {
        int originalNum = num;
        int sumOfFactorials = 0;

        while (num > 0)
        {
            int digit = num % 10;
            sumOfFactorials += Factorial(digit);
            num /= 10;
        }

        return sumOfFactorials == originalNum;
    }

    static void Main()
    {
    int number = int.Parse(Console.ReadLine());
    if (IsStrong(number)) {Console.WriteLine("yes");}
    else {Console.WriteLine("no");}
    }
}
