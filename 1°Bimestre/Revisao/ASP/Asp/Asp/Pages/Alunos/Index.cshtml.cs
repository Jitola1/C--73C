using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Asp.Data;
using Asp.Models;

namespace Asp.Pages.Alunos
{
    public class IndexModel : PageModel
    {
        private readonly Asp.Data.AspContext _context;

        public IndexModel(Asp.Data.AspContext context)
        {
            _context = context;
        }

        public IList<Aluno> Aluno { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Aluno != null)
            {
                Aluno = await _context.Aluno.ToListAsync();
            }
        }
    }
}
