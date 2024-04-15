using System;

class Vacation
{
    static void Main()
    {
        int countOfPeople = int.Parse(Console.ReadLine());
        string typeOfGroup = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();

        double priceForPerson = 0;
        double totalPrice = 0;
        
        if(typeOfGroup == "Students")
        {
            if(dayOfWeek=="Friday") {priceForPerson = 8.45;}
            else if(dayOfWeek=="Saturday") {priceForPerson = 9.80;}
            else if(dayOfWeek=="Sunday") {priceForPerson = 10.46;}

            totalPrice = countOfPeople * priceForPerson;
            if (countOfPeople >= 30) {totalPrice *= 0.85;}
        }
        else if(typeOfGroup == "Business")
        {
            if(dayOfWeek=="Friday") {priceForPerson = 10.90;}
            else if(dayOfWeek=="Saturday") {priceForPerson = 15.60;}
            else if(dayOfWeek=="Sunday") {priceForPerson = 16;}

            totalPrice = countOfPeople * priceForPerson;
            if (countOfPeople >= 100) {totalPrice = (countOfPeople - 10) * priceForPerson;}
        }
        else if(typeOfGroup == "Regular")
        {
            if(dayOfWeek=="Friday") {priceForPerson = 15;}
            else if(dayOfWeek=="Saturday") {priceForPerson = 20;}
            else if(dayOfWeek=="Sunday") {priceForPerson = 22.50;}

            totalPrice = countOfPeople * priceForPerson;
            if (countOfPeople >= 10 && countOfPeople <= 20) {totalPrice *= 0.95;}
        }

        Console.WriteLine($"Total price: {totalPrice:F2}");
    }
}
