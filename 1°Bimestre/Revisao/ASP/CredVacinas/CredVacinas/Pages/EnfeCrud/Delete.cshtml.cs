﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly CredVacinas.Data.CredVacinasContext _context;

        public DeleteModel(CredVacinas.Data.CredVacinasContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Enfermeiro Enfermeiro { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Enfermeiro == null)
            {
                return NotFound();
            }

            var enfermeiro = await _context.Enfermeiro.FirstOrDefaultAsync(m => m.Id == id);

            if (enfermeiro == null)
            {
                return NotFound();
            }
            else 
            {
                Enfermeiro = enfermeiro;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Enfermeiro == null)
            {
                return NotFound();
            }
            var enfermeiro = await _context.Enfermeiro.FindAsync(id);

            if (enfermeiro != null)
            {
                Enfermeiro = enfermeiro;
                _context.Enfermeiro.Remove(Enfermeiro);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
