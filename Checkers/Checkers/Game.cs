using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class Game
    {
        private Board board;
        public Game()
        {
            this.board = new Board();
        }

        public bool CheckForWin()
        {
            return (board.checkers.All(x => x.Team == Color.White) || board.checkers.All(x => x.Team == Color.Black));
        }

        public void Start()
        {
            DrawBoard();
            while (!CheckForWin())
            {
                ///TODO: You need to complete this block
                ///hint: what function should you call here?
                ///

                this.ProcessInput();
            }
            Console.WriteLine("You won!");
            Console.WriteLine("Press any key to exit.");
            Console.Read();
        }

        public bool IsLegalMove(Color player, Position source, Position destination)
        {
            // 1. Both the source position and the destination position 
            // must be integers between 0 and 7
            if (source.Row < 0 || source.Row > 7 || source.Column < 0 || source.Column > 7
                || destination.Row < 0 || destination.Row > 7 || destination.Column < 0
                || destination.Column > 7) return false;

            // 2. The row distance between the destination position and the source position
            // must be larger than 0 AND less than or equal to 2
            int rowDistance = Math.Abs(destination.Row - source.Row);
            int colDistance = Math.Abs(destination.Column - source.Column);

            if (colDistance == 0 || rowDistance == 0) return false;

            if (rowDistance / colDistance != 1) return false;

            if (rowDistance > 2) return false;

            Checker c = board.GetChecker(source);
            if (c == null)  // this is no checker at the source position
            {
                return false;
            }

            c = board.GetChecker(destination);
            if (c != null) // the destination position has been taken
            {
                return false;
            }
            // If we get here, that means the source position has a checker AND the destination position is empty
            // AND destination.Row != source.Row AND destination.Column != source.Destination
            if (rowDistance == 2)
            {
                if (IsCapture(source, destination))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public bool IsCapture(Position source, Position destination)
        {
            // |destination.Row - source.Row|==2 && |destination.Column - source.Column|==2
            int rowDistance = Math.Abs(destination.Row - source.Row);
            int colDistance = Math.Abs(destination.Column - source.Column);
            if (rowDistance == 2 && colDistance == 2)
            {
                // there must be a piece in the middle of the source and the destination
                int row_mid = (destination.Row + source.Row) / 2;
                int col_mid = (destination.Column + source.Column) / 2;
                Position p = new Position(row_mid, col_mid);
                Checker c = board.GetChecker(p);
                Checker player = board.GetChecker(source);
                if (c == null)
                {
                    return false;
                }
                else
                {
                    if (c.Team == player.Team)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
        }

        public Checker GetCaptureChecker(Color team, Position src, Position dest)
        {
            // ..
            if (IsCapture(src, dest))
            {
                int row_mid = (dest.Row + src.Row) / 2;
                int col_mid = (dest.Column + src.Column) / 2;
                Position p = new Position(row_mid, col_mid);
                Checker c = board.GetChecker(p);
                return c;
            }
            return null;

        }

        public void ProcessInput()
        {
            ///NOTE: If you want to, you can try to validate the source position
            ///right after the user enters the data by checking if there is a checker
            ///at the given position
            Console.WriteLine("Select a checker to move (Row, Column):");
            string[] source = Console.ReadLine().Split(','); // I skipped user input validation here
            Console.WriteLine("Select a square to move to (Row, Column):");
            string[] destination = Console.ReadLine().Split(','); // I skipped user input validation here

            // usually we need to check if src.Count==2 before we retrieve data src[0] and src[1]
            // you can add the check if you want to. Likewise, we usually check dest.Count==2 as well 

            ///TODO: Now you have all building blocks, it is your turn to put them together
            ///
            //1. Get the checker at the source position:
            // hint: use GetChecker function
            Position from = new Position(int.Parse(source[0]), int.Parse(source[1]));
            Position to = new Position(int.Parse(destination[0]), int.Parse(destination[1]));

            Checker c = board.GetChecker(from);

            //2. If there is no checker at the source position
            // notify the user of the error, then stop
            if (c != null)
            {
                if (IsLegalMove(c.Team, from, to))
                {
                    if (IsCapture(from, to))
                    {
                        Checker captured = GetCaptureChecker(c.Team, from, to);
                        board.RemoveChecker(captured);
                    }
                    board.MoveChecker(c, to);
                    DrawBoard();
                }
                else
                {
                    Console.WriteLine("That is an invalid move, Please double check your source and destination.");
                }
            }
            else
            {
                Console.WriteLine("That is an invalid move, Please double check your source and destination.");
            }
        }


        //3. If there is a checker at the source position
        // then check if the move from the source position to the destination position
        // is a legal move
        // 
        // 3.1. 
        // If (this is a legal move)
        // {
        //    Move the checker to the destination position
        //    If (this is also a capture move)
        //    {
        //       Find the checker that will be captured
        //       Remove the captured checker from the board
        //    }
        //  }
        //  else (this is not a legal move)
        //  {
        //      Notify the user of the error and then stop
        //  }

        // Re-draw the board after each move




        public void DrawBoard()
        {
            String[][] grid = new String[8][];
            for (int r = 0; r < 8; r++)
            {
                grid[r] = new String[8];
                for (int c = 0; c < 8; c++)
                {
                    grid[r][c] = " ";
                }
            }
            foreach (Checker c in board.checkers)
            {
                grid[c.Position.Row][c.Position.Column] = c.Symbol;
            }

            Console.WriteLine("   0   1   2   3   4   5   6   7");
            Console.Write("  ");
            for (int i = 0; i < 32; i++)
            {
                //Console.Write("\u2015");
                Console.Write("\u2501");
            }
            Console.WriteLine();

            for (int r = 0; r < 8; r++)
            {
                Console.Write($"{r} ");
                for (int c = 0; c < 8; c++)
                {
                    Console.Write($" {grid[r][c]} \u2503"); // Console.Write(" {0}", grid[r][c]);
                }
                Console.WriteLine();
                Console.Write("  ");
                for (int i = 0; i < 32; i++)
                {
                    Console.Write("\u2501");
                }
                Console.WriteLine();
            }
        }
    }
}
