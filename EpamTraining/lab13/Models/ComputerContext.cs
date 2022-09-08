using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab13.Models
{
    public class ComputerContext:DbContext
    {
        public ComputerContext(DbContextOptions<ComputerContext> options) : base(options)
        {
        }
        public DbSet<Computer> Computers { get; set; }
    }
}
