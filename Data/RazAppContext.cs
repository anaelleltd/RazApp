using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazApp.Models;

namespace RazApp.Data
{
    public class RazAppContext : DbContext
    {
        public RazAppContext (DbContextOptions<RazAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazApp.Models.Book> Book { get; set; }
    }
}
