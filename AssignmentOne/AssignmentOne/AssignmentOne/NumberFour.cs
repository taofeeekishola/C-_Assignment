using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    public static class NumberFour
    {
        //function to check if inputed numbers are consecutive
        public static void ConsecutiveNumbers()
        {
            Console.WriteLine("Enter numbers seperated by -");

            string[] numbers = Console.ReadLine().Split("-");

            int[] num = numbers.Select(int.Parse).ToArray();
            bool consecutive = true;

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] != num[i - 1] + 1)
                {
                    consecutive = false;
                    break;
                }
            }

            Console.WriteLine(consecutive ? "The numbers are consecutive" : "The numbers are not consecutive");



        }


        //checking to see if there are duplicates in a list of numbers
        public static void DuplicateNumbers()
        {
            Console.WriteLine("Enter numbers seperated by -");

            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            string[] numbers = input.Split("-");

            if (numbers.Length > 0)
            {

                int[] num = numbers.Select(int.Parse).ToArray();

                HashSet<int> uniqueNumbers = new HashSet<int>();

                foreach (int n in num)
                {
                    if (uniqueNumbers.Add(n) == false)
                    {
                        Console.WriteLine("Duplicate");
                        return;
                    }
                }
            }



        }

        //function to check validity of time format
        public static void ValidTimeFormat()
        {
            Console.WriteLine("Enter a valid time format");
            string input = Console.ReadLine();

            TimeSpan startTime = TimeSpan.Parse("00:00");
            TimeSpan endTime = TimeSpan.Parse("23:59");



            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            TimeSpan userTime = TimeSpan.Parse(input);

            if (startTime < userTime && userTime < endTime)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }

        //function to turn string to PascalCase
        public static void PascalCase()
        {
            Console.WriteLine("Enter words");

            string input = Console.ReadLine();

            string[] words = input.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }

            Console.WriteLine(string.Join("", words));
        }

        //function to count the number of vowels in a word
        public static void CountVowels()
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine("Enter a word");
            string input = Console.ReadLine();

            char[] words = input.ToCharArray();
            int count = 0;
            foreach (char word in words)
            {
                if (vowels.Contains(word))
                {
                    count += 1;
                }
            }

            Console.WriteLine(count);

        }
    }
}
