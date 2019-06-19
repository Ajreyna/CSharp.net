using System;
using System.Collections.Generic;

namespace Inventory2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<IRentable> description = new List<IRentable>();
            description.Add(new Boat("Bass"));
            description.Add(new Car("Convertible"));
            description.Add(new House("2b 2ba"));

           //Console.WriteLine("This rate for this boat is:{0} ", _hourlyRate);


            foreach (IRentable item in description)
            {
               //Console.WriteLine(item.GetDailyRate());
               //Console.WriteLine(item.GetDescription());


                //Prof. Zhengs Examples
                Console.WriteLine($"Rental type: {item.GetType()}");
                Console.WriteLine(item.GetDescription());
                Console.WriteLine(item.GetDailyRate());
                Console.WriteLine("++++++++++");


            }
        }

        public interface IRentable
        {
            decimal GetDailyRate();
            string GetDescription();
        }



        public class Boat : IRentable
        {
            private int _hourlyRate = 20;
            private string _description;

       
            public Boat(string description)
            {
                _description = description;
            }


            public decimal GetDailyRate()
            {
                return _hourlyRate * 24;
            }

            public string GetDescription()
            {
                return _description;
            }


        }
    

    


        public class House : IRentable
        {
           private decimal _weeklyRate = 1000;
           private string _description;


            public House(string description)
            {
                _description = description;
            }

            public decimal GetDailyRate()
            {
                //Console.WriteLine("The rate for this house is:{0} ", _weeklyRate);
               decimal drate = _weeklyRate / 7 ;
                return Decimal.Round(drate, 2);
            }

            public string GetDescription()
            {
                //Console.WriteLine("This house has {0}", )
                return _description;
            }
        }
    


        public class Car : IRentable
        {
            private int _dailyRate = 80;
            private string _description;

            public Car(string description)
            {
                _description = description;
            }

            public decimal GetDailyRate()
            {
                //Console.WriteLine("The rate for this car is: {0}",)
                return _dailyRate;
            }

            public string GetDescription()
            {
                //Console.WriteLine("This car is a: {0}", );
                return _description;
            }

        }




    }
}
