using System;

/*
Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
Display the count on the console.
*/

namespace Learn.Loops
{
    class DivisibleByThree
    {
        public static void CountDivisibleByThree(int n)
        {
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0) count++;
            }

            Console.WriteLine(count);
        }
    }
}
