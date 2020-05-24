using System;
using System.Collections.Generic;
using System.Linq;

/*
Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
The list of numbers may include duplicates. Display the unique numbers that the user has entered.
*/

namespace Learn.Lists
{
    class ListUniqueNumbersInArray
    {
        public static void Init()
        {
            List<int> numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or type \"QUIT\" to quit:");
                string value = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(value)) continue;

                if (value.ToLower() == "quit") break;

                if (!numbers.Contains(Convert.ToInt32(value))) 
                {
                    numbers.Add(Convert.ToInt32(value));
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
