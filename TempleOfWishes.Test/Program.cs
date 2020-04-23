using System;

namespace TempleOfWishes.Test
{
    class Program
    {
        static GameManager manager = new GameManager();

        static void Main(string[] args)
        {
            manager.Hero.SetLogger(new ConsoleLogger());
            

            while(true)
            {
                Console.Write("Please enter command: ");
                manager.Play(Console.ReadLine());
            }
        }
    }
}
