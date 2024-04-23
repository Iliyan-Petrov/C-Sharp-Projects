using System;

class dataTypes
{
    static void Main()
    {
        string dataType = Console.ReadLine();

        switch (dataType)
        {
            case "int":
                if (int.TryParse(Console.ReadLine(), out int intValue))
                {
                    int result = intValue * 2;
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Invalid input for int.");
                }
                break;

            case "real":
                if (double.TryParse(Console.ReadLine(), out double doubleValue))
                {
                    double result = doubleValue * 1.5;
                    Console.WriteLine(result.ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("Invalid input for real.");
                }
                break;

            case "string":
                string stringValue = Console.ReadLine();
                Console.WriteLine($"${stringValue}$");
                break;

            default:
                Console.WriteLine("Invalid data type.");
                break;
        }
    }
}
