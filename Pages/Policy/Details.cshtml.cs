using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_of_the_Insurance_Company.Data;
using BD_of_the_Insurance_Company.Models;

namespace BD_of_the_Insurance_Company.Pages.Policy_type_
{
    public class DetailsModel : PageModel
    {
        private readonly BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext _context;

        public DetailsModel(BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext context)
        {
            _context = context;
        }

        public Policy_type Policy_type { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Policy_type = await _context.Policy_type.FirstOrDefaultAsync(m => m.ID == id);

            if (Policy_type == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
