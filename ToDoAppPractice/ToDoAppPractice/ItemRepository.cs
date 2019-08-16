using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace ToDoAppPractice
{
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

        public void AddItem(string description, string status, DateTime DueDate)
        {
            ToDoItem item = new ToDoItem(description, status, DueDate);
            context.ToDoItems.Add(item);
            context.SaveChanges();
        }

        public void UpdateItem(int id, string newDescription, string newStatus, DateTime newDueDate)
        {
            ToDoItem oldItem = context.ToDoItems.Where(ItemRepository => ItemRepository.Id == id).FirstOrDefault();

            oldItem.Description = newDescription;
            oldItem.Status = newStatus;
            oldItem.DueDate = newdueDate;
            context.Update(oldItem);
            context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            ToDoItem oldItem = context.ToDoItems.Where(ItemRepository => ItemRepository.Id == id).FirstOrDefault();
            context.ToDoItems.Remove(oldItem);
            context.SaveChanges();
        }
        //Now go on to ItemContext: DBContext in a separate class/file//
        ////////////////////////////////////////////////////////////////
    }
}
