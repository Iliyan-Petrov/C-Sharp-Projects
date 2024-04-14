using System;

class Program
{
   static void Main(string[] args)
   {
       string message = Console.ReadLine();

       string command;
       while ((command = Console.ReadLine()) != "Decode")
       {
           string[] parts = command.Split('|');

           switch (parts[0])
           {
               case "Move":
                  int moveCount = int.Parse(parts[1]);
                  message = message.Substring(moveCount) + message.Substring(0, moveCount);
                  break;
               case "Insert":
                  int index = int.Parse(parts[1]);
                  message = message.Insert(index, parts[2]);
                  break;
               case "ChangeAll":
                  message = message.Replace(parts[1], parts[2]);
                  break;
           }
       }

       Console.WriteLine($"The decrypted message is: {message}");
   }
}
