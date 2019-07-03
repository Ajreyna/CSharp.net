using System;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsContext context = new StudentsContext();
            context.Database.EnsureCreated();


            Console.WriteLine("enter Student full name");
            String fullName = Console.ReadLine();
            string[] nameParts = fullName.Split();

            Student newStudetn = new Student(nameParts[0], nameParts[1]);
            context.Students.Add(newStudetn);
            context.SaveChanges();



        }

    }
    class Student
    {
        //notice the private set on the id
        public int Id { get; private set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public Student(String FirstName, String LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }

    class StudentsContext : DbContext
    {
       
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

               
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;


            String DatabaseFile = Path.Combine(ProjectBase.FullName, "Students.db");


            //Console.WriteLine("using database file :"+DatabaseFile);

            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }
    }
}
