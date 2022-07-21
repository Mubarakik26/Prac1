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
    public class IndexModel : PageModel
    {
        private readonly Prac1.Model.AuthDbContext _context;

        public IndexModel(Prac1.Model.AuthDbContext context)
        {
            _context = context;
        }

        public IList<StudentModel> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
