using System;

namespace Solutions.Task_8
{
    public class Randomizer
    {
        private static Random Random { get; } = new Random();
        
        public static bool IsHappened(double probability)
        {
            return Random.Next(1000) < Math.Round(1000 * probability);
        }

        public static int GetRandomInt(int finish)
        {
            return Random.Next(0, finish-1);
        }

        public static int GetRandomInt(int begin, int finish)
        {
            return Random.Next(begin, finish);
        }
    }
}