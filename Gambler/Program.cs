using System;

namespace Gambler
{
    class Program
    {
        static void Main(string[] args)
        {
            Gambling gambler = new Gambling();

            Console.WriteLine("Wlecome to the Gambler game!");
            Console.WriteLine("Enter No of Stakes:");
            int stake = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Goal:");
            int goal = Convert.ToInt32(Console.ReadLine());
            gambler.GamblingLogic(stake,goal);

        }
    }
}
