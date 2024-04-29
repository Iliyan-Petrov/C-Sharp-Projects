using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    public decimal Money { get; set; }
    public List<Product> Bag { get; set; }

    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        Bag = new List<Product>();
    }

    public void BuyProduct(Product product)
    {
        if (Money >= product.Cost)
        {
            Bag.Add(product);
            Money -= product.Cost;
            Console.WriteLine($"{Name} bought {product.Name}");
        }
        else
        {
            Console.WriteLine($"{Name} can't afford {product.Name}");
        }
    }
}

class Product
{
    public string Name { get; set; }
    public decimal Cost { get; set; }

    public Product(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }
}

class ShoppingSpree
{
    static void Main(string[] args)
    {
        Dictionary<string, Person> people = new Dictionary<string, Person>();
        Dictionary<string, Product> products = new Dictionary<string, Product>();

        string[] peopleInput = Console.ReadLine().Split(';');
        foreach (string personData in peopleInput)
        {
            string[] personInfo = personData.Split('=');
            string name = personInfo[0];
            decimal money = decimal.Parse(personInfo[1]);
            people[name] = new Person(name, money);
        }

        string[] productsInput = Console.ReadLine().Split(';');
        foreach (string productData in productsInput)
        {
            string[] productInfo = productData.Split('=');
            string name = productInfo[0];
            decimal cost = decimal.Parse(productInfo[1]);
            products[name] = new Product(name, cost);
        }

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] commandArgs = command.Split(' ');
            string personName = commandArgs[0];
            string productName = commandArgs[1];

            if (people.ContainsKey(personName) && products.ContainsKey(productName))
            {
                Person person = people[personName];
                Product product = products[productName];
                person.BuyProduct(product);
            }
        }

        foreach (var person in people.Values)
        {
            Console.Write($"{person.Name} - ");
            if (person.Bag.Count > 0)
            {
                Console.WriteLine(string.Join(", ", person.Bag.Select(p => p.Name)));
            }
            else
            {
                Console.WriteLine("Nothing bought");
            }
        }
    }
}
