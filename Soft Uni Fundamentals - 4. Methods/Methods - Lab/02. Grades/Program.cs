using System;

class Grades
{
    static void Main()
    {
        Grade(double.Parse(Console.ReadLine()));
    }

    static void Grade(double number)
    {
        string grade = string.Empty;
        if(number >= 2.00 && number <= 2.99)
        {grade = "Fail"; Console.WriteLine(grade);}

        else if(number >= 3.00 && number <= 3.49)
        {grade = "Poor"; Console.WriteLine(grade);}

        else if(number >= 3.50 && number <= 4.49)
        {grade = "Good"; Console.WriteLine(grade);}

        else if(number >= 4.50 && number <= 5.49)
        {grade = "Very good"; Console.WriteLine(grade);}

        else if(number >= 5.50 && number <= 6.00)
        {grade = "Excellent"; Console.WriteLine(grade);}
    }
}