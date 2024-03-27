using DEMO_TUTOR_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DEMO_TUTOR_MVC.Configurations
{
    public class HoaDonCTCongfig : IEntityTypeConfiguration<HoaDonCT>
    {
        public void Configure(EntityTypeBuilder<HoaDonCT> builder)
        {
            builder.HasKey(x => x.Id);

            //khóa ngoại 
            builder.HasOne(p => p.HoaDon).WithMany(p => p.HoaDonCTs)
               .HasForeignKey(p => p.IdHD).HasConstraintName("FK_HD_HDCT");
        }

    }
}

