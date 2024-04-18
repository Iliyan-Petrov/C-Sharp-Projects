using System;

class ZigZagArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        for (int i = 0; i < n; i++)
        {
        string[] input = Console.ReadLine().Split();
        arr1[i] = int.Parse(input[0]);
        arr2[i] = int.Parse(input[1]);
        }

        int[] zigzagArr1 = new int[n];
        int[] zigzagArr2 = new int[n];

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                zigzagArr1[i] = arr1[i];
                zigzagArr2[i] = arr2[i];
            }
            else
            {
                zigzagArr1[i] = arr2[i];
                zigzagArr2[i] = arr1[i];
            }
        }

        Console.WriteLine(string.Join(" ", zigzagArr1));
        Console.WriteLine(string.Join(" ", zigzagArr2));
    }   
}