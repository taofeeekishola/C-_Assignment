using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    public static class NumberThree
    {
        //function to display the number likes
        public static void FacebookLikes()
        {

            List<string> names = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name or press Enter to stop");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                names.Add(input);
            }


            if (names.Count == 1)
            {
                foreach (string name in names)
                {
                    Console.WriteLine($"{name} likes your post");
                }
            }
            else if (names.Count == 2)
            {

                Console.WriteLine($"{names[0]} and {names[1]} like your post");

            }
            else if (names.Count > 2)
            {

                Console.WriteLine($"{names[0]} and {names[1]} and {names.Count - 2} others like your post");

            }


        }

        //function to reverse name
        public static void ReverseName()
        {
            Console.WriteLine("Enter your name");
            char[] name = Console.ReadLine().ToCharArray();

            List<char> reversenName = new List<char>();

            for (int i = name.Length - 1; i >= 0; i--)
            {
                reversenName.Add(name[i]);
            }

            string newName = new string(reversenName.ToArray());

            Console.WriteLine(newName);
        }

        //function to stor unique numbers 
        public static void SortUniqueNumbers()
        {
            Console.WriteLine("Enter 5 unique numbers");

            List<int> uniqeNumbers = new List<int>();


            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter a number");
                int input = int.Parse(Console.ReadLine());

                if (uniqeNumbers.Contains(input))
                {
                    Console.WriteLine("Number already exists, Try again.");
                    i--;
                }
                else
                {
                    uniqeNumbers.Add(input);
                }
            }
            int[] sorted = uniqeNumbers.ToArray();
            Array.Sort(sorted);
            Console.WriteLine(string.Join(", ", sorted));

        }

        //function to take in numbers and display only unique numbers
        public static void Numbers()
        {

            List<int> allNumbers = new List<int>();

            string num = " ";

            while (num != "okay")
            {
                Console.WriteLine("Enter a number");
                num = Console.ReadLine();

                if (num.ToLower() == "okay")
                {
                    break;
                }

                allNumbers.Add(Convert.ToInt32(num));
            }

            HashSet<int> uniqueNumbers = new HashSet<int>(allNumbers);

            Console.WriteLine(string.Join(", ", uniqueNumbers));
        }

        //function to get the 3 smallest number from a list
        public static void NumberList()
        {
            Console.WriteLine("Enter numbers");

            string[] numbers;

            do
            {
                numbers = Console.ReadLine().Split(",").ToArray();

                if (numbers.Length < 5)
                {
                    Console.WriteLine("Invalid List");
                    Console.WriteLine("Try again");

                }

            } while (numbers.Length < 5);

            Array.Sort(numbers);

            Console.WriteLine(string.Join(", ", numbers.Take(3)));

        }
    }
}
