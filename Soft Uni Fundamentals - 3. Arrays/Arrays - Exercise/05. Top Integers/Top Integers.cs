using System;

class TopIntegers
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<int> topIntegers = FindTopIntegers(arr);

        foreach (int topInteger in topIntegers)
        {Console.Write(topInteger + " ");}
    }

    static List<int> FindTopIntegers(int[] array)
    {
        List<int> topIntegers = new List<int>();
        int maxRight = int.MinValue;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            int currentElement = array[i];
            if (currentElement > maxRight)
            {
                topIntegers.Add(currentElement);
                maxRight = currentElement;
            }
        }

        topIntegers.Reverse();
        return topIntegers;
    }  
}