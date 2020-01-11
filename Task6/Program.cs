using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Accauntant ac = new Accauntant();
            Console.WriteLine($"Post.Manager, 100 {ac.AskForBonus(Post.Manager, 100)}");
            Console.WriteLine($"Post.Manager, 200 {ac.AskForBonus(Post.Manager, 200)}");
            Console.WriteLine($"Post.Cleaner, 80 {ac.AskForBonus(Post.Cleaner, 80)}");
            Console.WriteLine($"Post.Cleaner, 100 {ac.AskForBonus(Post.Cleaner, 100)}");
            Console.WriteLine($"Post.Developer, 100 {ac.AskForBonus(Post.Developer, 100)}");
            Console.WriteLine($"Post.Developer, 200 {ac.AskForBonus(Post.Developer, 200)}");
        }
    }
}
