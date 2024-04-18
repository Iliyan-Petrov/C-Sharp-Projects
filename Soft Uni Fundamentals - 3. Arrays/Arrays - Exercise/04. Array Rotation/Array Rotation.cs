using System;

class arrayRotation
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rotations = int.Parse(Console.ReadLine());

        RotateArray(nums, rotations);

        foreach (int element in nums)
        {
            Console.Write(element + " ");
        }
    }

    static void RotateArray(int[] arr, int rotations)
    {
        int length = arr.Length;
        rotations %= length; 
        int[] temp = new int[length];

        Array.Copy(arr, 0, temp, 0, rotations);

        for (int i = 0; i < length - rotations; i++)
        {arr[i] = arr[i + rotations];}
        Array.Copy(temp, 0, arr, length - rotations, rotations);
    }   
}