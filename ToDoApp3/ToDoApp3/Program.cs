using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ToDoApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var app = new App();
            app.Start();

        }
    }
    public class ConsoleUtils
    {
        public static string DisplayMenu()
        {
            Console.WriteLine("This is ToDo app. Choose an option to continue: ");
            Console.WriteLine("L to list item");
            Console.WriteLine("A to add item");
            Console.WriteLine("U to update item");
            Console.WriteLine("D to delete item");
            Console.WriteLine("Q to quit the program: ");
            Console.WriteLine("Choose your option: ");
            string action = Console.ReadLine().ToUpper();
            return action;

        }
        //Requests and returns info
        public static string AskForItemInfo()
        {
            Console.WriteLine("Please enter the item for the list: ");
            string UserItemInfo = Console.ReadLine();
            return UserItemInfo;
        }

        //print said item
        public static void PrintToDoItems(List<ToDoItem> list)
        {
            foreach (ToDoItem item in list)
            {
                Console.WriteLine($"{item.Id} - {item.Description} - {item.Status} - {item.DueDate}");
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
                //l
                if (action == "L")
                {
                    repo.GetToDoItems();
                    List<ToDoItem> list = repo.GetToDoItems();
                    ConsoleUtils.PrintToDoItems(list);
                    
                    
                    break;
                }

                //q
                if (action == "Q")
                {
                    break;
                }
                //a
                if (action == "A")
                {
                    Console.WriteLine("Add a Description: ");
                    string Description = Console.ReadLine();
                    Console.WriteLine("Enter the status for the item :");
                    string Status = Console.ReadLine().ToUpper();

                    List<string> pendingList = new List<string>();

                    //if (Status =="PENDING")
                    //{
                    //    pendingList.Add(Status);
                    //    foreach (string items in pendingList)
                    //    {
                    //        Console.WriteLine(items);
                    //    }
                    //}
                    
                    Console.WriteLine("enter a due date for the item :");
                    DateTime DueDate = Convert.ToDateTime(Console.ReadLine());
                    repo.AddItem(Description, Status, DueDate);
                    //According to Denise, here i could use a conditional to ask user if they'd like
                    //to continue or waht.
                    Console.WriteLine("press any key...");
                    Console.ReadKey();

                    Console.WriteLine("Would you like to enter another Item???");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }

                    
                }
                //u
                if (action == "U")
                {
                    Console.WriteLine("What is the Id of the item you want to update: ");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the Description you want to update for the item: ");
                    string Description = Console.ReadLine();
                    Console.WriteLine("What is the Status you want to update for the item: ");
                    string Status = Console.ReadLine();
                    Console.WriteLine("What is the Due Date you want to update for the item: ");
                    DateTime DueDate = Convert.ToDateTime(Console.ReadLine());
                    repo.UpdateItem(Id, Description, Status, DueDate);
                }
                //d
                if (action == "D")
                {
                    Console.WriteLine("What is the id of item to delete? ");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    repo.DeleteItem(Id);
                }
            }
        }
    }

    public class ItemRepository
    {
        ItemContext context;

        public ItemRepository()
        {
            context = new ItemContext();
            context.Database.EnsureCreated();
        }
        public List<ToDoItem> GetToDoItems()
        {
            IEnumerable<ToDoItem> list = context.ToDoItems;
            return list.ToList();
        }
        public void AddItem(string description, string status, DateTime dueDate)
        {
            ToDoItem item = new ToDoItem(description, status, dueDate);
            context.ToDoItems.Add(item);
            context.SaveChanges();
        }
        public void UpdateItem(int id, string newDescription, string newStatus, DateTime newDueDate)
        {
            ToDoItem oldItem = context.ToDoItems.Where(item => item.Id == id).FirstOrDefault();

            oldItem.Description = newDescription;
            oldItem.Status = newStatus;
            oldItem.DueDate = newDueDate;
            context.Update(oldItem);
            context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            ToDoItem oldItem = context.ToDoItems.Where(item => item.Id == id).FirstOrDefault();
            context.ToDoItems.Remove(oldItem);
            context.SaveChanges();
        }
    }

    public class ItemContext : DbContext
    {
        // This property corresponds to the table in our database
        public DbSet<ToDoItem> ToDoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the directory the code is being executed from
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            // get the base directory for the project
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            // add 'students.db' to the project directory
            string DatabaseFile = Path.Combine(ProjectBase.FullName, "ToDoItems.db");

            // to check what the path of the file is, uncomment the file below
            //Console.WriteLine("using database file :"+DatabaseFile);

            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }



    }

    public class ToDoItem
    {
        public int Id { get; private set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }
        public ToDoItem(string Description, string Status, DateTime DueDate)
        {
            this.Description = Description;
            this.Status = Status;
            this.DueDate = DueDate;
        }
    }
}
