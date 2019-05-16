using System;

namespace TicTacToe
{
    class Program
    { 
       

        static string currentPlayer = " ";
        const int BoardSize = 3;
        static string[,] board = new string[BoardSize, BoardSize] { { "", "", "" },{ "", "", "" },{ "", "", "" } };
        static int TotalMoves = 0;
        static bool gameOver = false;



        public static void Main(string[] args)
        {
        
            printBoard();
        }


        #region PrintBoard
        public static void printBoard()
        {
            for (int i = 0; i < BoardSize; i++)
            {
                Console.WriteLine("-------");
                for (int j = 0; j < BoardSize; j++)
                {
                    Console.Write("| " + board[i, j].ToString());

                }
                Console.WriteLine("| ");
            }
            Console.WriteLine("-------");

        }
        #endregion
    }

}
