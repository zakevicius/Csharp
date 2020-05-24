using System;
using System.Collections.Generic;

/*
Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
otherwise, display the 3 smallest numbers in the list.
 */

namespace Learn.Lists
{
    class ListThreeSmallestNumbersInStringOfFive
    {
        public static void Init()
        {
            while (true) {
                Console.WriteLine("Enter 5 or more numbers separated by comma:");
                string query = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(query))
                {
                    Console.WriteLine("this Invalid List");
                    continue;
                }

                int l = (query.Split(',')[^1] == "") ? query.Split(',').Length - 1 : query.Split(',').Length;

                List<int> numbers = new List<int>(l);

                for (int i = 0; i < numbers.Capacity; i++) 
                {
                    int n;
                    bool isNum = Int32.TryParse(Convert.ToString(query.Split(',')[i]).Trim(), out n);

                    if (isNum) numbers.Add(n);
                }

                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List");
                    continue;
                }

                numbers.Sort();

                Console.WriteLine($"3 smallest numbers are {numbers[0]}, {numbers[1]} and {numbers[2]}.");
                break;
            }
        }
    }
}
