using System;
using System.Collections.Generic;

namespace Inventory
{


}

    public static void Main(String[] args)
    {
        List<IRentable> rates = new List<IRentable>();
        rates.Add(new Boat("Bass"));
        rates.Add(new Car("Convertible"));
        rates.Add(new House("2b 2ba"));

    }

    public interface IRentable
    {
        void GetDailyRate();
        void GetDescription();
    }

    public class Boat :
    {
        int _hourlyRate = 20;


    }

    public class House
    {
        int _weeklyRate = 100;
    }

    public class Car
    {
        int _dailyRate = 80;
    }




