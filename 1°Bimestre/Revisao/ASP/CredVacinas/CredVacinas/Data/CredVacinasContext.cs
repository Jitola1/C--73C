using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CredVacinas.Models;

namespace CredVacinas.Data
{
    public class CredVacinasContext : DbContext
    {
        public CredVacinasContext (DbContextOptions<CredVacinasContext> options)
            : base(options)
        {
        }

        public DbSet<CredVacinas.Models.Setor> Setor { get; set; } = default!;

        public DbSet<CredVacinas.Models.Vacina>? Vacina { get; set; }

        public DbSet<CredVacinas.Models.Enfermeiro>? Enfermeiro { get; set; }
    }
}
