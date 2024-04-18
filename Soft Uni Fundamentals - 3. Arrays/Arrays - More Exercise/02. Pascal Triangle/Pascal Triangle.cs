using System;

class PascalTriangle
{
    static void Main()
    {
        int numRows = int.Parse(Console.ReadLine());
        PrintPascalsTriangle(numRows);
    }

    static void PrintPascalsTriangle(int numRows)
    {
        for (int i = 0; i < numRows; i++)
        {
            int currentValue = 1;
            int padding = (numRows - i) * 2;

            Console.Write(new string(' ', padding));

            for (int j = 0; j <= i; j++)
            {
                Console.Write(currentValue + " ");
                currentValue = currentValue * (i - j) / (j + 1);
            }

            Console.WriteLine();
        }
    }
}
