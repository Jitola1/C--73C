using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Asp.Data;
using Asp.Models;

namespace Asp.Pages.Alunos
{
    public class CreateModel : PageModel
    {
        private readonly Asp.Data.AspContext _context;

        public CreateModel(Asp.Data.AspContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Aluno Aluno { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Aluno == null || Aluno == null)
            {
                return Page();
            }

            _context.Aluno.Add(Aluno);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
