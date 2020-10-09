using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DB_Construction.Models
{
    public class Materials
    {
        
        public long ID { get; set; }
        public string Name { get; set; }
        public string Packaging { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

    }
}
