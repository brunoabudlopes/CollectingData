using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using assignment02.Models;

namespace Assignment2.Models
{
    public class Assignment2Context : DbContext
    {
        public Assignment2Context (DbContextOptions<Assignment2Context> options)
            : base(options)
        {
        }

        public DbSet<assignment02.Models.Member> Member { get; set; }
    }
}
