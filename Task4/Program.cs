using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your birthday:");

            string sDate = Console.ReadLine();

            DateTime date;
            date = DateTime.Parse(sDate);

            int Years = DateTime.Now.Year - date.Year;
            
            date = date.AddYears(Years);
            if (DateTime.Now > date)
            {
                date = date.AddYears(1);
            }
            TimeSpan dateTemp = date - DateTime.Now;

            Console.WriteLine((int)dateTemp.TotalDays);
        }
    }
}
