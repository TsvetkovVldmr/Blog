using Blog.DbTools.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Resources;

namespace DbTools.Models
{
    /// <summary>
    /// Контекст БД
    /// </summary>
    public partial class BlogContext : DbContext
    {
        public virtual DbSet<MusicGenre> MusicGenres { get; set; }


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
