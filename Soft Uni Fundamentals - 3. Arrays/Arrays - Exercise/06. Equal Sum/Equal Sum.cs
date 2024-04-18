using System;

class EqualSum
{
    static int FindBalanceIndex(int[] arr)
    {
        int n = arr.Length;
        
        int totalSum = 0;
        for (int i = 0; i < n; i++)
        {totalSum += arr[i];}

        int leftSum = 0;

        for (int i = 0; i < n; i++)
        {
            int rightSum = totalSum - leftSum - arr[i];

            if (leftSum == rightSum) {return i;}
            leftSum += arr[i];
        }
        return -1;
    }


    static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        int balanceIndex = FindBalanceIndex(arr);

        if (balanceIndex != -1)
        {Console.WriteLine(balanceIndex);}
        else
        {Console.WriteLine("no");}
    }
}