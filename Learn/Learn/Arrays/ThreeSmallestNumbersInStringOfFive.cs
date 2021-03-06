﻿using System;

/*
Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
otherwise, display the 3 smallest numbers in the list.
 */

namespace Learn.Arrays
{
    class ThreeSmallestNumbersInStringOfFive
    {
        public static void Init()
        {
            while (true)
            {
                Console.WriteLine("Enter 5 or more numbers separated by comma:");
                string query = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(query))
                {
                    Console.WriteLine("Invalid List");
                    continue;
                }

                string[] numbers = query.Split(',');
                bool shouldContinue = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = numbers[i].Trim();
                    if (numbers[i] == "")
                    {
                        shouldContinue = true;
                        break;
                    }
                }

                if (shouldContinue || numbers.Length < 5) 
                {
                    Console.WriteLine("Invalid List");
                    continue;
                }

                Array.Sort(numbers);

                Console.WriteLine($"3 smallest numbers are {numbers[0]}, {numbers[1]} and {numbers[2]}.");
                break;
            }
        }
    }
}
