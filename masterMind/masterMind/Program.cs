using System;


namespace masterMind
{
    class primaryClass
    {
        // static string[] hint = new["hint"];
        // string[][] board = ("board");
        //static string[] secret = new string[] { "Red", "Yellow", "Blue" };
        // static string[] colors = new colorArray
    }

    public static void Main(string[] args)
    {

        // static string[] hint = new["hint"];
        string[][] board = ("board");
        string[] secret = new string[] { "Red", "Yellow", "Blue" };
         static string[] colorArray = new (string,2);
        

        Console.WriteLine("Welcome to Mastermind!");
        Random rnd = new Random();
        for (int i = 0; i < 2; i++)
        {
            secret[i] = colorArray[rnd.Next(0, 2)];
        }


        //Ask user for input
        Console.WriteLine("Enter your guess");
        string[] guess = Console.ReadLine().Split(' ');

        if (guess[0] == secret[0] && guess[1] == secret[1])
        {
            Console.WriteLine("You won!");
        }
        else
        {



            int correctColorCount = 0;
            int correctPositionCount = 0;
            if (secret.Contains(guess[0]))
            {
                correctColorCount++;
            }
            if (secret.Contains(guess[1])) ;
            {
                correctColorCount++;
            }

            for (int i = 0; i < 2; i++)
            {
                if (secret.Contains(guess[i]))
                {
                    correctColorCount++;
                }
            }
            if (guess[0] == secret[0])
            {
                correctPositionCount++;
            }
            if (guess[1] == secret[1])
            {
                correctPositionCount++;
            }

            for (int i = 0; i < 2; i++)
            {
                if (guess[i] == secret[i])
                {
                    correctPositionCount++;
                }
            }

            Console.WriteLine("Your hint is " + correctColorCount + "-" + correctPositionCount);
        }
    } }
    //public bool IsCorrectAnswer(string[] userGuess);


/*using System;

namespace Mastermind
{
    class Program
    {
        //possible letters in code
        public static char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

        //size of code
        public static int codeSize = 4;

        // number of allowd attempts to crack the code
        public static int allowedAttempts = 10;

        // number of tried guesses
        public static int numTry = 0;

        // test solution
        public static char[] solution = new char[] { 'a', 'b', 'c', 'd' };

        //game board
        public static string[][] board = new string[allowedAttempts][];

        public static void Main()
        {
            char[] guess = new char[4];

            createBoard();
            DrawBoard();
            Console.WriteLine("Enter Guess");
            guess = Console.ReadLine().ToCharArray;

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static bool CheckSolution(char[] guess)
        {
            //.WriteLine("Enter your guess");
            while (true)
            {
                if (guess == solution)
                {
                    Console.WriteLine("you win!");
                }
                else
                {
                    Console.WriteLine("try again");
                }
            }      
        }

        public static string GenerateHint(char[] guess)
        {
            if (CheckSolution == false) ;
            {
                Console.WriteLine("Try this");
                if checkSolution 
            }
            
            return " ";
        }
    }
}
*/