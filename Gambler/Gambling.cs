using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler
{
    class Gambling
    {
        Random random = new Random();
        private readonly int WIN = 1;
        private readonly int BET = 1;

        public int RandomNumberGenerator()
        {           
                return random.Next(0, 2);                                
        }
        public void GamblingLogic(int stake, int goal)
        {
            int winningCount = 0, LosingCount = 0;
            while (stake < goal && stake > 0)
            {
                int winLose = RandomNumberGenerator();
                if (winLose == WIN)
                {
                    stake += BET;
                    winningCount++;
                }
                else
                {
                    stake -= BET;
                    LosingCount++;
                }
            }
            double percentageWin = (winningCount*100 / (winningCount+LosingCount));
            double percentageLose = (LosingCount*100 / (winningCount+LosingCount));
            Console.WriteLine("Winning percent  is " + percentageWin);
            Console.WriteLine("Losing percent  is " + percentageLose);
         }
    }
}
