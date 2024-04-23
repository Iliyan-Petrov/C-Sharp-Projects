using System;
using System.Reflection.Metadata.Ecma335;

class Matrix
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] arr = new int[number];

        FillArray(number, arr);
        PrintMatrix(arr);
    }

    static void PrintMatrix(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        { Console.WriteLine(string.Join(" ", array)); }
    }

    static void FillArray(int number, int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        { array[i] = number; }
    }
}