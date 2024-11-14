﻿namespace WorldClock.ConApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WorldClock");

            ConsoleClock c1 = new ConsoleClock(0, "Vienna", ConsoleColor.Blue);
            ConsoleClock c2 = new ConsoleClock(-6, "New York", ConsoleColor.Red);
            ConsoleClock c3 = new ConsoleClock(6, "Tokio", ConsoleColor.Cyan);

            Logic.WorldClock.Instance.AddObserver(c1);
            Logic.WorldClock.Instance.AddObserver(c2);
            Logic.WorldClock.Instance.AddObserver(c3);
            Logic.WorldClock.Instance.AddObserver(new BadObserver());

            Console.ReadLine();

            Logic.WorldClock.Instance.RemoveObserver(c1);
            Logic.WorldClock.Instance.RemoveObserver(c2);
            Logic.WorldClock.Instance.RemoveObserver(c3);

        }
    }
}
