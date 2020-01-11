using System;

namespace Task5
{
    class Program
    {

        public enum Colors
        {
            Black = 0,
            DarkBlue = 1,
            DarkGreen = 2,
            DarkCyan = 3,
            DarkRed = 4,
            DarkMagenta = 5,
            DarkYellow = 6,
            Gray = 7,
            DarkGray = 8,
            Blue = 9,
            Green = 10,
            Cyan = 11,
            Red = 12,
            Magenta = 13,
            Yellow = 14,
            White = 15
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");

            string text = Console.ReadLine();


            Console.WriteLine("Enter color number 0-15:");

            int color = int.Parse(Console.ReadLine()) ;



            Print(text, color);
        }

        static void Print(string text, int color)
        {
            Console.ForegroundColor = (ConsoleColor)(Colors)color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
