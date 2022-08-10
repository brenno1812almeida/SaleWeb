using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaleWeb.Models;

namespace SaleWeb.Data
{
    public class SaleWebContext : DbContext
    {
        public SaleWebContext (DbContextOptions<SaleWebContext> options)
            : base(options)
        {
        }

        public DbSet<SaleWeb.Models.Department> Department { get; set; }
    }
}
