using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace DB_Construction.Models
{
    public class TypeOfJobs
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PriceOfWork { get; set; }
        public DbSet<Materials> Material3ID { get; set; }
        public DbSet<Materials> Material2ID { get; set; }
        public DbSet<Materials> Material1ID { get; set; }
    }
}
