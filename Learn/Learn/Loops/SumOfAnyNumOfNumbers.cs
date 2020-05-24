using System;

/*
Write a program and continuously ask the user to enter a number or "ok" to exit. 
Calculate the sum of all the previously entered numbers and display it on the console.
*/

namespace Learn.Loops
{
    class SumOfAnyNumOfNumbers
    {
        public static void Init()
        {
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number or \"OK\" to count");

                string value = Console.ReadLine();

                if (value == "OK")
                {
                    break;
                }

                sum += Convert.ToInt32(value);
            }

            Console.WriteLine(sum);
        }
    }
}
