using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lab13.Models
{
    public class Computer
    {
        [Key]
        public int ComputerId { get; set; }
        [Column("nvarchar(50)")]
        [Required]
        public string Name { get; set; }
        [Column("money")]
        
        public double Price { get; set; }
    }
}
