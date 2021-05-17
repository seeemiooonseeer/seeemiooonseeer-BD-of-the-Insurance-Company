using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_of_the_Insurance_Company.Data;
using BD_of_the_Insurance_Company.Models;

namespace BD_of_the_Insurance_Company.Pages.Policies_
{
    public class IndexModel : PageModel
    {
        private readonly BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext _context;

        public IndexModel(BD_of_the_Insurance_Company.Data.BD_of_the_Insurance_CompanyContext context)
        {
            _context = context;
        }

        public IList<Policies> Policies { get;set; }
        public IList<Policy_type> Policy_type { get; set; }
        public IList<Client> Client { get; set; }
        public IList<Staff> Staff { get; set; }
        public async Task OnGetAsync()
        {
            Policies = await _context.Policies.ToListAsync();
            Policy_type = await _context.Policy_type.ToListAsync();
            Client = await _context.Client.ToListAsync();
            Staff = await _context.Staff.ToListAsync();
        }
    }
}
