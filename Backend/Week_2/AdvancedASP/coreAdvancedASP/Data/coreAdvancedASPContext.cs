using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using coreAdvancedASP.Models;

namespace coreAdvancedASP.Data
{
    public class coreAdvancedASPContext : DbContext
    {
        public coreAdvancedASPContext (DbContextOptions<coreAdvancedASPContext> options)
            : base(options)
        {
        }

        public DbSet<coreAdvancedASP.Models.User> User { get; set; } = default!;
    }
}
