using System;
using System.Collections.Generic;
using System.Text;

/*
Write a program and ask the user to enter a few numbers separated by a hyphen. 
If the user simply presses Enter, without supplying an input, exit immediately; 
otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
*/

namespace Learn.Strings
{
    class AreThereDuplicates
    {
        public static void Init()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen:");
            string query = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(query)) return;
            Console.WriteLine(CheckForDuplicates(query, '-'));
        }

        private static string CheckForDuplicates(string query, char separator)
        {
            bool result = false;
            string[] arr = query.Split(separator);

            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    result = true;
                    break;
                }
            }
            
            return (result) ? "Duplicate" : null ;
        }
    }
}
