using System;
using System.Collections.Generic;
using System.Text;

namespace Learn
{
    class SumOfAnyNumOfNumbers
    {
        public static void Init()
        {
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number or \"OK\" to count");

                string value = Console.ReadLine();

                if (value == "OK")
                {
                    break;
                }

                sum += Convert.ToInt32(value);
            }

            Console.WriteLine(sum);
        }
    }
}
