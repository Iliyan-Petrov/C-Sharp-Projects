using System;

class Condense_Array_to_Number
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

         int condensed = CondenseArray(nums);
         Console.WriteLine(condensed);
    }   

    static int CondenseArray(int[] nums)
    {
        while (nums.Length > 1)
        {
            int [] condensedArray = new int[nums.Length-1];
            for (int i = 0; i<nums.Length - 1; i++)
            {
                condensedArray[i] = nums[i] + nums[i+1];
            }
            nums=condensedArray;
        }
        return nums[0];
    }
}