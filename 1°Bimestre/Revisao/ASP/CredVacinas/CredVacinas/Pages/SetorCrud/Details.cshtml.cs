using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CredVacinas.Data;
using CredVacinas.Models;

namespace CredVacinas.Pages.SetorCrud
{
    public class DetailsModel : PageModel
    {
        private readonly CredVacinas.Data.CredVacinasContext _context;

        public DetailsModel(CredVacinas.Data.CredVacinasContext context)
        {
            _context = context;
        }

      public Setor Setor { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Setor == null)
            {
                return NotFound();
            }

            var setor = await _context.Setor.FirstOrDefaultAsync(m => m.Id == id);
            if (setor == null)
            {
                return NotFound();
            }
            else 
            {
                Setor = setor;
            }
            return Page();
        }
    }
}
