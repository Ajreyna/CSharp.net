
  using System;


namespace masterMind
{
    class program
    {
        
        static int[] hint;
        static int tryCount;
        string[][] board;
        const int allowedAttempsts = 4;
        static string[] secret = new string[codeLength];
        static string[] colorArray = new string[] { "Red", "Yellow", "Blue" };
        static bool gameOver = false;


        static void Main(string[] args)
        {
            //Generate Random Secret
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                secret[i] = colorArray[rnd.Next(0, 2)];

            }
            while (gameOver == false)
            {
                // ask user for input
                Console.WriteLine("Enter your guess:");
                string[] guess = Console.ReadLine().Split(' ');
                gameOver = isCorrectAnswer(guess);
            }
        }
        public static bool IsCorrectAnswer(string[] userGuess)
        {

        }
    }