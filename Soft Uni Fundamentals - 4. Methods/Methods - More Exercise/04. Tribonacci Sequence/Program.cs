using System;

class TribonacciSequence
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        PrintTribonacciSequence(num);
    }

    static void PrintTribonacciSequence(int num)
    {
        if (num < 1)
            return;

        int[] tribonacci = new int[num];

        tribonacci[0] = 1;
        Console.Write(tribonacci[0] + " ");

        if (num == 1)
            return;

        tribonacci[1] = 1;
        Console.Write(tribonacci[1] + " ");

        if (num == 2)
            return;

        tribonacci[2] = 2;
        Console.Write(tribonacci[2] + " ");

        for (int i = 3; i < num; i++)
        {
            tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
            Console.Write(tribonacci[i] + " ");
        }

        Console.WriteLine();
    }
}
