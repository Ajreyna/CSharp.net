using System;
using System.Collections.Generic;

namespace ToDoAppPractice
{
    public class ConsoleUtils
    {
        public static string DisplayMenu()
        {
            Console.WriteLine("Welcome to my ToDo app. Choose an option to continue.");
            Console.WriteLine("L to list an item");
            Console.WriteLine("A to add an item");
            Console.WriteLine("U to update item");
            Console.WriteLine("D to delete item");
            Console.WriteLine("Q to quit the program: ");
            Console.WriteLine("Choose your option: ");
            string action = Console.ReadLine().ToUpper();
            return action;
        }
        //requests and returns info
        public static string AskForItemInfo()
        {
            Console.WriteLine("Please enter the item for the list: ");
            string UserItemInfo = Console.ReadLine();
            return UserItemInfo;
        }
        //print the item
        public static void PrintToDoItems(List<ToDoItem> list)
        {
            foreach(ToDoItem item in list)
            {
                Console.WriteLine($"{item.id} - {item.Description} - {item.Status} - {item.DueDate}");

            }
        }
        //Ask user for list ID and return
        public static int GetItemId()
        {
            Console.WriteLine("Enter the ID of the item: ");
            string userInput = Console.ReadLine();
            int ItemId = int.Parse(userInput);
            return ItemId;
        }
    }
}
