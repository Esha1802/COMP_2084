using COMP_2084_Assigment.Models.PrimaryTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace COMP_2084_Assigment.Data.Config.PrimaryTablesConfig
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder
                .HasKey(a => a.Id);
            builder
                .Property(m => m.Id)
                .UseIdentityColumn();
            builder
               .HasOne(m => m.Landlord)
               .WithMany(a => a.Properties)
               .HasForeignKey(m => m.LandlordId)
               .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(m => m.Address)
                .WithOne(a => a.Property)
                .HasForeignKey<Property>(m => m.AddressId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
