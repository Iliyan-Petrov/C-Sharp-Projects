using System;
using System.Diagnostics.CodeAnalysis;

class Login
{
    static void Main()
    {
        string username = Console.ReadLine();
        string password = "";

        for (int i = username.Length - 1; i>= 0; i--)
        {
            password += username[i];
        }

        int attempts = 0;

        while(attempts < 4)
        {
            string passwordAttempt = Console.ReadLine();
            attempts++;

            if (passwordAttempt == password)
            {
                Console.WriteLine($"User {username} logged in."); break;
            }
            else if (attempts == 4)
            {
                Console.WriteLine($"User {username} blocked!"); break;
            }
            else
            {
                Console.WriteLine($"Incorrect password. Try again.");
            }
        }
    }
}
