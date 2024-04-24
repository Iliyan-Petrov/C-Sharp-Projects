using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class AnonymousThreat
{
        static void Main(string[] args)
        {
            List<string> textsList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "3:1")
            {
                List<string> commands = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string operation = commands[0];

                if (operation == "merge")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    CheckIndex(textsList, ref startIndex, ref endIndex);
                    MergeText(textsList, startIndex, endIndex);
                }
                else if (operation == "divide")
                {
                    int index = int.Parse(commands[1]);
                    int partitions = int.Parse(commands[2]);

                    CheckIndex(textsList, ref index, ref index); // Ensure 'index' is within the bounds
                    CheckPartitions(ref partitions); // Check 'partitions' range
                    DivideText(textsList, index, partitions);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", textsList));
        }

        private static void CheckIndex(List<string> textsList, ref int startIndex, ref int endIndex)
        {
            const int minIndex = -1000;
            const int maxIndex = 1000;

            if (startIndex < minIndex)
            {
                startIndex = minIndex;
            }
            else if (startIndex > maxIndex)
            {
                startIndex = maxIndex;
            }

            if (endIndex < minIndex)
            {
                endIndex = minIndex;
            }
            else if (endIndex > maxIndex)
            {
                endIndex = maxIndex;
            }

            // Ensure that startIndex is not greater than endIndex
            if (startIndex > endIndex)
            {
                int temp = startIndex;
                startIndex = endIndex;
                endIndex = temp;
            }

            // Bounds check
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            else if (startIndex > textsList.Count - 1)
            {
                startIndex = textsList.Count - 1;
            }
            if (endIndex < 0)
            {
                endIndex = 0;
            }
            else if (endIndex > textsList.Count - 1)
            {
                endIndex = textsList.Count - 1;
            }
        }

        private static void CheckPartitions(ref int partitions)
        {
            const int minPartitions = 0;
            const int maxPartitions = 100;

            if (partitions < minPartitions)
            {
                partitions = minPartitions;
            }
            else if (partitions > maxPartitions)
            {
                partitions = maxPartitions;
            }
        }

        private static void MergeText(List<string> textsList, int startIndex, int endIndex)
        {
            StringBuilder concatenateText = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                concatenateText.Append(textsList[i]);
            }

            for (int i = endIndex; i >= startIndex; i--)
            {
                textsList.RemoveAt(i);
            }

            textsList.Insert(startIndex, concatenateText.ToString());
        }

        private static void DivideText(List<string> textsList, int index, int partitions)
        {
            string textToDivide = textsList[index];
            int partLength = (int)Math.Ceiling((double)textToDivide.Length / partitions);

            List<string> dividedParts = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions - 1)
                {
                    dividedParts.Add(textToDivide.Substring(i * partLength));
                }
                else
                {
                    dividedParts.Add(textToDivide.Substring(i * partLength, partLength));
                }
            }

            textsList.RemoveAt(index);
            textsList.InsertRange(index, dividedParts);
        }
}
