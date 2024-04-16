using System;

class Sum_of_Real_Numbers
{
    static void Main()
    {
        int nums = int.Parse(Console.ReadLine());
        decimal count = 0;
        for (int i = 1; i <= nums; i++)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            count += n;
        }
        Console.WriteLine(count);
    }
}
