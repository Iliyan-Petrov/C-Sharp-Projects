using System;

class Volume_of_Pyramid
{
    static void Main()
    {
        double length, width, height;
        
        Console.Write("Length: ");
        length = ReadDouble();
        
        Console.Write("Width: ");
        width = ReadDouble();
        
        Console.Write("Height: ");
        height = ReadDouble();
        
        double volume = (length * width * height) / 3.0;
        
        Console.WriteLine($"Pyramid Volume: {volume:f2}");
    }
    
    static double ReadDouble()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
