using ITrellis_Igor.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITrellis_Igor.DataLayer
{
    public class Taskinitializer : DropCreateDatabaseIfModelChanges<TaskContext>
    {
        protected override void Seed(TaskContext context)
        {
            var tasks = new List<Task>
            {
            new Task{ Title="task 1", Description="Do task 1", DueDate=DateTime.Now.AddDays(1), IsCompleted=false },
            new Task { Title="task 1", Description="Do task 1", DueDate=DateTime.Now.AddDays(2), IsCompleted=false },
            new Task{Title="task 1", Description="Do task 1", DueDate=DateTime.Now.AddDays(3), IsCompleted=false},
            new Task{Title="task 1", Description="Do task 1", DueDate=DateTime.Now.AddHours(10), IsCompleted=false},
            new Task{Title="task 1", Description="Do task 1", DueDate=DateTime.Now.AddHours(15), IsCompleted=false},
            new Task{Title="task 1", Description="Do task 1", DueDate=DateTime.Now.AddDays(-1), IsCompleted=false},
            new Task{Title="task 1", Description="Do task 1", DueDate=DateTime.Now.AddDays(-2), IsCompleted=false},
            new Task{Title="task 1", Description="Do task 1", DueDate=DateTime.Now.AddHours(-10), IsCompleted=false}
            };

            tasks.ForEach(s => context.Tasks.Add(s));
            context.SaveChanges();
        }
    }
}