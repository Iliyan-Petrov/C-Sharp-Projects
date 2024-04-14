using System;

class Program
{
    static void Main()
    {
        int peopleWaiting = int.Parse(Console.ReadLine());
        string[] wagons = Console.ReadLine().Split();

        int[] wagonOccupancy = new int[wagons.Length];
        int totalPeople = 0;

        for (int i = 0; i < wagons.Length; i++)
        {
            wagonOccupancy[i] = int.Parse(wagons[i]);
            totalPeople += wagonOccupancy[i];
        }

        for (int i = 0; i < wagonOccupancy.Length; i++)
        {
            while (wagonOccupancy[i] < 4 && peopleWaiting > 0)
            {
                wagonOccupancy[i]++;
                peopleWaiting--;
                totalPeople++;
            }
        }

        if (peopleWaiting == 0)
        {
            if (totalPeople < wagonOccupancy.Length * 4)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagonOccupancy));
            }
            else
            {
                Console.WriteLine(string.Join(" ", wagonOccupancy));
            }
        }
        else
        {
            Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            Console.WriteLine(string.Join(" ", wagonOccupancy));
        }
    }
}
