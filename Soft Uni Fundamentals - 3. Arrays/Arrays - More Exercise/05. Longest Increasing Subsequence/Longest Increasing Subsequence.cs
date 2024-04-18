using System;
using System.Collections.Generic;
using System.Linq;

class LongestIncreasingSubsequence
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputValues = input.Split(' ');
        int[] nums = Array.ConvertAll(inputValues, int.Parse);

        int[] lis = FindLongestIncreasingSubsequence(nums);
        Console.WriteLine(string.Join(" ", lis));
    }

    static int[] FindLongestIncreasingSubsequence(int[] nums)
    {
        int n = nums.Length;
        int[] lisLength = new int[n];
        int[] previousIndex = new int[n];

        for (int i = 0; i < n; i++)
        {
            lisLength[i] = 1;
            previousIndex[i] = -1;

            for (int j = 0; j < i; j++)
            {
                if (nums[i] > nums[j] && lisLength[i] < lisLength[j] + 1)
                {
                    lisLength[i] = lisLength[j] + 1;
                    previousIndex[i] = j;
                }
            }
        }

        int maxLisLength = lisLength.Max();
        int maxLisEndIndex = Array.IndexOf(lisLength, maxLisLength);

        List<int> longestIncreasingSubsequence = new List<int>();
        while (maxLisEndIndex != -1)
        {
            longestIncreasingSubsequence.Add(nums[maxLisEndIndex]);
            maxLisEndIndex = previousIndex[maxLisEndIndex];
        }

        longestIncreasingSubsequence.Reverse();
        return longestIncreasingSubsequence.ToArray();
    }
}
