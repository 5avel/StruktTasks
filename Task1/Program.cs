using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook book = new Notebook("ProBook", "HP", 15000);


            Console.WriteLine(book);
        }
    }


    public struct Notebook
    {
        string model;
        string manufacturer;
        Double price;

        public Notebook(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Model - {model}; manufacturer - {manufacturer}; price - {price}";
        }
    }
}
