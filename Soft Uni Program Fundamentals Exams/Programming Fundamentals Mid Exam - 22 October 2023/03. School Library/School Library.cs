using System;
using System.Collections.Generic;

class SchoolLibrary
{
    static void Main()
    {
        string[] shelf = Console.ReadLine().Split('&');
        List<string> books = new List<string>(shelf);

        string command;
        while ((command = Console.ReadLine()) != "Done")
        {
            string[] commandParts = command.Split(" | ");
            string commandType = commandParts[0];
            string book = commandParts[1];

            switch (commandType)
            {
                case "Add Book":
                    if (!books.Contains(book))
                    {
                        books.Insert(0, book);
                    }
                    break;
                case "Take Book":
                    if (books.Contains(book))
                    {
                        books.Remove(book);
                    }
                    break;
                case "Swap Books":
                    string book1 = commandParts[1];
                    string book2 = commandParts[2];
                    int index1 = books.IndexOf(book1);
                    int index2 = books.IndexOf(book2);
                    if (index1 != -1 && index2 != -1)
                    {
                        books[index1] = book2;
                        books[index2] = book1;
                    }
                    break;
                case "Insert Book":
                    if (!books.Contains(book))
                    {
                        books.Add(book);
                    }
                    break;
                case "Check Book":
                    int index = int.Parse(book);
                    if (index >= 0 && index < books.Count)
                    {
                        Console.WriteLine(books[index]);
                    }
                    break;
            }
        }

        Console.WriteLine(string.Join(", ", books));
    }
}
