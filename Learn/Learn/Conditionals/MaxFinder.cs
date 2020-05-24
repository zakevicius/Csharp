using System;

/*
Write a program which takes two numbers from the console and displays the maximum of the two.
*/


namespace Learn.Conditionals
{
    class MaxFinder
    {
        public static int FindMax(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public static void MaxFind()
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(FindMax(a, b));
        }
    }
}
