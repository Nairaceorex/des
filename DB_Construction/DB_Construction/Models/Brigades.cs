using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace DB_Construction.Models
{
    public class Brigades
    {
        
        public long ID { get; set; }
        public DbSet<Staff> Staff3ID { get; set; }
        public DbSet<Staff> Employee2ID { get; set; }
        public DbSet<Staff> Employee1ID { get; set; }
    }
}
