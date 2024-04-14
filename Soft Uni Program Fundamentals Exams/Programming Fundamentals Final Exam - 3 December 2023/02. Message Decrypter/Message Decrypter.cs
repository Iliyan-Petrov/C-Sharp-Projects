using System;
using System.Text.RegularExpressions;

class MessageDecrypter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            if (IsValidMessage(input, out string tag, out string decryptedMessage))
            {
                Console.WriteLine($"{tag}: {decryptedMessage}");
            }
            else
            {
                Console.WriteLine("Valid message not found!");
            }
        }
    }

    static bool IsValidMessage(string input, out string tag, out string decryptedMessage)
    {
        tag = "";
        decryptedMessage = "";

        Regex regex = new Regex(@"^([$|%])([A-Z][a-z]+)\$: \[([0-9]+)\]\|\[([0-9]+)\]\|\[([0-9]+)\]\|$");
        Match match = regex.Match(input);

        if (match.Success)
        {
            tag = match.Groups[2].Value;

            int num1 = int.Parse(match.Groups[3].Value);
            int num2 = int.Parse(match.Groups[4].Value);
            int num3 = int.Parse(match.Groups[5].Value);

            decryptedMessage = $"{(char)num1}{(char)num2}{(char)num3}";

            return true;
        }

        return false;
    }
}
