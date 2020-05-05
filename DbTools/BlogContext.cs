using Microsoft.EntityFrameworkCore;
using System;
using System.Resources;

namespace DbTools
{
    public class BlogContext : DbContext
    {
        //@"Data Source=DESKTOP-EJ2NR7K\SQLEXPRESS;Initial Catalog=BlogDB;Integrated Security=True"

        public BlogContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-EJ2NR7K\SQLEXPRESS;Initial Catalog=BlogDB;Integrated Security=True;");
        }

    }
}
