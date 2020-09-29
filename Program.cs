using System;

namespace Snake_And_Ladders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Virtual Snake & Ladders!!");

            var positionOfPlayer1 = 0;

            while (positionOfPlayer1 == 100)
            {

                var NumRoll = RollTheDie();


                SnakeOrLadder(ref positionOfPlayer1, NumRoll);

                
                
            }
            
            
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
                    
                    break;

                default:
                        break;
            }
        }
    }
}
