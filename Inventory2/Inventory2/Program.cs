using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using CarLot2;

namespace CarLot2
{
    public class Program

    {
        static void Main(string[] args)
        {

            List<IRentable> carlot = new List<IRentable>();
            carlot.Add(new Boat("SpeedBoat3000"));
            carlot.Add(new Boat(initName: "Bass Hunter Deluxe"));
            carlot.Add(new Car(initName: "Coupe Sport Convertible"));
            carlot.Add(new Car(initName: "4x4 Pickup Truck"));
            carlot.Add(new Car("Lincoln Continental"));


            carlot.Add(new House("Ranch Rambler 9000"));
            carlot.Add(new House(initName: "4 Bed 3 Bath Beach House"));
            carlot.Add(new House(initName: "Downtown Loftspace "));

            Console.WriteLine("       Welcome to the rental MegaCenter! \n " +
                              "\n   Please press any key after each entry" +
                              " to see the next... \n\n");
            foreach (IRentable rentable in carlot)
            {


                rentable.GetDescription();

                rentable.GetDailyRate();



                Console.ReadKey();
            }





        }




    }

    #region IRenatble interface
    public interface IRentable
    {
        void GetDailyRate();

        void GetDescription();




    }
}


#endregion

//
//
//



#region Boat House and Car Classes
// 
//
//

public class Boat : IRentable
{
    //Boat class must internally store a hourly rate


    double rate = 100;

    String name;
    public Boat(string initName)
    {
        this.name = initName;

    }

    public void GetDailyRate()
    {

        Random rand = new Random();
        rate = rand.Next(0, 200);

        Console.WriteLine("The daily rate is ${0}.", rate);

        Console.WriteLine("\n ");


    }


    public void GetDescription()
    {

        Console.WriteLine("This boat is the {0}! \n", name);

    }





    //public void GetDescription()
    //{

    //}

}


public class Car : IRentable
{
    String name;
    public Car(string initName)
    {

        this.name = initName;

    }

    public void Message()
    {
        Console.WriteLine("The cars for rent are as follows /n" +
                          ": Please press any key after each entry to see" +
                          " the next...");
    }
    public void GetDescription()
    {
        Console.WriteLine("The cars in our inventory are: {0} \n", name);




    }

    public int rate = 100;


    public void GetDailyRate()
    {
        Random rand = new Random();
        rate = rand.Next(0, 200);
        Console.WriteLine("The daily rate for this fine automobile is ${0} \n \n", rate);
    }
}


public class House : IRentable
{
    public int rate;
    public string name;

    public House(String initName)
    {
        this.name = initName;

    }
    public void GetDescription()
    {
        Console.WriteLine("This rental house is {0} \n", name);

    }

    public void GetDailyRate()
    {
        Random rand = new Random();
        rate = rand.Next(100, 500);

        Console.WriteLine("The daily rate is ${0} \n \n", rate);
    }
}




#endregion

