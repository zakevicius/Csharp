using System;
using System.Linq;

/*
Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
The list of numbers may include duplicates. Display the unique numbers that the user has entered.
*/

namespace Learn.Arrays
{
    class UniqueNumbersInArray
    {
        public static void Init()
        {
            int[] numbers = new int[0];
            int[] unique = new int[0];

            while (true)
            {
                Console.WriteLine("Enter a number or type \"QUIT\" to quit:");
                string value = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(value)) continue;

                if (value.ToLower() == "quit") break;

                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[^1] = Convert.ToInt32(value);
            }

            foreach (int number in numbers)
            {
                if (unique.Contains(number))
                {
                    continue;
                }
                Array.Resize(ref unique, unique.Length + 1);
                unique[^1] = number;
            }

            Console.WriteLine(string.Join(" ", unique));
        }
    }
}
