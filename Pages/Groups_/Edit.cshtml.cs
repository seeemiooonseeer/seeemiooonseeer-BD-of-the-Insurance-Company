using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BD_of_the_Insurance_Company.Data;
using BD_of_the_Insurance_Company.Models;

namespace BD_of_the_Insurance_Company.Pages.Groups_
{
    public class EditModel : PageModel
    {
        private readonly BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext _context;

        public EditModel(BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Groups Groups { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Groups = await _context.Groups.FirstOrDefaultAsync(m => m.ID == id);

            if (Groups == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Groups).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupsExists(Groups.ID))
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

        private bool GroupsExists(long id)
        {
            return _context.Groups.Any(e => e.ID == id);
        }
    }
}
