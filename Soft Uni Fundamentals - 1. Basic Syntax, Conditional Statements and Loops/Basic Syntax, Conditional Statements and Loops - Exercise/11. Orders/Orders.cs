using System;

class Orders
{
    static void Main()
    {
        int ordersCount = int.Parse(Console.ReadLine());
        double pricePerCapsule;
        int daysInMonth;
        int capsulesCount;
        double Total = 0;

        for (int i = 1; i<=ordersCount; i++)
        {
            pricePerCapsule = double.Parse(Console.ReadLine());
            daysInMonth = int.Parse(Console.ReadLine());
            capsulesCount = int.Parse(Console.ReadLine());

            double orderPrice = ((daysInMonth * capsulesCount) * pricePerCapsule);
            Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
            Total += orderPrice;
        }

        Console.WriteLine($"Total: ${Total:F2}");
    }
}
