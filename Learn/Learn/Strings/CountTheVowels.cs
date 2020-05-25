using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Write a program and ask the user to enter an English word.
Count the number of vowels (a, e, o, u, i) in the word. 
So, if the user enters "inadequate", the program should display 6 on the console.
*/

namespace Learn.Strings
{
    class CountTheVowels
    {
        public static void Init()
        {
            Console.WriteLine("Enter an English word:");
            Console.WriteLine(Count(Console.ReadLine()));
        }

        private static int Count(string word)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;

            foreach (char letter in word)
            {
                if (vowels.Contains(letter)) count++;
            }

            return count;
        }
    }
}
