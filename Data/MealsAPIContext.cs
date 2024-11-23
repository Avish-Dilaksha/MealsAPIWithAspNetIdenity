using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MealsAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace MealsAPI.Data
{
    public class MealsAPIContext : IdentityDbContext<IdentityUser>
    {
        public MealsAPIContext (DbContextOptions<MealsAPIContext> options)
            : base(options)
        {
        }

        public DbSet<MealsAPI.Models.Category> Category { get; set; } = default!;
        public DbSet<MealsAPI.Models.Meal> Meal { get; set; } = default!;
    }
}
