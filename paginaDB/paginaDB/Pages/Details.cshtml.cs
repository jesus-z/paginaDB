﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly paginaDB.Data.TareaDbContext _context;

        public DetailsModel(paginaDB.Data.TareaDbContext context)
        {
            _context = context;
        }

        public Tarea Tarea { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarea = await _context.Tareas.FirstOrDefaultAsync(m => m.Id == id);
            if (tarea == null)
            {
                return NotFound();
            }
            else
            {
                Tarea = tarea;
            }
            return Page();
        }
    }
}
