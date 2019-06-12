using System;

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



            //Console.WriteLine(myLicense.LicenseDeets());



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

        public  Book(string Title1, string Author1, string Num_Of_Pages, string SKU1, string Publisher1, string Price1)
        {
            Title = Title1;
            Author = Author1;
            Num_Of_Pages = Convert.ToString((NumOfPages));
            SKU1 = Convert.ToString(SKU);
            publisher = Publisher1;
            Price1 = Convert.ToString(Price);

        }

    }

    class Airplane
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string variant { get; set; }
        public string SeatingCapacity { get; set; }
        public int NumberOfEngines { get; set; }


        public Airplane(string Manufacturer1, string Model1, string variant1, string SeatingCapacity1, int NumberOfEngines1)
        {
            Manufacturer = Manufacturer1;
            Model = Model1;
            variant = variant1;
            SeatingCapacity = SeatingCapacity1;
            NumberOfEngines = NumberOfEngines1;
        }
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