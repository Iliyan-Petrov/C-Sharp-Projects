using System;

class Print_part_of_ASCII_table
{
    static void Main()
    {

        int startIndex = int.Parse(Console.ReadLine());
        int endIndex = int.Parse(Console.ReadLine());

        if (startIndex < 0 || startIndex > 127 || endIndex < 0 || endIndex > 127 || startIndex > endIndex)
        {
            Console.WriteLine("Invalid input. Please enter valid indices.");
            return;
        }
        for (int i = startIndex; i <= endIndex; i++)
        {
            char character = (char)i;
            Console.Write($"{character} ");
        }
    }
}
