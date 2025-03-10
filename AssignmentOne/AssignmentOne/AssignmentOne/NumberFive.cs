using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    public static class NumberFive
    {
        //function to read from a file and count all the words
        public static void ReadFromFile()
        {
            string path = "C:\\Users\\taofe\\OneDrive\\Documents\\OptimusBank\\C#\\Assignments\\AssignmentOne\\AssignmentOne\\AssignmentOne\\file.txt";
            string words = File.ReadAllText(path);
            string[] word = words.Split(" ");

            Console.WriteLine(word.Length);
        }

        //function to find the longest word in a file
        public static void LongestWordInFile()
        {
            string path = "C:\\Users\\taofe\\OneDrive\\Documents\\OptimusBank\\C#\\Assignments\\AssignmentOne\\AssignmentOne\\AssignmentOne\\file.txt";
            string words = File.ReadAllText(path);
            string[] word = words.Split(" ");

            string longestWord = " ";

            foreach (string w in word)
            {
                if (w.Length > longestWord.Length)
                {
                    longestWord = w;
                }
            }

            Console.WriteLine($"The longest word is {longestWord}");
        }
    }
}
