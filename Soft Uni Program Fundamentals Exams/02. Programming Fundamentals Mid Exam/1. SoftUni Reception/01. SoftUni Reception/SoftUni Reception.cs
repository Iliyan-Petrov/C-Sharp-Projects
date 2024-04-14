using System;

class Program
{
  static void Main()
  {
      int[] employees = new int[3];
      for (int i = 0; i <= 2; i++)
      {
          employees[i] = int.Parse(Console.ReadLine());
      }

      int totalStudents = int.Parse(Console.ReadLine());

      int totalPerHour = employees[0] + employees[1] + employees[2];

      double totalTime = (double)totalStudents / totalPerHour;

      totalTime += Math.Floor(totalTime / 3.0);

      Console.WriteLine($"Time needed: {Math.Ceiling(totalTime)}h.");
  }
}
