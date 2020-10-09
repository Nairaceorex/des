using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DB_Construction.Models
{
    public class Orders
    {
        public int Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string CompletionMark { get; set; }
        public string AboutPayment { get; set; }
        public DbSet<Customers> TypesOfJobID { get; set; }
        public DbSet<Brigades> CustomerID { get; set; }
        public DbSet<Brigades> BrigadeID { get; set; }
        public DbSet<Staff> EmployeeID { get; set; }
    }
}
