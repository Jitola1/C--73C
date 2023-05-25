using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CredVacinas.Data;
using CredVacinas.Models;

namespace CredVacinas.Pages.EnfeCrud
{
    public class IndexModel : PageModel
    {
        private readonly CredVacinas.Data.CredVacinasContext _context;

        public IndexModel(CredVacinas.Data.CredVacinasContext context)
        {
            _context = context;
        }

        public IList<Enfermeiro> Enfermeiro { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Enfermeiro != null)
            {
                Enfermeiro = await _context.Enfermeiro.ToListAsync();
            }
        }
    }
}
