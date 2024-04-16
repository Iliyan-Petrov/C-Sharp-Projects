using System;

class Town_Info
{
    static void Main()
    {
        string str = "";
        for (int i = 0; i < 3; i++)
        {string line = Console.ReadLine(); str+= line;}
        Console.WriteLine(str);
    }

}
