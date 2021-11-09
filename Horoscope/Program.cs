using System;
using System.IO;


namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your horoscope sigh");
            string usersigh = Console.ReadLine();

            Console.WriteLine(GetHoroscope(usersigh));
        }


        public static string[] ReadHoroScope()
        {
            string filePath = @"C:\Users\opilane\Samples\horoscope.txt";
            string[] dataFormFile = File.ReadAllLines(filePath);                      
           return dataFormFile;
        }

        public static string GetHoroscope(string userInput)
        {
            string[] horoscope = ReadHoroScope();
            string todayHoroscope = "";

            foreach(string elements in horoscope)
            {
                if (elements.Contains(userInput))
                {
                    todayHoroscope = elements;
                }
                
            }
            return todayHoroscope;
        }
    }
}
