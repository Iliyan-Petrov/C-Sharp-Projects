using System;
using System.Collections.Generic;
using System.Linq;

class ListProducts
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> products = new List<string>();
        for (int i = 0; i < n; i++)
        {
            string currentProduct = Console.ReadLine();
            products.Add(currentProduct);
        }
        products.Sort();

        for (int i = 0; i < products.Count; i++)
        { Console.WriteLine($"{i + 1}.{products[i]}"); }
    }
}
