using System;

class Gaming_Store
{
    static void Main()
    {
        double balance = double.Parse(Console.ReadLine());
        double totalSpent = 0.0;

        while (true)
        {
            string game = Console.ReadLine();

            if (game == "Game Time")
            {
                Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${balance:F2}");
                break;
            }

            switch (game)
            {
                case "OutFall 4":
                    if (balance >= 39.99)
                    {
                        Console.WriteLine("Bought OutFall 4");
                        balance -= 39.99;
                        totalSpent += 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;

                case "CS: OG":
                    if (balance >= 15.99)
                    {
                        Console.WriteLine("Bought CS: OG");
                        balance -= 15.99;
                        totalSpent += 15.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;

                case "Zplinter Zell":
                    if (balance >= 19.99)
                    {
                        Console.WriteLine("Bought Zplinter Zell");
                        balance -= 19.99;
                        totalSpent += 19.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;

                case "Honored 2":
                    if (balance >= 59.99)
                    {
                        Console.WriteLine("Bought Honored 2");
                        balance -= 59.99;
                        totalSpent += 59.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;

                case "RoverWatch":
                    if (balance >= 29.99)
                    {
                        Console.WriteLine("Bought RoverWatch");
                        balance -= 29.99;
                        totalSpent += 29.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;

                case "RoverWatch Origins Edition":
                    if (balance >= 39.99)
                    {
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        balance -= 39.99;
                        totalSpent += 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    break;

                default:
                    Console.WriteLine("Not Found");
                    break;
            }

            if (balance <= 0)
            {
                Console.WriteLine("Out of money!");
                break;
            }
        }
    }
}
