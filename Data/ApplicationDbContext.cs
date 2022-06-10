using COMP_2084_Assigment_1.Data.Config;
using COMP_2084_Assigment_1.Models.Landlord;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace COMP_2084_Assigment_1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Landlord> Landlords { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new LandlordConfiguration());
            base.OnModelCreating(builder);
        }
    }
}