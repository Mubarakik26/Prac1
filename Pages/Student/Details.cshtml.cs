using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Prac1.Model;

namespace Prac1.Pages.Student
{
    public class DetailsModel : PageModel
    {
        private readonly Prac1.Model.AuthDbContext _context;

        public DetailsModel(Prac1.Model.AuthDbContext context)
        {
            _context = context;
        }

        public StudentModel Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.Id == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
