using System;
namespace TicTacToe
{
    class Program
    {
        public static void Main(string[] args)
        {
            char player = 'X';
            char[,] board = new char[3, 3];
            Initialize(board);
            int movesPlayed = 0;
            //board[0, 0] = player;
            //player = 'O';
            //board[2, 2] = player;
            //player = 'X';

            while (true)
            {

                Console.Clear();
                Print(board);

                Console.Write("Please enter row; ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter a col: ");
                int col = Convert.ToInt32(Console.ReadLine());

                board[row, col] = player;

                //Check if won:
                if (player == board[0,0] && player == board[0,1] && player == board[0, 2])
                {
                    Console.WriteLine(player + " has won the game!");
                    break;


                }

                movesPlayed = movesPlayed + 1;

                if (movesPlayed == 9)
                {
                    Console.WriteLine("DRAW");
                    break;
                }

                player = ChangeTurn(player);

                // clebration for winner.
                //clear the screen
                // mention who won or if it was  a draw
            }
        }


        static char ChangeTurn(char currentPlayer)
        {
            if (currentPlayer == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }

        static void Initialize(char[,] board)
        {
           // char[,] board = new char[3, 3];

            //initializing board
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }

           
        }
        static void Print(char[,] board)
        {
            Console.WriteLine("  | 0 | 1 | 2 |  ");
            for (int row = 0; row < 3; row++)
            {
                Console.Write( row + "| ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");

                }
                Console.WriteLine();
        }

    
            }

      /* static void Print(char[, ] board)
        {
            for (int row = 0; row < 3; row++)
            {
                Console.Write("| ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" |");
                }
                Console.WriteLine();
            }
        }
        */
    }
}