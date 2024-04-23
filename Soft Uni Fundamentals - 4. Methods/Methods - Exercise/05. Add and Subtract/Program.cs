using System;
using System.Reflection.Metadata.Ecma335;

class AddSubtract
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int sum = Sum(num1,num2);
        int result = Subtract(sum, num3);

        Console.WriteLine(result);
    }

    static int Sum(int num1,int num2)
    { return num1 + num2; }

    static int Subtract(int sum,int num3)
    { return sum - num3; }
}