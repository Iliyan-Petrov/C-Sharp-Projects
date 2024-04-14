using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

public class Food
{
   public string Name { get; set; }
   public DateTime ExpirationDate { get; set; }
   public int Calories { get; set; }
}

public class Program
{
   public static void Main()
   {
       string input = Console.ReadLine();
       var foodItems = ExtractFoodItems(input);
       CalculateDaysAndPrintFoodItems(foodItems);
   }

  public static List<Food> ExtractFoodItems(string input)
{
   var foodItems = new List<Food>();
   var matches = Regex.Matches(input, @"#(.*?)#||\{(.*?)\}|");
   foreach (Match match in matches)
   {
       var food = new Food();
       var parts = match.Value.Split('|');
       if (parts.Length < 3)
       {
           continue;
       }
       food.Name = parts[0];
       food.ExpirationDate = DateTime.ParseExact(parts[1], "dd/MM/yy", CultureInfo.InvariantCulture);
       food.Calories = int.Parse(parts[2]);
       foodItems.Add(food);
   }
   return foodItems;
}


   public static void CalculateDaysAndPrintFoodItems(List<Food> foodItems)
   {
       int totalCalories = foodItems.Sum(food => food.Calories);
       int days = totalCalories / 2000;
       Console.WriteLine($"You have food to last you for: {days} days!");
       foreach (var food in foodItems)
       {
           Console.WriteLine($"Item: {food.Name}, Best before: {food.ExpirationDate.ToString("dd/MM/yy")}, Nutrition: {food.Calories}");
       }
   }
}
