using System;
using System.Collections.Generic;
using System.Text;

namespace First
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
