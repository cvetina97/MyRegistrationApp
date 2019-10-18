using Microsoft.EntityFrameworkCore;
using RegistrationConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistrationConsoleApp.MyDbContext
{
    public class RegistrationDbContext  : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
        }
    }
}
