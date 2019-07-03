using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var list = new NameList();
            list.AddPeople();
            list.PrintAll();
            Console.ReadLine();
        }

        public class Person
        {
            public virtual string _Name { get; set; }
            public string _NickName { get; set; }

            public Person(string NameOfPerson, string NickNameOfPerson)
            {
                _Name = NameOfPerson;
                _NickName = NickNameOfPerson;
            }

            public override string ToString()
            {
                return _Name;
            }

            public virtual void PrintGreeting()
            {
                Console.WriteLine("My name is {0}, but I go by {1}.", _Name, _NickName);
            }

        }

        public class SuperHero : Person
        {
            public override string _Name { get => base._Name; set => base._Name = value; }
            public string RealName { get; set; }
            public string superPowers { get; set; }

            public SuperHero(string Name, string RealName, string superPowers) : base(Name, null)
            {
                Console.WriteLine("I am {0}. My Hero name is {1}. One power that I possess is {2}.", RealName, Name, superPowers);
            }
        }

        class Villain :Person
        {
            public string Nemesis { get; set; }
            public string VillainsName { get; set; }

            //Villain class needs to take the name via a Constructor
            public Villain(string NameOVillain, string nemesis1) : base(NameOVillain, null)
            {
                VillainsName = NameOVillain;
                Nemesis = nemesis1;
            }

            public override void PrintGreeting()
            {
                Console.WriteLine("{0}: I am {0}. Have you seen {1}?", VillainsName, Nemesis);
            }
        }

        class NameList
        {
            static List<Person> NewPerson = new List<Person>();
            public void AddPeople()
            {
                NewPerson.Add(new Person("Frank", "Stank"));
                NewPerson.Add(new SuperHero("Batman", "Bruce Wayne", "I am the bat!"));
                NewPerson.Add(new Villain("ScareCroW", "Legion of Doom"));
            }
            public void PrintAll()
            {
                foreach (var person in NewPerson)
                {
                    person.PrintGreeting();
                }
            }
        

        }
    }
}

       