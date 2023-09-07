using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RainbowSchoolP.Model;

namespace RainbowSchoolP.Data
{
    public class RainbowSchoolPDbContext : DbContext
    {
        public RainbowSchoolPDbContext (DbContextOptions<RainbowSchoolPDbContext> options)
            : base(options)
        {
        }

        public DbSet<RainbowSchoolP.Model.RainBowSchool> RainBowSchool { get; set; } = default!;
    }
}
