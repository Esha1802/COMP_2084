using COMP_2084_Assigment.Models.ReferenceTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace COMP_2084_Assigment.Data.Config.RefrenceTablesConfig
{
    public class UnitTypeConfiguration : IEntityTypeConfiguration<UnitType>
    {
        public void Configure(EntityTypeBuilder<UnitType> builder)
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
                .ToTable("UnitType");
        }
    }
}
