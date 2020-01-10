using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static Train[] trains = new Train[8];

        static void Main(string[] args)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.Write("Enter destination:");
                string destination = Console.ReadLine();

                Console.Write("Enter number:");
                string num = Console.ReadLine();
                int number = Convert.ToInt32(num);

                Console.Write("Enter departure time:");
                string date = Console.ReadLine();
                DateTime departureTime = string.IsNullOrEmpty(date) ? DateTime.Now : DateTime.Parse(date);

                trains[i] = new Train(destination, number, departureTime); 
            }


            Console.WriteLine(new String('+', 20));
            Show(trains);
            Console.WriteLine(new String('+', 20));
            Sort(trains);
            Console.WriteLine(new String('+', 20));
            Show(trains);
            Console.WriteLine(new String('+', 20));

            while (true)
            {
                Console.Write("Enter number:");
                string num = Console.ReadLine();
                int number = Convert.ToInt32(num);
                Search(number);
            }

        }


        public static void Sort(Train[] trains)
        {
            Program.trains = trains.OrderBy(x => x.number).ToArray<Train>();
        
        }

        public static void Show(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"destination:{trains[i].destination}; number:{trains[i].number}; departureTime:{trains[i].departureTime}");
            }
        }

        public static void Search(double number)
        {
            try
            {
                Train train = Program.trains.First(x => x.number == number);
                Console.WriteLine(train);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }


    public struct Train
    {
        public string destination;
        public int number;
        public DateTime departureTime;

        public Train(string destination, int number, DateTime departureTime) 
        {
            this.destination = destination;
            this.number = number;
            this.departureTime = departureTime;
        }

        public override string ToString()
        {
            return $"destination - {destination}; number - {number}; departureTime - {departureTime}";
        }

    }
}
