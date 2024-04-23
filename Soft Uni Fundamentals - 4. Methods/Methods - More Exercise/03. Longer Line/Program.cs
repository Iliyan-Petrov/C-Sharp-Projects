using System;

class LongerLine
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());

        string longerLine = FindLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        Console.WriteLine(longerLine);
    }

    static string FindLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        double distance1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        double distance2 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));

        double centerDistance1 = Math.Sqrt(x1 * x1 + y1 * y1);
        double centerDistance2 = Math.Sqrt(x2 * x2 + y2 * y2);
        double centerDistance3 = Math.Sqrt(x3 * x3 + y3 * y3);
        double centerDistance4 = Math.Sqrt(x4 * x4 + y4 * y4);

        if (distance1 >= distance2)
        {
            if (centerDistance1 <= centerDistance2)
            {
                return $"({x1}, {y1})({x2}, {y2})";
            }
            else
            {
                return $"({x2}, {y2})({x1}, {y1})";
            }
        }
        else
        {
            if (centerDistance3 <= centerDistance4)
            {
                return $"({x3}, {y3})({x4}, {y4})";
            }
            else
            {
                return $"({x4}, {y4})({x3}, {y3})";
            }
        }
    }
}
