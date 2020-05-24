using System;
using System.Collections.Generic;

/*
Write a program and ask the user to enter 5 numbers. 
If a number has been previously entered, display an error message and ask the user to re-try. 
Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
*/
namespace Learn.Lists
{
    class ListSortFiveUniqueNumbers
    {
        public static void Init()
        {
            List<int> numbers = new List<int>();
            int counter = 0;

            while (counter < 5)
            {
                Console.WriteLine("Enter unique number");
                string value = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(value)) continue;
                int num = Convert.ToInt32(value);

                if (numbers.Contains(num))
                {
                    Console.Write("Value already exists. ");
                    continue;
                }

                numbers.Add(num);
                counter++;
            }

            numbers.Sort();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
