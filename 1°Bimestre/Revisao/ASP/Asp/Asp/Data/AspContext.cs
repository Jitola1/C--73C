using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp.Models;

namespace Asp.Data
{
    public class AspContext : DbContext
    {
        public AspContext (DbContextOptions<AspContext> options)
            : base(options)
        {
        }

        public DbSet<Asp.Models.Aluno> Aluno { get; set; } = default!;
    }
}
