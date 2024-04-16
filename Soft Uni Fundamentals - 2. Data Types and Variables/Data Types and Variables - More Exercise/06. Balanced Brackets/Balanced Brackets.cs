using System;
using System.Collections.Generic;

class Balanced_Brackets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Stack<char> stack = new Stack<char>();

        bool isBalanced = true;

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();

            foreach (char symbol in line)
            {
                if (symbol == '(')
                {
                    if (stack.Count > 0 && stack.Peek() == '(')
                    {
                        isBalanced = false;
                        break;
                    }

                    stack.Push(symbol);
                }
                else if (symbol == ')')
                {
                    if (stack.Count == 0 || stack.Pop() != '(')
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }
        }

        if (stack.Count > 0 || !isBalanced)
        {
            Console.WriteLine("UNBALANCED");
        }
        else
        {
            Console.WriteLine("BALANCED");
        }
    }
}
