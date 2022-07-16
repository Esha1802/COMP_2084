using COMP_2084_Assigment.Models.PrimaryTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace COMP_2084_Assigment_1.Data.Config
{
    public class LandlordConfiguration : IEntityTypeConfiguration<Landlord>
    {
        public void Configure(EntityTypeBuilder<Landlord> builder)
        {
            builder
                .HasKey(a => a.Id);
            builder
                .Property(m => m.Id)
                .UseIdentityColumn();
        }
    }
}
