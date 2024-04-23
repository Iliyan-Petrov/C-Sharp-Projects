using System;

class centerPoint
{
    static void Main()
    {
        double x1, y1, x2, y2;

        x1 = double.Parse(Console.ReadLine());
        y1 = double.Parse(Console.ReadLine());

        x2 = double.Parse(Console.ReadLine());
        y2 = double.Parse(Console.ReadLine());

        string closestPoint = FindClosestPoint(x1, y1, x2, y2);
        Console.WriteLine(closestPoint);
    }

    static string FindClosestPoint(double x1, double y1, double x2, double y2)
    {
        double distance1 = Math.Sqrt(x1 * x1 + y1 * y1);
        double distance2 = Math.Sqrt(x2 * x2 + y2 * y2);

        if (distance1 <= distance2 || distance1 == distance2)
        {
            return $"({x1}, {y1})";
        }
        else
        {
            return $"({x2}, {y2})";
        }
    }
}
