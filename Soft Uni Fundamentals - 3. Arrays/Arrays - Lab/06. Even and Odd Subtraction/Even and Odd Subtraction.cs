using System;

class Even_And_Odd_Subtraction
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int evenSum = 0;
        int oddSum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];
            if(currentNumber % 2 == 0) {evenSum += currentNumber;}
            else {oddSum += currentNumber;}
        }
        int diff = evenSum - oddSum;
        Console.WriteLine(diff);
    }   
}
