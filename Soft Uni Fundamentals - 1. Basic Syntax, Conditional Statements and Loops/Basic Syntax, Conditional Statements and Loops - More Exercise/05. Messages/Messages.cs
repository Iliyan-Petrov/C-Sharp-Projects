using System;

namespace Messages
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string message = GenerateMessage(n);

            Console.WriteLine(message);
        }

        static string GenerateMessage(int n)
        {
            string message = "";

            for (int i = 0; i < n; i++)
            {
                int pressedNumbers = int.Parse(Console.ReadLine());
                char calculatedCharacter = CalculateCharacter(pressedNumbers);
                message += calculatedCharacter;
            }

            return message;
        }

        static char CalculateCharacter(int pressedNumbers)
        {
            int digitNums = pressedNumbers.ToString().Length;
            int mainDigit = pressedNumbers % 10;
            int numOffset = (mainDigit - 2) * 3;

            if (mainDigit == 8 || mainDigit == 9)
            {numOffset += 1;}

            int index = numOffset + digitNums - 1;
            if (mainDigit == 0)
            {return (char)32;}
            else
            {return (char)(97 + index);}
        }
    }
}
