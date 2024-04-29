using System;
using System.Collections.Generic;
using System.Linq;

class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int Quantity { get; set; }
    public decimal PriceBox { get; set; }
}

class StoreBoxes
{
    static void Main()
    {
        List<Box> boxes = new List<Box>();

        string input = Console.ReadLine();
        while (input != "end")
        {
            string[] data = input.Split(' ');

            string serialNumber = data[0];
            string itemName = data[1];
            int itemQuantity = int.Parse(data[2]);
            decimal itemPrice = decimal.Parse(data[3]);

            Item item = new Item { Name = itemName, Price = itemPrice };
            decimal boxPrice = itemQuantity * itemPrice;

            Box box = new Box
            {
                SerialNumber = serialNumber,
                Item = item,
                Quantity = itemQuantity,
                PriceBox = boxPrice
            };

            boxes.Add(box);

            input = Console.ReadLine();
        }

        var sortedBoxes = boxes.OrderByDescending(b => b.PriceBox);

        foreach (var box in sortedBoxes)
        {
            Console.WriteLine(box.SerialNumber);
            Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
            Console.WriteLine($"-- ${box.PriceBox:F2}");
        }
    }
}
