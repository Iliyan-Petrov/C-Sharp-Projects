using System;

class Ages
{
    static void Main()
    {
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            string category;

            if (age >= 0 && age <= 2)
            {
                category = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                category = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                category = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                category = "adult";
            }
            else
            {
                category = "elder";
            }

            Console.WriteLine($"{category}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
