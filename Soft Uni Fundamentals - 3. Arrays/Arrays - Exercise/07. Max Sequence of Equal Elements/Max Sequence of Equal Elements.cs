using System;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int maxLength = 0;
        int currentLength = 1;
        int longestElement = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if(arr[i] == arr[i-1])
            {
                currentLength++;
                if(currentLength > maxLength)
                {
                    maxLength = currentLength;
                    longestElement = arr[i];
                }
            }
            else
            {
                currentLength = 1;
            }
        }

        int[] longestSequence = new int[maxLength];
        for (int i = 0; i < maxLength; i++)
        {
            longestSequence[i] = longestElement;
        }
         Console.WriteLine(string.Join(" ", longestSequence));
    }
}