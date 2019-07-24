using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            // calls a new nameslist then both functions within  Readline to keep the window open
            var list = new NamesList();
            list.AddPeople();
            list.PrintAll();
            Console.ReadLine();
        }
    }
    public class Person
    {
        public virtual string Name { get; set; }
        public string NickName { get; set; }

        public Person(string PersonName, string PersonNickName)
        {
            Name = PersonName;
            NickName = PersonNickName;
        }
        public override string ToString()
        {
            return Name;
        }
        //printed greeting that will be overridden by other classes.
        public virtual void PrintGreeting()
        {
            Console.WriteLine("Hi, my name is {0}, you can call me {1}.", Name, NickName);
        }
    }
    // Superhero class that inhertis from Person.
    public class SuperHero : Person
    {
        public override string Name { get => base.Name; set => base.Name = value; }
        public string RealName { get; set; }
        public string SuperPower { get; set; }

        public SuperHero(string Name, string RealName, string SuperPower) : base(Name, null)
        {
            Console.WriteLine("I am {0}.  My SuperHero name is {1}. One of my powers is: {2}", RealName, Name, SuperPower);
        }


    }

    class Villain : Person
    {
        public string ArchNemesis { get; set; }
        public string VillainName { get; set; }
        //Your Villain class should have a constructor that takes in the name and nemesis of the villain.And should pass null to the base constructor for the nickname.
        public Villain(string vname, string anemesis) : base(vname, null)
        {
            VillainName = vname;
            ArchNemesis = anemesis;
        }

        public override void PrintGreeting()
        {
            Console.WriteLine("{0}!!! I am {0}! Have you seen {1}???", VillainName, ArchNemesis);
        }
    }
    class NamesList
    {
        static List<Person> NewPeople = new List<Person>();
        public void AddPeople()
        {
            NewPeople.Add(new Person("Franklin", "Frankie"));
            NewPeople.Add(new SuperHero("Radioactive Man", "Rainier Wolfcastle", "The goggles! They do nothing!!!"));
            NewPeople.Add(new Villain("The Mighty Monarch", "Dr. Venture"));
        }
        public void PrintAll()
        {
            foreach (var person in NewPeople)
            {
                person.PrintGreeting();
            }
        }
    }

}
