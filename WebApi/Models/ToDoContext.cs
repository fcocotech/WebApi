using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace WebApi.Models
{
    public class ToDoContext: DbContext
    {
        public DbSet<UserModel> User { get; set; }  
        //public ToDoContext(DbContextOptions<ToDoContext> options)
        //   : base(options)
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=registration;user=root;password='';Convert Zero Datetime=True");
        }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
