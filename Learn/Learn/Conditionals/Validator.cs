using System;

/*
Write a program and ask the user to enter a number. The number should be between 1 to 10. 
If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". 
(This logic is used a lot in applications where values entered into input boxes need to be validated.)
*/

namespace Learn.Conditionals
{
    class Validator
    {
        private static string ValidateNumber(int n)
        {
            return (n > 0 && n <= 10) ? "Valid" : "Invalid";
        }

        public static void Validate(string s)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ValidateNumber(n));
        }
    }
}