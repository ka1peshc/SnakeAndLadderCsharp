using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake ladder program.");
            //Constant 
            int START = 0;
            const int NOPLAY = 1;
            const int SNAKE = 2;
            const int LADDER = 3;
            int position = 0;
            //Dice logic
            Random random = new Random();
            int dice = random.Next(1, 7);
            int option = random.Next(1, 4);

            switch (option)
            {
                case NOPLAY:
                    position += 0;
                    break;
                case SNAKE:
                    position += dice;
                    break;
                case LADDER:
                    position -= dice;
                    break;
            }
        }
    }
}
