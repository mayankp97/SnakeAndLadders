using System;

namespace Snake_And_Ladders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Virtual Snake & Ladders!!");

            var positionPlayer1 = 0;

            var NumRoll = RollTheDie();
        }

        public static int RollTheDie()
        {
            return new Random().Next(1, 7);
        }
    }
}
