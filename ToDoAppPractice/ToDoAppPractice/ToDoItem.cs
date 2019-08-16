using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
namespace ToDoAppPractice
{
    public class ToDoItem
    {
        public int Id { get; private set; }
        public string Desctiption { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }
        public ToDoItem(string Description, string Status, DateTime DueDate)
        {
            this.Desctiption = Description;
            this.Status = Status;
            this.DueDate = DueDate;
        }
    }
}
