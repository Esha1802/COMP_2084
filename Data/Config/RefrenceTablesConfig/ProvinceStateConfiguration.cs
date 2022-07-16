using COMP_2084_Assigment.Models.ReferenceTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace COMP_2084_Assigment.Data.Config.RefrenceTablesConfig
{
    public class ProvinceStateConfiguration : IEntityTypeConfiguration<ProvinceState>
    {
        public void Configure(EntityTypeBuilder<ProvinceState> builder)
        {
            builder
                .HasKey(a => a.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .HasOne(m => m.Country)
                .WithMany(a => a.ProvinceStates)
                .HasForeignKey(m => m.CountryId);

            builder
                .ToTable("ProvinceState");
        }
    }
}
