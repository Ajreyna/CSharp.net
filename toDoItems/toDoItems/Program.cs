using System;
using System.Collections.Generic;
using System.Linq;


namespace ToDo_Items
{
    class Program
    {


        public static void Main(string[] args)
        {
            
            Dictionary<string, List<ToDoItems>> CompleteList = new Dictionary<string, List<ToDoItems>>();
            List<ToDoItems> ToDoList = new List<ToDoItems>();

            Console.WriteLine("Do you want to enter a ToDoList item?  If no type  'quit' ");
            string response = Console.ReadLine().ToLower();
            string response2 = Console.ReadLine();

            // User follows the instructions to add items to list

            while (response != "quit")
            {

                Console.WriteLine("Enter the item description: ");
                string Description = Console.ReadLine();
                Console.WriteLine("When is the due date?");
                string DueDate = Console.ReadLine();
                Console.WriteLine("Enter the priority level as low, normal or high: ");
                string Priority = Console.ReadLine();
                ToDoList.Add(new ToDoItems(Description, DueDate, Priority));
                response = Console.ReadLine();
                Console.WriteLine("Would you like to add another item? If not type quit");
                response2 = Console.ReadLine();
                if (response2 == "quit")
                {
                    foreach (ToDoItems item in ToDoList)
                    {
                        Console.WriteLine(item.toDoList());
                    }
                    break;
                }


            }
            //foreach (ToDoItems item in ToDoList)
            //{
            //    Console.WriteLine(item.toDoList());
            //}


            //        In your main method, you should
            //Ask the user if they want to add an item, or if they are done.
            //        If the user wants to add an item,
            //ask for description, due date, and priority.
            //create a ToDoItem representing the user's input
            //add the new instance to a list of items
            //        Repeat until the user is done entering items.
            //Loop through the items and print the details of each item to the console.


        }
        class ToDoItems
        {
            public string Description { get; set; }
            public string DueDate { get; set; }
            public string Priority { get; set; }

            public ToDoItems(string description, string duedate, string priority)
            {
                Description = description;
                DueDate = duedate;
                Priority = priority;
            }
            public string toDoList()
            {
                return (Description + " | " + DueDate + " |" + Priority + "\n");
            }

        }

    }
}
