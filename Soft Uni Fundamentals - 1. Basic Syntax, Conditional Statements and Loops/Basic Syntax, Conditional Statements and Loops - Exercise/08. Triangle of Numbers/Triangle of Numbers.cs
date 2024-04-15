using System;

class Triangle_of_numbers
{
    static void Main()
    {
       int num = int.Parse(Console.ReadLine());
       int display_num = 0;

       for (int i = 1; i<=num;i++)
       {
        display_num++;
        for (int j = 0; j < display_num;j++)
        {
            Console.Write(i+" ");
        }
        Console.Write("\n");
       }
    }
}
