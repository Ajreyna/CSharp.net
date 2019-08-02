using System;
using System.Collections.Generic;

namespace CarLot
{
    class MainClass
    {
        //Main as used here implements the classes and methods for the rest of the program
        public static void Main(string[] args)
        {

            Console.WriteLine("What is the name of the car lot?");
            string response1 = Console.ReadLine();
            //CarLot cars = new CarLot(response1);
            Console.WriteLine("The name of this carlot is {0}. \n \n", response1);
            Console.WriteLine("The inventory of this carlot includes");
            CarLot cars = new CarLot(response1);
            

            cars.AddVehicle(new Car("Coupe", 2, "1234566", "ford", "mustang", 25000));
            cars.AddVehicle(new Car(CarType: "Sedan", NumOfDoors: 4, licenseNumber:"AVB33KXR", Make:"Chrysler", Model:"New Yorker Brougham", Price: 10000));
            cars.AddVehicle(new Truck(licenseNumber:"WTF190XRF", Make:"Chevrolet", Model:"Silverado", Price:90000, BedSize:"Long Bed"));

            cars.PrintVehicles();
        }


    }

    //Below CarLot holds a list for vehicles and uses constructors to Add and Print the cars.
    class CarLot
    {
        string name;
        
        List<Vehicle> vehicles = new List<Vehicle>();

        //Sets name
        public CarLot(string name)
        {
            this.name = name;
        }
        
        //Adds vehicles to list
        public void AddVehicle(Vehicle NewVehicle)
        {

            vehicles.Add(NewVehicle);
           
        }
        
        // PrintVehicles uses a foreach loop to write the list to console.
        public void PrintVehicles()
        {
            foreach (Vehicle item in vehicles)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine(vehicles.Count + " Cars");
        }

        //ans += vehicles;
    }
    
    //Here the class Vehicle gets and sets the make, model, plate number and price 
    public abstract class Vehicle
    {
        public string PlateNumber { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int price { get; set; }
        
        

        public Vehicle(string licenseNumber, string Make, string Model, int Price)
        {
            PlateNumber = licenseNumber;
            make = Make;
            model = Model;
            price = Price;
            


        }

        public virtual string VehicleType()
        {
            string VechicleType = make + model + price + PlateNumber;
            return VechicleType;
        }

        public override string ToString()
        {
            return $"{make}, {model}, {price}";
        }

    }
    class Truck : Vehicle
    {
        private string BedSize = "LongBed";
        //public string BedSize { get; set; }
        
        //The Truck method sets licenseNumber, Make, Model, Price and BedSize.
        public Truck(string licenseNumber, string Make, string Model, int Price, string BedSize) : base(licenseNumber, Make, Model, Price)
        {
            this.BedSize = BedSize;
            this.PlateNumber = PlateNumber;
            this.make = make;
            this.model = model;
            this.price = price;
        }




    }
    public class Car:Vehicle
    {
        string Cartype;
        int NumOfDoors;

        //Here The type, number of doors, license number, make , model and price are set to "Car".
        public Car(string CarType, int NumOfDoors, string licenseNumber, string Make, string Model, int Price) : base(licenseNumber, Make, Model, Price)
        {
            this.Cartype = CarType;
            this.NumOfDoors = NumOfDoors;
            

        }
    }
}
