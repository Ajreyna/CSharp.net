using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ToDoApp
{
    class ToDoItem
    {
        public int id { get; private set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }
        public ToDoItem(string Description, string status, string DueDate)
        {
            this.Description = Description;
            this.Status = Status;
            this.DueDate = DueDate;
        }

    }

    class ItemContext:DbContext()
    {
        public DbSet<ToDoItem> toDoItems;
    }


    class ItemRepository
    {
        ItemContext context;

        public ItemRepository()
        {
            context = new ItemContext();
            context.Database.EnsureCreated();
        }
        //List all my toDo items
        public List<ToDoItem> GetToDoItems()
        {
            IEnumerable<ToDoItem> list = context.toDoItems;
            return list.ToList();
        }

        public void AddItem(string Description, string status, DateTime DueDate)
        {

        }

        public void AddItem(ToDoItem item)
        {

        }

        public void UpdateItem(int id, string newDescription, string newStatus, string newDueDate)
        {
            ToDoItem oldItem = context.toDoItems.Where(x=> x.id == id).FirstOrDefault();

            //ToDoItem oldItem1 = (from item in context.toDoItems
            //                     where item.id == id
            //                     select item).FirstOrDefault();

            oldItem.Description = newDescription;
            oldItem.Status = newStatus;
            oldItem.DueDate = newDueDate;
            context.Update(oldItem);
            context.SaveChanges();
        }

        public void UpdateItem(ToDoItem)
        {

        }

        public void DeleteItem(int id, string newDescription, string newStatus, string newDueDate)
        {
            ToDoItem oldItem = context.toDoItems.Where(item => item.id == id).FirstOrDefault();
            context.toDoItems.Remove(oldItem);
            context.SaveChanges();
        }


    }
          
        
 
    
}
