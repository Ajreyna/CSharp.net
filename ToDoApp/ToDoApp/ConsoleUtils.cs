using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ToDoApp
{
    public class ConsoleUtils
    {
        public ConsoleUtils()
        {
            #region 7/1/19 examples
           

            }
        public void DisplayMenu()
        {
            string menu = @"Welcome to my ToDo App. Choose an option to continue.
L/1: List all items
A/a: Add a new item
U/u: update an item
D/d: Delete an item
Q/q: Quit the program";
            Console.WriteLine(menu);
            string UserChoice = Console.ReadLine();
        }

        public void ProcessInput(UserChoice choice)
        {
            while (choice != UserChoice.Quit)
            {
                switch (choice)
                {
                    case UserChoice.ListItem;
                        break;
                }
            }
            #endregion
        public enum GetUserChoice
        {

        }

        #region user input
        public static int GetItemId()
            {
            Console.WriteLine("Enter the id of he item:");
            string UserINput = Console.ReadLine();
            int itemid = int.Parse(UserINput);
            return itemid;
            }
        #endregion

        #region print items here
        public static void displayItems()
        {
            foreach (ToDoItem item in List)
            {
                Console.WriteLine($"{item.id} - {item.Description} - {item.Status}");
            }
            

           
        }
        #endregiona


        public string GetUserChoice()
        {
            Console.WriteLine("Print desired action.");
            string action = Console.ReadLine().ToUpper();
            return action;

        }

        public string AskForItemInfo()
        {
            Console.WriteLine("What item would you like to add?");
            string answer = Console.ReadLine();
            return AskForItemInfo();


        }
    }
}
}
