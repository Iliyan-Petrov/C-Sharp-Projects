using System;

class Triples_Of_Latin_Letters
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 26)
        {
            Console.WriteLine("Please enter a valid integer between 1 and 26.");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    char firstChar = (char)('a' + i);
                    char secondChar = (char)('a' + j);
                    char thirdChar = (char)('a' + k);

                    Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                }
            }
        }
    }
}
