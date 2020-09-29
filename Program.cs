using System;

namespace Snake_And_Ladders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Virtual Snake & Ladders!!");

            var positionOfPlayer1 = 0;
            var positionOfPlayer2 = 0;

            var NumberOfROlls = 0;

            while (positionOfPlayer1 < 100 || positionOfPlayer2<100)
            {

                var NumRoll = RollTheDie();
                NumberOfROlls++;

                SnakeOrLadder(ref positionOfPlayer1, NumRoll);

                Console.WriteLine("Position of player 1 : " + positionOfPlayer1);
                if (positionOfPlayer1==100)
                    break;

                NumRoll = RollTheDie();
                NumberOfROlls++;

                SnakeOrLadder(ref positionOfPlayer2, NumRoll);

                
                Console.WriteLine("Position of player 2 : " + positionOfPlayer2);
                if (positionOfPlayer2 == 100)
                    break;
            }
            Console.WriteLine(NumberOfROlls);
            if (positionOfPlayer1 == 100)
                Console.WriteLine("Player 1 Won the Game!");
            else
                Console.WriteLine("Player 2 Won the Game!");
        }

        public static int RollTheDie()
        {
            return new Random().Next(1, 7);
        }
        public static void SnakeOrLadder(ref int positionOfPlayer,int NumRoll)
        {
            string[] options = new string[] { "No Play", "Snake", "Ladder" };
            var option = options[new Random().Next(0, 3)];
            switch (option)
            {
                case "Snake":
                    positionOfPlayer -= NumRoll;
                    if (positionOfPlayer < 0)
                        positionOfPlayer = 0;
                    break;
                case "Ladder":
                    positionOfPlayer += NumRoll;
                    if (positionOfPlayer > 100)
                        positionOfPlayer -= NumRoll;
                    NumRoll = RollTheDie();
                    SnakeOrLadder(ref positionOfPlayer, NumRoll);
                    break;

                default:
                        break;
            }
        }
    }
}
