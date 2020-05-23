using System;
using System.Collections.Generic;
using System.Text;

namespace Learn
{
    class GuessTheNumber
    {
        public static void Init()
        {
            Random numRandom = new Random();
            int num = numRandom.Next(1, 10);
            bool isCorrect = false;
            int numberOfGuesses = 4;
            int counter = 0;

            while (counter++ < numberOfGuesses)
            {
                Console.WriteLine($"Enter your guess between 1 and 10. Your {counter} guess ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == num)
                {
                    isCorrect = true;
                    break;
                }
            }

            Console.WriteLine((isCorrect) ? $"You are correct. Number is {num}" : $"Sorry, the number is {num}");

        }
    }
}
