using System;

class Program
{
    static void Main()
    {

        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int product = num1 * num2 * num3;

        if (product < 0)
        {
            Console.WriteLine("negative");
        }
        else if (product > 0)
        {
            Console.WriteLine("positive");
        }
        else
        {
            Console.WriteLine("zero");
        }
    }
}
