﻿using System;

namespace PoCos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            #region Dr. Zhengs examples
            /*Car myCar = new Car();
           myCar.Model = "Ford";
           myCar.Year = 2015;
           myCar.Make = "fiesta";
           myCar.NumberOfDoors = 2;

           Console.WriteLine(myCar.GetCarDetails());

           Car yourCar = new Car();
           */
            #endregion 



            Console.WriteLine(myLicense.LicenseDeets());



        }
    }

    class DriversLicense
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string LicenseNumber { get; set; }



        public DriversLicense(string First_Name, string Last_Name, string Gender1, string License_Number)
        {
            FirstName = First_Name;
            LastName = Last_Name;
            Gender = Gender1;
            LicenseNumber = License_Number;
        }

       
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumOfPages { get; set; }
        public int SKU { get; set;  }
        public string publisher { get; set; }
        public int Price { get; set; }

        public Book(string Title1, string Author1, string Num_Of_Pages, stringa)

    }

    class Airplane
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string variant { get; set; }
        public string SeatingCapacity { get; set; }
        public int NumberOfEngines { get; set; }

    }
        
    #region car example
    /*class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int NumberOfDoors { get; set; }

        public Car()
        {
            Make = "unknown";
            Model = "unknown";
            Year = 2019;
            NumberOfDoors = 4;
        }
        public string GetCarDetails()
        {
            return (Model + " " + Make + " " + Year + " " + NumberOfDoors + " ");
        }

    }*/
    #endregion
}