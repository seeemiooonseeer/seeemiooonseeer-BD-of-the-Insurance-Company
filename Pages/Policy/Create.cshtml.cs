using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BD_of_the_Insurance_Company.Data;
using BD_of_the_Insurance_Company.Models;

namespace BD_of_the_Insurance_Company.Pages.Policy_type_
{
    public class CreateModel : PageModel
    {
        private readonly BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext _context;

        public CreateModel(BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Policy_type Policy_type { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Policy_type.Add(Policy_type);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
