using System;


namespace First
{
    class MaxFinder
    {
        public static int FindMax(int a, int b)
        {
            return Math.Max(a, b);
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
