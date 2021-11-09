using System;
using System.IO;
namespace Colours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Favorite Color");
            string usersigh = Console.ReadLine();

            Console.WriteLine(GetColors(usersigh));
        }
        public static string[] ReadColors()
        {
            string filePath = @"C:\Users\opilane\Samples\personality.txt";
            string[] dataFormFile = File.ReadAllLines(filePath);
            return dataFormFile;
        }
        public static string GetColors(string userInput)
        {
            string[] Colors = ReadColors();
            string todayColors = "";

            foreach (string elements in Colors)
            {
                if (elements.Contains(userInput))
                {
                    todayColors = elements;
                }

            }
            return todayColors;

        }
    }
}
