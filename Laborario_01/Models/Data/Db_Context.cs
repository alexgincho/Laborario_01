using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborario_01.Models.Data
{
    public class Db_Context: IdentityDbContext
    {
        public Db_Context(DbContextOptions<Db_Context> options)
            : base(options)
        {

        }
        public DbSet<Producto> productos { get; set; }
    }
}
