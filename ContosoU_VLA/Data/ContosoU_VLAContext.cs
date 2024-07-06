using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoU_VLA.Models;

namespace ContosoU_VLA.Data
{
    public class ContosoU_VLAContext : DbContext
    {
        public ContosoU_VLAContext (DbContextOptions<ContosoU_VLAContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoU_VLA.Models.Course> Course { get; set; } = default!;

        public DbSet<ContosoU_VLA.Models.Enrollment>? Enrollment { get; set; }

        public DbSet<ContosoU_VLA.Models.Student>? Student { get; set; }
    }
}
