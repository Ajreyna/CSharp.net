//using System;
//using System.Collections.Generic;

//public struct Position
//{
//    public int row { get; private set; }
//    public int col { get; private set; }
//    public Position(int row, int col)
//    {
//        this.row = row;
//        this.col = col;
//    }
//}

//public enum Color { White, Black }

//public class Checker
//{
//    public String symbol { get; private set; }
//    public Color team { get; private set; }
//    public Position position { get; set; }

//    public Checker(Color team, int row, int col)
//    {
//        // ...  
//    }

//}

//public class Board
//{
//    public List<Checker> checkers;
//    public Board()
//    {
//        checkers = new List<Checker>();
//        for (int r = 0; r < 3; r++)
//        {
//            for (int i = 0; i < 8; i += 2)
//            {
//                Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);
//                checkers.Add(c);
//            }
//            for (int i = 0; i < 8; i += 2)
//            {
//                Checker c = new Checker(Color.Black, 5 + r, (r) % 2 + i);
//                checkers.Add(c);
//            }
//        }

//        //Checker c = new Checker(Color.White, 0, 1);
//        //checkers.Add(c);
//        //c = new Checker(Color.White, 0, 3);
//        //checkers.Add(c);

//        //c = new Checker(Color.Black, 5, 0);
//        //checkers.Add();
//    }

//    public Checker GetChecker(Position source)
//    {
//        //..
//        ///TODO: example on using todo in c#
//        foreach (Checker c in checkers)
//        {
//            if (c.position.row == source.row && c.position.Column == source.Column)
//            {
//                return c;
//            }
//        }
//        return null;  
//    }

//    public void RemoveChecker(Checker checker)
//    {
//       if (checker != null)
//        {
//            checkers.Remove()
//        }
//    }

//    public void MoveChecker(Checker checker, Position dest)
//    {
//        Checker c = new Checker.Team, destination.Row, destination.column);
//        checkers.Add(c);
//        RemoveChecker(checker);
//        //Checkers.Remove(checker);
//    }

//}

//public class Game
//{
//    private Board board;
//    public Game()
//    {
//        this.board = new Board();
//    }

//    private bool CheckForWin()
//    {
//        return (board.checkers.FindAll(x => x.team == Color.White) || board.checkers.FindAll(x => x.team == Color.Black));

//    }

//    public void Start()
//    {
//        DrawBoard();
//        while (!CheckForWin())
//            this.ProcessInput();
//        Console.WriteLine("you won!");
//    }

//    public bool IsLegalMove(Color player, Position source, Position destination)
//    {
//        // ...  Jeffrey sasy this should be in board class  
//        // but i guess I'm not putting it there.

//        //1. Both the source and the Destination
//        //position must be integers between 0 and 7
//        if (source.Row < 0 || source.Row > 7 || source.Column < 0 || source.Column > 7
//            || destination.Row < 0 || destination.Row > 7 || destination.Column < 0
//            || destination.Column > 7) return false;

//        //2. The destination point and the soure point must fall 
//        // on the same line with the slope = 1 or -1. Or the absolute value
//        // of the slope must be 1.
//        int rowDistance = Math.Abs(destination.Row - source.Row);
//        int colDistance = Math.Abs(destination.Column - source.Column);
//        // Make sure the denominator is not equal to zero
//        if (colDistance == 0 || rowDisatnce == 0) return false;
//        if (rowDistance / colDistance != 1) return false;

//        // 3. If we raeach here, that means the destination position
//        // and the source position are on the same line.
//        // But we need to make sure the destination can only be up to 
//        // two steps away fom the source (if there is a piece n between)
//        if (rowDistance > 2) return false; // no need to check if coldDistance > 2

//        // 4. Now we have made sure that the destination position
//        // and the source position are on the same line and with the
//        // correct distance
//        //3.1 There must be a checker at the source position
//        Checker c = board.GetChecker(destination)
//            if (c == null) return false);
//        //4.2 There must be no checker at the destination position
//        c = board.GetChecker(destination);
//        if (c != null) return false;

//        //5. Now we need to make sure the moving direction and length

//        // The White cheker can only go down 

//        //this means that the destination.Ro should be greater than the source.Row
//        //
//        if 5.1 destination.Row - source.Row = 2
//        if (rowDistance == 2)
//        {
//            // there must be a piece in the way
//            int row_mid = (destination.Row + source.Row) / 2;
//            int col_mid = (destination.Column + source.Column) / 2;
//            Position p = new Position(row_mid, col_mid);
//            c = board.GetChecker(p);
//            if (c == null)
//            {
//                return false;
//            }
//            else
//            {
//                if (c.team == player)
//                {
//                    return false;
//                }
//                else
//                {
//                    return true;
//                }
//            }
//        }

//        if (IsCapture(player, source, destination))
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }



//    else
//        {
//            return true;
//        }

//    }







//    public bool IsCapture(Color player, Position source, Position destination)
//        {
//            // |destination.Row - source.Row |==2 && |destination.Column - source.Column|==2
//            int rowDistance = Math.Abs(destination.row - source.row);
//            int colDistance = Math.Abs(destination.Column - source.Column);
//            if (rowDistance == 2 && colDistance == 2) return true;
//            if (rowDistance == 2)
//            {
//                // there must be a piece in the way
//                int row_mid = (destination.Row + source.Row) / 2;
//                int col_mid = (destination.Column + source.Column) / 2;
//                Position p = new Position(row_mid, col_mid);
//                c = board.GetChecker(p);
//                if (c == null)
//                {
//                    return false;
//                }
//                else
//                {
//                    if (c.team == player)
//                    {
//                        return false;
//                    }
//                    else
//                    {
//                        return true;
//                    }
//                }
//            }

//    }

//    public Checker GetCaptureChecker(color Player, Position source, Position destination)
//    {
//        if (IsCapture(player, source, destination))
//        {
//            int row_mid = (destination.row + source.row) / 2;
//            int col_mid = (destination.Column + source.Column) / 2;
//            Position p = new Position(row_mid, col_mid);
//            Checker c = board.GetChecker(p);
//            rerurn c;
//        }
//        return null;

//    }

//    public Position ProcessInput()
//    {

//    }

//    public void DrawBoard()
//    {
//        String[][] grid = new String[8][];
//        for (int r = 0; r < 8; r++)
//        {
//            grid[r] = new String[8];
//            for (int c = 0; c < 8; c++)
//            {
//                grid[r][c] = " ";
//            }
//        }
//        foreach (Checker c in board.checkers)
//        {
//            grid[c.position.row][c.position.col] = c.symbol;
//        }

//        Console.WriteLine("  0 1 2 3 4 5 6 7");
//        for (int r = 0; r < 8; r++)
//        {
//            Console.Write(r);
//            for (int c = 0; c < 8; c++)
//            {
//                Console.Write(" {0}", grid[r][c]);
//            }
//            Console.WriteLine();
//        }
//    }


//}

//class Program
//{
//    public static void Main(String[] args)
//    {
//        Game game = new Game();
//        game.Start();
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            // The line below is needed so Console window can display
            // the black disk and the white circle correctly
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ///TODO: Start the game
            ///How do we start the game?
            ///hint: What function should you call here?
            ///
            Game game = new Game();
            game.DrawBoard();
            game.Start();
            Console.ReadKey();

        }
    }

    #region Checker Class
    public class Checker
    {
        public string Symbol { get; private set; }
        public Position Position { get; set; }
        public Color Team { get; private set; }

        public Checker(Color player, int row, int col)
        {
            if (player == Color.Black)
            {
                int symbol = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
                Symbol = char.ConvertFromUtf32(symbol);
                Team = Color.Black;
            }
            else
            {
                int symbol = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
                Symbol = char.ConvertFromUtf32(symbol);
                Team = Color.White;
            }
            Position = new Position(row, col);
        }
    }
    #endregion

    #region Board Class
    public class Board
    {
        public List<Checker> checkers { get; private set; }

        #region Constructor
        public Board()
        {
            checkers = new List<Checker>();
            for (int r = 0; r < 3; r++)
            {
                for (int i = 0; i < 8; i += 2)
                {
                    // the first three rows are for White checkers (row = 0,1,2)

                    Checker cw = new Checker(Color.White, r, (r + 1) % 2 + i);
                    checkers.Add(cw);
                    Checker cb = new Checker(Color.Black, (r + 5), r % 2 + i);
                    checkers.Add(cb);

                }
              

                ///NOTE: Can we combine the two "for" loops above into one "for" loop?


            }
        }
        #endregion

        #region Methods

        public Checker GetChecker(Position source)
        {
            /*
            foreach (Checker c in checkers)
            {
                if (c.Position.Row == source.Row && c.Position.Column == source.Column)
                {
                    return c;
                }
            }
            return null;
            */

            // The forllowing line of code does the same thing as the above code
            // and you can see that LINQ is little bit hard to understand
            // but it is much shorter
            // If you don't want to use LINQ, you can commnet out the following line
            // AND un-comment the above code block.
            return checkers.Find(x => x.Position.Row == source.Row && x.Position.Column == source.Column);

        }

        public void MoveChecker(Checker checker, Position destination)
        {
            Checker c = new Checker(checker.Team, destination.Row, destination.Column);
            checkers.Add(c);
            checkers.Remove(checker);
        }

        public void RemoveChecker(Checker checker)
        {
            if (checker != null)
            {
                checkers.Remove(checker);
            }
        }

        #endregion
    }

    #endregion

    #region Game Class
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

    #endregion

    public enum Color { White, Black }

    #region Position Struct
    public struct Position
    {
        public int Row { get; private set; }
        public int Column { get; private set; }
        public Position(int row, int col)
        {
            Row = row;
            Column = col;
        }
    }
    #endregion
}
