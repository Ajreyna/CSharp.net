using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Checkers
{
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
}

   
   