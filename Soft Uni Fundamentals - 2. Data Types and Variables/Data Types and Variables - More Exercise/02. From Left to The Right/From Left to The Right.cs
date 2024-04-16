using System;
using System.Numerics;

class From_Left_To_Right
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            
            BigInteger leftNumber = BigInteger.Parse(input[0]);
            BigInteger rightNumber = BigInteger.Parse(input[1]);

            BigInteger leftSum = GetSumOfDigits(leftNumber);
            BigInteger rightSum = GetSumOfDigits(rightNumber);

            if (leftNumber > rightNumber)
            {
                Console.WriteLine(leftSum);
            }
            else
            {
                Console.WriteLine(rightSum);
            }
        }
    }

    static BigInteger GetSumOfDigits(BigInteger number)
    {
        number = BigInteger.Abs(number); 
        BigInteger sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}
