using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Database.Context
{
    public class EvaluacionTecnicaContext: IdentityDbContext<ApplicationUser>
    {
        public EvaluacionTecnicaContext(DbContextOptions<EvaluacionTecnicaContext> options): base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public new DbSet<Roles> Roles { get; set; }
    }
}
