using System;

/*
Write a program and ask the user to enter 5 numbers. 
If a number has been previously entered, display an error message and ask the user to re-try. 
Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
*/
namespace Learn.Arrays
{
    class SortFiveUniqueNumbers
    {
        public static void Init()
        {
            int[] numbers = new int[5];
            int counter = 0;

            while (counter < numbers.Length)
            {
                Console.WriteLine("Enter unique number");
                string value = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(value)) continue;
                int num = Convert.ToInt32(value);
                bool contains = false;

                if (num == 0)
                {
                    for (int i = counter; i > 0; i--)
                    {
                        if (numbers[i - 1] == num)
                        {
                            contains = true;
                            break;
                        }
                    }
                } 
                else if (Array.IndexOf(numbers, num) > -1)
                {
                    contains = true;
                }

                if (contains)
                {
                    Console.Write("Value already exists. ");
                    continue;
                }

                numbers[counter] = num;
                counter++;
            }

            Array.Sort(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
