using DEMO_TUTOR_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DEMO_TUTOR_MVC.Configurations
{
    public class KhachHangConfig : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable(nameof(KhachHang));
            builder.HasKey(p => p.Sdt);
        }
    }
}
