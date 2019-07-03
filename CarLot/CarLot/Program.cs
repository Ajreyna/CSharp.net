using System;
using System.Collections.Generic;

namespace CarLot
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("What is the name of the car lot?");
            string response1 = Console.ReadLine();
            CarLot cars = new CarLot(response1);

            cars.AddVehicle(new Car("Coupe", 2, "1234566", "ford", "mustang", 25000));
            cars.PrintVehicles();
        }


    }

    class CarLot
    {
        string name;
        List<Vehicle> vehicles = new List<Vehicle>();

        public CarLot(string name)
        {
            this.name = name;
        }
        public void AddVehicle(Vehicle NewVehicle)
        {

            vehicles.Add(NewVehicle);
           
        }

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
    public abstract class Vehicle
    {
        public string PlateNumber { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int price { get; set; }

        public Vehicle(string licenseNumber, string Make, string Model, int Price )
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
        public int BedSize { get; set; }

        public Truck(string licenseNumber, string Make, string Model, int Price, int BedSize) : base(licenseNumber, Make, Model, Price)
        {
            this.BedSize = BedSize;
            //this.PlateNumber = PlateNumber;
            //this.make = make;
            //this.model = model;
            //this.price = price;
        }




    }
    public class Car:Vehicle
    {
        string Cartype;
        int NumOfDoors;

        public Car(string CarType, int NumOfDoors, string licenseNumber, string Make, string Model, int Price) : base(licenseNumber, Make, Model, Price)
        {
            this.Cartype = CarType;
            this.NumOfDoors = NumOfDoors;
            

        }
    }
}
