using System;

class recursiveFibunacci
{
    static long[] memoization = new long[51];

    static long GetFibonacci(int n)
    {
        if (n <= 0)
        { return 0; }
        else if (n == 1 || n == 2)
        { return 1; }
        else if (memoization[n] != 0)
        { return memoization[n]; }
        else
        { memoization[n] = GetFibonacci(n - 1) + GetFibonacci(n - 2); return memoization[n]; }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 50)
        { Console.WriteLine("Invalid input. N must be between 1 and 50."); }
        else
        { long result = GetFibonacci(n); Console.WriteLine(result); }
    }
}
