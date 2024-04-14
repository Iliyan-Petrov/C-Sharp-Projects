using System;
using System.Linq;

class ArrayModifier
{
   static void Main()
   {
       string input = Console.ReadLine();
       int[] arr = input.Split(' ').Select(int.Parse).ToArray();

       string command = Console.ReadLine();
       while (command != "end")
       {
           string[] words = command.Split(' ');
           switch (words[0])
           {
               case "swap":
                  int index1 = int.Parse(words[1]);
                  int index2 = int.Parse(words[2]);
                  int temp = arr[index1];
                  arr[index1] = arr[index2];
                  arr[index2] = temp;
                  break;
               case "multiply":
                  index1 = int.Parse(words[1]);
                  index2 = int.Parse(words[2]);
                  arr[index1] *= arr[index2];
                  break;
               case "decrease":
                  for (int i = 0; i < arr.Length; i++)
                  {
                      arr[i]--;
                  }
                  break;
           }
           command = Console.ReadLine();
       }

       Console.WriteLine(string.Join(", ", arr));
   }
}