using System;
namespace ToDoApp
{
    public class ConsoleUtils
    {
        public ConsoleUtils()
        {
            public void DisplayMenu()
            {
                string menu = @"Welcome to my ToDo App. Choose an option to continue.
L/1: List all items
A/a: Add a new item
U/u: update an item
D/d: Delete an item
Q/q: Quit the program";
                Console.WriteLine(menu);
            }

            public void ProcessInput(UserChoice choice)
            {
                while(choice != UserChoice.Quit)
                {
                    switch (choice)
                    {
                        case UserChoice.ListItem;
                            break;
                    }
                }

            }
            public enum UserChoice
        {

        }
        
        
        }
    }
}
