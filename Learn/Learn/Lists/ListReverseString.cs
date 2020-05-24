using System;
using System.Collections.Generic;

/*
Write a program and ask the user to enter their name. 
Use an array to reverse the name and then store the result in a new string. 
Display the reversed name on the console.
*/

namespace Learn.Lists
{
    class ListReverseString
    {
        public static void Init()
        {
            string word = "";

            while (string.IsNullOrWhiteSpace(word))
            {
                Console.WriteLine("Enter a word:");
                word = Console.ReadLine();
            }

            List<char> arr = new List<char>();
            arr.AddRange(word);

            for (int i = 0; i < arr.Count / 2; i++)
            {
                char temp = arr[i];
                arr[i] = arr[^(i + 1)];
                arr[^(i + 1)] = temp;
            }

            Console.WriteLine(string.Join("", arr));
        }
    }
}
