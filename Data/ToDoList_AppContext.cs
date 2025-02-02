using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoList_App.Models;

namespace ToDoList_App.Data
{
    public class ToDoList_AppContext : DbContext
    {
        public ToDoList_AppContext (DbContextOptions<ToDoList_AppContext> options)
            : base(options)
        {
        }

        public DbSet<ToDoList_App.Models.User> User { get; set; } = default!;
    }
}
