using System;

/*
Write a program and ask the user to enter a series of numbers separated by comma. 
Find the maximum of the numbers and display it on the console. 
For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
*/

namespace Learn.Loops
{
    class MaxFinderPlus
    {
        public static void Init()
        {
            int max = 0;

            Console.WriteLine("Enter the numbers separated by comma");
            
            foreach (char item in Console.ReadLine())
            {
                int num = (int) char.GetNumericValue(item);
                if (num == -1) continue;
                max = Math.Max(max, num);
            }

            Console.WriteLine(max);
        }
    }
}
