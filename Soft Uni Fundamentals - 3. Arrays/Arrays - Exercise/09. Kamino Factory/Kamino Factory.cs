﻿using System;
using System.Linq;

class KaminoFactory
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());

            int[] bestDNA = FindBestDNA(length);

            Console.WriteLine($"Best DNA sample {bestDNA[0]} with sum: {bestDNA[1]}.");
            Console.WriteLine(string.Join(" ", bestDNA.Skip(2)));
        }

        static int[] FindBestDNA(int length)
        {
            int longestSubsequence = -1;
            int[] bestDNA = new int[length];
            int longestIndex = -1;
            int biggestSum = -1;

            int row = 0;
            int bestRow = 0;

            string command = Console.ReadLine();

            while (command != "Clone them!")
            {
                int[] currentDNA = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int counter = 0;
                int subsequence = -1;
                int index = -1;
                int sum = 0;

                row++;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        counter++;
                        sum++;
                        if (counter > subsequence)
                        { subsequence = counter; index = i;}
                    }
                    else
                    { counter = 0; }
                }

                if (subsequence > longestSubsequence)
                {
                    longestSubsequence = subsequence;
                    bestDNA = currentDNA;
                    longestIndex = index;
                    biggestSum = sum;
                    bestRow = row;
                }
                else if (subsequence == longestSubsequence && index < longestIndex)
                {
                    longestSubsequence = subsequence;
                    bestDNA = currentDNA;
                    longestIndex = index;
                    biggestSum = sum;
                    bestRow = row;
                }
                else if (subsequence == longestSubsequence && index == longestIndex && biggestSum < sum)
                {
                    longestSubsequence = subsequence;
                    bestDNA = currentDNA;
                    longestIndex = index;
                    biggestSum = sum;
                    bestRow = row;
                }

                command = Console.ReadLine();
            }

            int[] result = new int[length + 2];
            result[0] = bestRow;
            result[1] = biggestSum;
            Array.Copy(bestDNA, 0, result, 2, length);

            return result;
        }
    }
