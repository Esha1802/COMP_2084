using COMP_2084_Assigment.Data.Config.PrimaryTablesConfig;
using COMP_2084_Assigment.Data.Config.RefrenceTablesConfig;
using COMP_2084_Assigment.Models.PrimaryTables;
using COMP_2084_Assigment.Models.ReferenceTables;
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
        public DbSet<Country> Countries { get; set; }
        public DbSet<ProvinceState> ProvinceStates { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BuildingType> BuildingTypes { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<Property> Properties { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new LandlordConfiguration());
            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new ProvinceStateConfiguration());
            builder.ApplyConfiguration(new AddressConfiguration());
            builder.ApplyConfiguration(new BuildingTypeConfiguration());
            builder.ApplyConfiguration(new UnitTypeConfiguration());
            builder.ApplyConfiguration(new PropertyConfiguration());

            base.OnModelCreating(builder);
        }
    }
}