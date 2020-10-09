using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace DB_Construction.Models
{
    public class Staff
    { 
        public long ID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string PassportData { get; set; }
        public DbSet<Positions> PositionID { get; set; }
        public DbSet<Brigades> BrigadeID { get; set; }
    }
}
