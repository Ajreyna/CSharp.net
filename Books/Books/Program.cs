using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
//using BooksInventory;

namespace Books_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {

            BooksContext context = new BooksContext();
            Console.WriteLine("Would you like to add a book to the Inventory list? Type Y or N");
            if (Console.ReadLine().ToLower() == "Y")
            {
               
                Console.WriteLine("Enter the book title : ");
                string books = Console.ReadLine();
                context.Database.EnsureCreated();

                Console.WriteLine("Enter the book author: ");
                string author = Console.ReadLine();
                

                Books newbook = new Books(books, author);
                context.books.Add(newbook);
                context.SaveChanges();
                Console.WriteLine("Book added to list.");
                Console.WriteLine("Would you like to add another book to the inventory list? Type Y or N");
            }
            Console.WriteLine("The list of books so far is: ");







//NotFiniteNumberException
                foreach (Books b in context.books)
            {
                Console.WriteLine("{0} - {1} {2}",
                     b.Id, b.Book, b.Author);
            }
        }
    }

    class BooksContext : DbContext
    {

        // This property corresponds to the table in our database
        public DbSet<Books> books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the directory the code is being executed from
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            // get the base directory for the project
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            // add 'students.db' to the project directory
            string DatabaseFile = Path.Combine(ProjectBase.FullName, "books.db");

            // to check what the path of the file is, uncomment the file below
            //Console.WriteLine("using database file :"+DatabaseFile);

            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }
    }

    public class Books
    {
        public int Id { get; private set; }
        public String Book { get; set; }
        public String Author { get; set; }
        public Books(String book, String author)
        {
            this.Book = book;
            this.Author = author;
        }
    }

}