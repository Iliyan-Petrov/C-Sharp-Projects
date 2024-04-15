using System;

class Padawan_equipment
{
    static void Main()
    {
        double moneyAmount = double.Parse(Console.ReadLine());
        int studentCount = int.Parse(Console.ReadLine());
        double lightSaberPrice = double.Parse(Console.ReadLine());
        double robesPrice = double.Parse(Console.ReadLine());
        double beltPrice = double.Parse(Console.ReadLine());

        int freeBelts = studentCount / 6;
        double additionalRobePrice = studentCount * 0.10;

        if (studentCount % 10 != 0)
        {
            additionalRobePrice = Math.Ceiling(additionalRobePrice);
        }

        double totalCost = (lightSaberPrice * (studentCount + additionalRobePrice)) + (robesPrice * studentCount) + (beltPrice * (studentCount - freeBelts));

        if (moneyAmount >= totalCost)
        {
            Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
        }
        else
        {
            double neededMoney = totalCost - moneyAmount;
            Console.WriteLine($"John will need {neededMoney:F2}lv more.");
        }
    }
}
