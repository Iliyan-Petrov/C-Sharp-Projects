using System;
using System.Collections.Generic;
using System.Linq;

class changeList
{
    static void Main()
    {
       List<int> numbers = Console.ReadLine()
       .Split().Select(int.Parse).ToList();

       while(true)
       {
        string[] command = Console.ReadLine().Split();
        string action = command [0];

        if(action == "end")
        { break; }

        if(action == "Delete")
        {
            int elementToDelete = int.Parse(command[1]);
            numbers.RemoveAll(num => num == elementToDelete);
        }
        
        else if(action == "Insert")
        {
            int elementToInsert = int.Parse(command[1]);
            int position = int.Parse(command[2]);
            numbers.Insert(position, elementToInsert);
        }
       }

       Console.WriteLine(string.Join(" ", numbers));
    }
}
