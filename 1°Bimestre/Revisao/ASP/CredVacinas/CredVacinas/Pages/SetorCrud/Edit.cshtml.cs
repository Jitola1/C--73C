﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CredVacinas.Data;
using CredVacinas.Models;

namespace CredVacinas.Pages.SetorCrud
{
    public class EditModel : PageModel
    {
        private readonly CredVacinas.Data.CredVacinasContext _context;

        public EditModel(CredVacinas.Data.CredVacinasContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Setor Setor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Setor == null)
            {
                return NotFound();
            }

            var setor =  await _context.Setor.FirstOrDefaultAsync(m => m.Id == id);
            if (setor == null)
            {
                return NotFound();
            }
            Setor = setor;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Setor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SetorExists(Setor.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SetorExists(int id)
        {
          return (_context.Setor?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
