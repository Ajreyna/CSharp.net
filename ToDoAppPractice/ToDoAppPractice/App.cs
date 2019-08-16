using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace ToDoAppPractice
{
    public class App
    {
        ItemRepository repo;
        public App()
        {
            repo = new ItemRepository();
        }

        public void Start()
        {
            //display menu
            string action = ConsoleUtils.DisplayMenu();

            //Process user requests
            while (action != "Q")
            {
                if (action == "L")
                {
                    repo.GetToDoItems();
                    List<ToDoItem> list = repo.GetToDoItems();
                    ConsoleUtils.PrintToDoItems(list);
                }
                //a
                if (action == "A")
                {
                    Console.WriteLine("Add a description: ");
                    string Description = Console.ReadLine();
                    Console.WriteLine("Enter the status for this item : ");
                    string status = Console.ReadLine();

                    DateTime DueDate = Convert.ToDateTime(Console.ReadLine());
                    repo.AddItem(Description, status, DueDate);

                }
                //u
                if (action == "U")
                {
                    Console.WriteLine("What is the Id of the item you want to update?");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the Description you want to update for the item? ");
                    string Description = Console.ReadLine();
                    Console.WriteLine("What is the Status you want to update for the item?");
                    string Status = Console.ReadLine();
                    Console.WriteLine("What is the Due Date for the item?");
                    DateTime Duedate = Convert.ToDateTime(Console.ReadLine());
                    repo.UpdateItem(Id, Description, Status, Duedate);
                }

                //d
                if(action == "D")
                {
                    Console.WriteLine("What is the id of item to delete?");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    repo.DeleteItem(Id);
                }

            }
        }
    }
}
