using System;
using System.Reflection.Metadata.Ecma335;

class Password
{
    static void Main()
    {
        string password = Console.ReadLine();

        if (IsPasswordValid(password))
        {
            Console.WriteLine("Password is valid");
        }
        else
        {
            foreach (var errorMessage in GetValidationErrors(password))
            {
                Console.WriteLine(errorMessage);
            }
        }
    }

    static bool IsPasswordValid(string password)
    {
        if (password.Length < 6 || password.Length > 10)
        { return false; }

        if (!password.All(char.IsLetterOrDigit))
        { return false; }

        int digitCount = password.Count(char.IsDigit);
        if (digitCount < 2)
        { return false; }

        return true;
    }

    static string[] GetValidationErrors(string password)
    {
        var errors = new List<string>();

        if (password.Length < 6 || password.Length > 10)
        {
            errors.Add("Password must be between 6 and 10 characters");
        }

        if (!password.All(char.IsLetterOrDigit))
        {
            errors.Add("Password must consist only of letters and digits");
        }

        int digitCount = password.Count(char.IsDigit);
        if (digitCount < 2)
        {
            errors.Add("Password must have at least 2 digits");
        }

        return errors.ToArray();
    }
}