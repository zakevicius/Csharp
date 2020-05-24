using System;

/*
Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, 
sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. 
Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, 
program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. 
For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
If the number of demerit points is above 12, the program should display License Suspended.
*/

namespace Learn.Conditionals
{
    class SpeedCamera
    {
        private static void CalculateSpeed(int limit, int speed)
        {
            if (speed <= limit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                int demeritPoints = (int) Math.Ceiling((double) (speed - limit) / 5);
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine(string.Format("You receive {0} demerit points for exceeding the speed limit by {1}", demeritPoints, speed - limit));
                }
            }
        }

        public static void Init()
        {
            Console.WriteLine("Enter speed limit");
            int limit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter speed of a car");
            int speed = int.Parse(Console.ReadLine());

            CalculateSpeed(limit, speed);

        }
    }
}
