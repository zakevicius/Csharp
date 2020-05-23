using System;

namespace First
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