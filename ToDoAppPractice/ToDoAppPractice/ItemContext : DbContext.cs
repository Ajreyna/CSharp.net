using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ToDoAppPractice
{
    public class ItemContext : DbContext
    {
        //This property corresponds to the table in our database

        public DbSet<ToDoItem> ToDoItems { get : set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //get the directory the coee is being executed from
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            //get the base directory fro the project
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            // add 'students.db to the project directory
            string DatabaseFile = Path.Combine(ProjectBase.FullName, "ToDoItems.db");

            // to check what the path of the file is, uncomment the file below...
            // Console.WriteLine("using database file : "+DatabaseFile);

            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);

        }

    }
    
        
}
