using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    public static class NumberOne
    {
        //function to validate numbers betwen 1-10
        public static void ValidNumber()
        {
            Console.WriteLine("Enter a number between 1-10");
            int num = int.Parse(Console.ReadLine());

            if (1 <= num && num <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }


        }

        //function to display max of two numbers
        public static void MaxOfTwoNUmbers()
        {
            Console.WriteLine("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }

        }

        //function to determine the oritentation of an image
        public static void ImageOrientation()
        {

            Console.WriteLine("Enter width of image: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter height of image: ");
            int height = int.Parse(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("The image has a Lanscape orientation");
            }
            else
            {
                Console.WriteLine("The image has a Portrait orientation");
            }
        }

        //function to determine punishment for speed limit
        public static void SpeedLimit()
        {
            const int speedLimit = 50;

            Console.WriteLine("Enter the vehicle speed");
            int speed = int.Parse(Console.ReadLine());

            if (speed < speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                int aboveSpeedLimit = speed - speedLimit;
                int demeritPoints = aboveSpeedLimit / 5;

                if (demeritPoints < 12)
                {
                    Console.WriteLine("You have incurred: " + demeritPoints + " points");
                }
                else
                {
                    Console.WriteLine("License Suspended");
                }

            }
        }
    }
}
