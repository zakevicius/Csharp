using System;

/*
Write a program and ask the user to enter their name. 
Use an array to reverse the name and then store the result in a new string. 
Display the reversed name on the console.
*/

namespace Learn.Arrays
{
    class ReverseString
    {
        public static void Init()
        {
            string word = "";

            while (string.IsNullOrWhiteSpace(word))
            {
                Console.WriteLine("Enter a word:");
                word = Console.ReadLine();
            }

            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(new string(arr));
        }
    }
}
