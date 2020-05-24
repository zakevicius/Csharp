using System;

/*
Write a program and ask the user to enter a number. 
Compute the factorial of the number and print it on the console. 
For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
*/

namespace Learn.Loops
{
    class Factorial
    {
        public static void Init(int n)
        {
            int f = 1;
            for (int i = n; i > 1; i--)
            {
                f *= i;
            }

            Console.WriteLine(f);
        }
    }
}
