using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZipperMate.Models; 

namespace ZipperMate.Data
{
    public class ZipperContext : DbContext
    {
        public ZipperContext(DbContextOptions<ZipperContext> options)
            : base(options)
        {
        }

        public DbSet<ZipperMate.Models.Zippers> Zippers { get; set; }
    }
}

