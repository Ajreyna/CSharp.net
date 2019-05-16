using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RockPaperScissors
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Rock();

        }

        public static void Rock()
        {
            Console.WriteLine("play a game? Y/N ???");
            String ans = Console.ReadLine().ToLower();
while (ans == "y")
        {
               


                Random r = new Random();
                int computer = r.Next(0, 3);

                Console.WriteLine("Let's play a game!");
                Console.WriteLine("On three throw either: Rock, Scissors, or Paper!");
                String potato = Console.ReadLine().ToLower();
                Console.WriteLine("You threw:" + potato);
                Console.Read();
                if(computer == 1)
                {
                    Console.WriteLine("Computer threw rock.");
                }
                else if (computer == 2)
                {
                    Console.WriteLine("Computer threw paper");
                }
                else if (computer == 3)
                {
                    Console.WriteLine("Computer threw Scissors");
                }

                

 
               


                /*if (computer == 1)
                {
                    Console.WriteLine("Computer threw a rock ");
                }
               */

                //Rock Logic in this section
                //
                //

                if (computer == 1 & potato == "rock")
                {
                    Console.WriteLine("We've come to a draw :( ");
                }
                else if (computer == 2 & potato == "rock")
                {
                    Console.WriteLine("Computer wins b/c paper covers rock");
                }
                else if (computer == 3 & potato == "rock")
                {
                    Console.WriteLine("Computer loses b/c rock smashes scissors");
                }



                //Paper Logic in this section |
                //                      
                //

                else if (computer == 1 & potato == "scissors")
                {
                    Console.WriteLine("Computer wins, b/c rock smashes paper");
                }

                else if (computer == 2 & potato == "paper")
                {
                    Console.WriteLine("Both players threw paper, so it is a draw. :/");
                }



                else if (computer == 3 & potato == "paper")
                {
                    Console.WriteLine("Computer wins b/c scissors cuts paper");
                }



                //Scissors Logic here...
                //
                //

                else if (computer == 3 & potato == "scissors")
                {
                    Console.WriteLine("Scissors Draw Everyone Lose!!!");
                }


                /*else
                    if (computer == 2 || potato == "rock")
                {
                    Console.WriteLine("Paper covers rock sucka!");
                    Console.WriteLine("computer wins :( ");
                }
                else
                    if (computer == 3 || potato == "rock")
                {
                    Console.WriteLine("Rock smashes puny scissors!!! hahahahaha");
                }
                else
                    if (potato == "paper" || computer == 2)
                {
                    Console.WriteLine("Paper meet paper, we tie");
                }
                else
                    if (potato == "paper" || computer == 3)
                {
                    Console.WriteLine("Your scissors moratlly wound my paper");
                }
                else
                    if (potato == "paper" || computer == 1)
                {
                    Console.WriteLine("Paper covers rock and computer loses");
                }
                */


                Console.WriteLine("Play again? Y/N");
                string reply = Console.ReadLine().ToLower();
                if(reply == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }

        }

    }
}
