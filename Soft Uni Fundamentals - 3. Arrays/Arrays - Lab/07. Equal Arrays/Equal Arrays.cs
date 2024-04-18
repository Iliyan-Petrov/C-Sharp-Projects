using System;

class Equal_Arrays
{
    static void Main()
    {
        int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

        bool identical = true;
        int sum = 0;
        int diffIndex = 0;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                identical = false;
                diffIndex = i;
                break;
            }
            else
            {
                sum += arr1[i];
            }
        }

        if (identical)
        {Console.WriteLine($"Arrays are identical. Sum: {sum}");}
        else
        {Console.WriteLine($"Arrays are not identical. Found difference at {diffIndex} index");}
    }   
}
