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
            int POSITION = 0;
            //Dice logic
            Random random = new Random();
            int dice = random.Next(1, 7);

        }
    }
}
