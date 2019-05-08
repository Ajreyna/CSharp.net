using System;

namespace ManyMethods2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Hello();
            Addition();
            CatDog();
            oddEvent();
            inches();
            echo();
            killGrams();
            date();
            age();
            guess();
        }

        public static void Hello()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Bye " + name);
            Console.Read();
        }

        public static void Addition()
        {
            Console.WriteLine("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The sum is " + sum);
            Console.Read();
        }
        public static void CatDog()
        {
            Console.WriteLine("Dogs or Cats? ");
            string cd = null;
            cd = Console.ReadLine();
            if (cd == "dog" || cd == "dogs")
            {
                Console.WriteLine("You prefer dogs");
            }
            else
            {
                if (cd == "cat" || cd == "cats")
                { Console.WriteLine("You prefer cats"); }
            }
        }

        public static void oddEvent()
        {
            Console.WriteLine("Enter a number");
            int evod = 0;
            evod = Convert.ToInt32(Console.ReadLine());
            if (evod % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {

                Console.WriteLine("Number is odd");
            }
        }
        public static void inches()
        {
            Console.WriteLine("Your height in feet: ");
            int ht = int.Parse(Console.ReadLine());
            int inch = ht * 12;
            Console.WriteLine("Your height in inches is: " + inch);

        }
        public static void echo()
        {
            Console.Write("Gimmie a word! ");
            string wrd = string.Concat(Console.ReadLine());
            Console.WriteLine("word is " + wrd);
            Console.Read();
        }
        public static void killGrams()
        {
            Console.WriteLine("Gimmie a weight in pounds: ");
            int wgt = int.Parse(Console.ReadLine());
            double kilo = wgt * 0.4535924;
            Console.WriteLine("weight in kilograms is: " + kilo);
        }
        public static void date()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("/n Todays date is: " + today);
        }
        public static void age()
        {
            Console.WriteLine("What year were you born?");
            int by = int.Parse(Console.ReadLine());
            double agy = 2019 - by;
            Console.WriteLine("Your age is: " + agy);
        }
        public static void guess()
        {
            //Console.WriteLine("Guess which word I'm thinking of ");
            string guess1 = null;
            guess1 = Console.ReadLine();
            {
                Console.WriteLine("guess a word: ");
                string wrdgs = null;
                wrdgs = Console.ReadLine();
                if (wrdgs == "csharp")
                {
                    Console.WriteLine("correct!");
                }
                else
                {
                    if (wrdgs != "csharp")
                    { Console.WriteLine("incorrect :( "); }
                }
            }


        }
    }

}
