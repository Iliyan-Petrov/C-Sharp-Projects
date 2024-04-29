using System;

public class Car
{
    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumptionPerKm { get; set; }
    public int DistanceTraveled { get; set; }

    public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKm = fuelConsumptionPerKm;
        DistanceTraveled = 0;
    }

    public bool CanMove(int distance)
    {
        double fuelNeeded = distance * FuelConsumptionPerKm;
        if (fuelNeeded <= FuelAmount)
        {
            FuelAmount -= fuelNeeded;
            DistanceTraveled += distance;
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        return $"{Model} {FuelAmount:f2} {DistanceTraveled}";
    }
}

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Car[] cars = new Car[n];

        for (int i = 0; i < n; i++)
        {
            string[] carInfo = Console.ReadLine().Split();
            string model = carInfo[0];
            double fuelAmount = double.Parse(carInfo[1]);
            double fuelConsumptionPerKm = double.Parse(carInfo[2]);

            cars[i] = new Car(model, fuelAmount, fuelConsumptionPerKm);
        }

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] commandArgs = command.Split();
            string model = commandArgs[1];
            int distance = int.Parse(commandArgs[2]);

            Car car = cars.FirstOrDefault(c => c.Model == model);
            if (car != null)
            {
                if (!car.CanMove(distance))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
        }

        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }
    }
}