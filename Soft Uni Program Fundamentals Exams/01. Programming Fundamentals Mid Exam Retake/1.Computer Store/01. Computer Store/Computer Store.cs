using System;

class Program
{
    static void Main()
    {
        decimal totalPriceWithoutTaxes = 0;
        decimal totalTaxes = 0;
        string customerType = "";

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "special" || input == "regular")
            {
                customerType = input;
                break;
            }

            decimal price = decimal.Parse(input);

            if (price <= 0)
            {
                Console.WriteLine("Invalid price!");
                continue;
            }

            decimal taxes = price * 0.2m;
            totalTaxes += taxes;
            totalPriceWithoutTaxes += price;
        }

        if (totalPriceWithoutTaxes == 0)
        {
            Console.WriteLine("Invalid order!");
            return;
        }

        decimal totalPriceWithTaxes = totalPriceWithoutTaxes + totalTaxes;

        if (customerType == "special")
        {
            decimal discount = totalPriceWithTaxes * 0.1m;
            totalPriceWithTaxes -= discount;
        }

        Console.WriteLine("Congratulations you've just bought a new computer!");
        Console.WriteLine($"Price without taxes: {totalPriceWithoutTaxes:F2}$");
        Console.WriteLine($"Taxes: {totalTaxes:F2}$");
        Console.WriteLine("-----------");
        Console.WriteLine($"Total price: {totalPriceWithTaxes:F2}$");
    }
}