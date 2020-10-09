using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DB_Construction.Models
{
    public class Positions
    {
        
        public long ID { get; set; }
        public string JobTittle { get; set; }
        public int Salary { get; set; }
        public string Duties { get; set; }
        public string Requirements { get; set; }
    }
}
