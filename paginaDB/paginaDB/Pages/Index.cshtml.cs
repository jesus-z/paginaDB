using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using paginaDB.Data;
using paginaDB.Models;

namespace paginaDB.Pages
{
    public class IndexModel : PageModel
    {
        private readonly paginaDB.Data.TareaDbContext _context;

        public IndexModel(paginaDB.Data.TareaDbContext context)
        {
            _context = context;
        }

        public IList<Tarea> Tarea { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Tarea = await _context.Tareas.ToListAsync();
        }
    }
}
