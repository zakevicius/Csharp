using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Write a program and ask the user to enter a few words separated by a space. 
Use the words to create a variable name with PascalCase. 
For example, if the user types: "number of students", display "NumberOfStudents". 
Make sure that the program is not dependent on the input. 
So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
*/

namespace Learn.Strings
{
    class ChangeToPascalCase
    {
        public static void Init()
        {
            Console.WriteLine("Enter a few words separated by a space:");
            Console.WriteLine(ChangeToPascal(Console.ReadLine()));
        }

        private static string ChangeToPascal(string query)
        {
            string[] arr = query.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = string.Concat(arr[i].Substring(0, 1).ToUpper(), arr[i].Substring(1).ToLower());
            }

            return string.Join("", arr);
        }
    }
}
