using System;

class Rage_Expenses
{
    static void Main()
    {
        int lostGamesCount = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        double totalExpenses = 0;
        int trashedHeadsetCount = lostGamesCount / 2;
        int trashedMouseCount = lostGamesCount / 3;
        int trashedKeyboardCount = lostGamesCount / 3 / 2; 
        int trashedDisplayCount = trashedKeyboardCount / 2;


        totalExpenses += trashedHeadsetCount * headsetPrice;
        totalExpenses += trashedMouseCount * mousePrice;
        totalExpenses += trashedKeyboardCount * keyboardPrice;
        totalExpenses += trashedDisplayCount * displayPrice;

        Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");
    }
}
