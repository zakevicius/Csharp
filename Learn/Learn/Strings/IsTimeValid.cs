using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

/*
Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
A valid time should be between 00:00 and 23:59. 
If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
If the user doesn't provide any values, consider it as invalid time.
*/

namespace Learn.Strings
{
    class IsTimeValid
    {
        public static void Init()
        {
            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00):");
            string[] formats = new string[] { "H:mm" };
            Console.WriteLine(CheckIfValid(Console.ReadLine(), formats));
        }

        private static string CheckIfValid(string time, string[] formats)
        {
            string valid = "Invalid Time";
            if (string.IsNullOrWhiteSpace(time)) return valid;

            DateTime date;

            if (DateTime.TryParseExact(time, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out date)) valid = "Ok";

            return valid;
        }
    }
}
