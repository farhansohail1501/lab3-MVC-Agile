using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab3_MVC_Agile.Models;

namespace lab3_MVC_Agile.Data
{
    public class lab3_MVC_AgileContext : DbContext
    {
        public lab3_MVC_AgileContext (DbContextOptions<lab3_MVC_AgileContext> options)
            : base(options)
        {
        }

        public DbSet<lab3_MVC_Agile.Models.Movie> Movie { get; set; } = default!;
    }
}
