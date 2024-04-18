using System;

class CommonElements
{
    static void Main()
    {
        string[] arr1 = Console.ReadLine().Split();
        string[] arr2 = Console.ReadLine().Split();

        var commonElements = arr1.Intersect(arr2);

        foreach (var element in commonElements)
        {
            Console.Write(element + " ");
        }
    }   
}