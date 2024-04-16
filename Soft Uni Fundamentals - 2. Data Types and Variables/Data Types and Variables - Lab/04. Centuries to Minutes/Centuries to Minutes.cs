using System;

class Centuries_to_Minutes
{
    static void Main()
    {
        int centuries = int.Parse(Console.ReadLine());

        double daysPerYear = 365.2422;
        int yearsInCentury = 100;

        int years = centuries * yearsInCentury;
        int days = (int)(centuries * yearsInCentury * daysPerYear);
        long hours = (long)(days * 24L);
        long minutes = hours * 60L;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
    }
}
