using System;
using System.Collections.Generic;
using System.Text;

/*
Write a program and ask the user to enter a few numbers separated by a hyphen. 
Work out if the numbers are consecutive. 
For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
*/

namespace Learn.Strings
{
    class AreNumbersConsecutive
    {
        public static void Init()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen: ");
            Console.WriteLine(CheckIfConsecutive(Console.ReadLine(), '-'));
        }

        private static string CheckIfConsecutive(string query, char separator)
        {
            string[] arr = query.Split(separator);
            bool isAscending = IsAscending(arr);
            bool isDescending = IsDescending(arr);
            return (isAscending || isDescending) ? $"{query} is consecutive" : $"{query} is not consecutive";
        }

        private static bool IsAscending(string[] arr)
        {
            bool result = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (int.Parse(arr[i]) != int.Parse(arr[i + 1]) - 1)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private static bool IsDescending(string[] arr)
        {
            bool result = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (int.Parse(arr[i]) != int.Parse(arr[i + 1]) + 1)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
