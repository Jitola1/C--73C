using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AulaaspViewControl.Models;

namespace AulaaspViewControl.Data
{
    public class AulaaspViewControlContext : DbContext
    {
        public AulaaspViewControlContext (DbContextOptions<AulaaspViewControlContext> options)
            : base(options)
        {
        }

        public DbSet<AulaaspViewControl.Models.Animal> Animal { get; set; } = default!;
    }
}
