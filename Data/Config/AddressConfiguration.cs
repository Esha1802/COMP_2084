using COMP_2084_Assigment.Models.PrimaryTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace COMP_2084_Assigment.Data.Config
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder
                .HasKey(a => a.Id);
            builder
                .Property(m => m.Id)
                .UseIdentityColumn();
            builder
                .Property(m => m.AddressLine1)
                .HasMaxLength(100);
            builder
                .Property(m => m.AddressLine2)
                .HasMaxLength(100);
            builder
                .Property(m => m.City)
                .HasMaxLength(100);
            builder
                .Property(m => m.PostalZipCode)
                .HasMaxLength(10);
            builder
                .HasOne(m => m.ProvinceState)
                .WithMany(a => a.Addresses)
                .HasForeignKey(m => m.ProvinceStateId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
