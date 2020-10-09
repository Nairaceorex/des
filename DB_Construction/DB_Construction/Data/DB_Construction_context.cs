using DB_Construction.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB_Construction.Data
{
    public class DB_Construction_context : DbContext
    {
        
        public DbSet<Staff>Staffs{get; set;}
        public DbSet<Brigades>Brigades{get; set;}
        public DbSet<Positions>Positions{get; set;}
        public DbSet<Materials>Materials{get; set;}
        public DbSet<Brigades>TypesOfJobs{get; set;}
        public DbSet<Customers>Customers{get; set;}
        public DbSet<Orders>Orders{get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>((or =>
            {
                or.HasNoKey();
            }));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Construction");
        }
    }
}
