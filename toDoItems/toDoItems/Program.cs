using System;
using System.Collections.Generic;

namespace toDoItems
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //1. ask user if they want to add an item, or if they are done.
            //2. if user wants to add, then ask for a : description, due date and priority
            //3. repeat until the user is done entering items.
            //4. Loop through the items and print details of each item to the console.
            string question = "Would you like to add a ToDo item? (Y/N)";
            Console.WriteLine(question);
            string answer = Console.ReadLine().ToLower();
            List<ToDoItem> toDoList = new List<ToDoItem>();

            var names = new List<string> { "slick", "a.j.", "samson" };

            foreach(var name in names)
            {
                Console.WriteLine($"The name is {names}");
            }
           
            
            

        }
    }

    class ToDoItem
    {


        public string description { get; set; }
        public int DueDate { get; set; }
        public string Priority { get; set; }


        public ToDoItem(string initialDescription)
        {
            description = initialDescription;
        }

        public ToDoItem(int setDueDate)
        {
            DueDate = setDueDate;
        }

        public ToDoItem(string setPriority)
        {
            Priority = setPriority;
        }


      
       
    }
}
