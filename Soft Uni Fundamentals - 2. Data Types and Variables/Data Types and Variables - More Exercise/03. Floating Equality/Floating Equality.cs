using System;

class Program
{
    static void Main()
    {
        double eps = 0.000001;
        double a, b;
        if (double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b))
        {
            if (Math.Abs(a - b) < eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid double values.");
        }
    }
}
