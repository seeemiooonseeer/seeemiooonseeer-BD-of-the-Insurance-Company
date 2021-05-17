using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BD_of_the_Insurance_Company.Models;

namespace BD_of_the_Insurance_Company.Data
{
    public class BD_of_the_Insurance_CompanyContext : DbContext
    {
        public BD_of_the_Insurance_CompanyContext (DbContextOptions<BD_of_the_Insurance_CompanyContext> options)
            : base(options)
        {
        }

        public DbSet<BD_of_the_Insurance_Company.Models.Staff> Staff { get; set; }

        public DbSet<BD_of_the_Insurance_Company.Models.Risks> Risks { get; set; }

        public DbSet<BD_of_the_Insurance_Company.Models.Position> Position { get; set; }

        public DbSet<BD_of_the_Insurance_Company.Models.Policy_type> Policy_type { get; set; }

        public DbSet<BD_of_the_Insurance_Company.Models.Policies> Policies { get; set; }

        public DbSet<BD_of_the_Insurance_Company.Models.Groups> Groups { get; set; }

        public DbSet<BD_of_the_Insurance_Company.Models.Client> Client { get; set; }
    }
}
