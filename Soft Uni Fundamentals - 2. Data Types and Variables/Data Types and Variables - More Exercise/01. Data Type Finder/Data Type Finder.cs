using System;

class Data_Type_Finder
{
    static void Main()
    {
        string input;
        
        while (true)
        {
            input = Console.ReadLine();

            if (input.Equals("END", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            if (IsInteger(input))
            {
                Console.WriteLine($"{input} is integer type");
            }
            else if (IsFloatingPoint(input))
            {
                Console.WriteLine($"{input} is floating point type");
            }
            else if (IsBoolean(input))
            {
                Console.WriteLine($"{input} is boolean type");
            }
            else if (IsCharacter(input))
            {
                Console.WriteLine($"{input} is character type");
            }
            else
            {
                Console.WriteLine($"{input} is string type");
            }
        }
    }

    static bool IsInteger(string input)
    {
        int result;
        return int.TryParse(input, out result);
    }

    static bool IsFloatingPoint(string input)
    {
        float result;
        return float.TryParse(input, out result);
    }

    static bool IsBoolean(string input)
    {
        bool result;
        return bool.TryParse(input, out result);
    }

    static bool IsCharacter(string input)
    {
        char result;
        return char.TryParse(input, out result);
    }
}
