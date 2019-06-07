using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class MainClass
    {
        static Dictionary<String, Stack<int>> board = new Dictionary<String, Stack<int>>();
        static bool playingGame = true;
        static int pieces = 3;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Towers of Hanoi!");
            board.Add("a", new Stack<int>());
            board.Add("b", new Stack<int>());
            board.Add("c", new Stack<int> { });
          

            for (int i = pieces; i > 0; i--)
            {
                board["a"].Push(i);
            }

            Console.WriteLine(pieces);

            while (playingGame)
            {
                printGame();
                Console.WriteLine("Enter your move. (a b)");
                String move = Console.ReadLine();
                move.ToUpper();
                String[] moves = move.Split(' ');
                moves[0].ToLower();
                moves[1].ToLower();
                if ((moves[0] != "a" && moves[0] != "b" && moves[0] != "c") || (moves[1] != "a" && moves[1] != "b" && moves[1] != "c"))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    if (!Move(moves[0], moves[1]))
                    {
                        Console.WriteLine("Invalid move!");
                    }
                }
                gameOver();
            }
            printGame();
            Console.WriteLine("You win!");


        }
        public static void printGame()
        {
            Console.WriteLine();
            Console.Write("a: ");
            int[] reverse = new int[board["a"].Count];
            int count = reverse.Length - 1;
            foreach (int itm in board["a"])
            {
                reverse[count] = itm;
                count--;
            }
            for (int i = 0; i < reverse.Length; i++)
            {
                Console.Write(reverse[i] + " ");
            }


            Console.WriteLine();
            Console.Write("b: ");
            int[] reverse2 = new int[board["b"].Count];
            int count2 = reverse2.Length - 1;
            foreach (int itm in board["b"])
            {
                reverse2[count2] = itm;
                count2--;
            }
            for (int i = 0; i < reverse2.Length; i++)
            {
                Console.Write(reverse2[i] + " ");
            }


            int[] reverse3 = new int[board["c"].Count];
            int count3 = reverse3.Length - 1;
            Console.WriteLine();
            Console.Write("c: ");
            foreach (int itm in board["c"])
            {
                reverse3[count3] = itm;
                count3--;
            }
            for (int i = 0; i < reverse3.Length; i++)
            {
                Console.Write(reverse3[i] + " ");
            }
            Console.WriteLine();

        }
        public static void gameOver()
        {

            if (board["c"].Count == pieces)
            {
                playingGame = false;
            }

        }

        public static bool Move(String from, String to)
        {
            if (board[to].Count == 0 || board[from].Peek() < board[to].Peek())
            {
                int item = board[from].Pop();
                board[to].Push(item);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
