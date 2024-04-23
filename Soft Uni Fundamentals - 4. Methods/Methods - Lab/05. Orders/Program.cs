using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

class Orders
{
    static void Main()
    {
        string prod = Console.ReadLine();
        double qnty = int.Parse(Console.ReadLine());

        Order(prod,qnty);
    }

    static void Order(string product, double quantity)
    {
        double order = 0;
        switch (product)
        {
            case "coffee":
            order = quantity*1.50;
            Console.WriteLine($"{order:f2}");
            break;

            case "water":
            order = quantity*1.00;
            Console.WriteLine($"{order:f2}");
            break;

            case "coke":
            order = quantity*1.40;
            Console.WriteLine($"{order:f2}");
            break;

            case "snacks":
            order = quantity*2.00;
            Console.WriteLine($"{order:f2}");
            break;
        }
    }    
}