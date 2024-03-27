using DEMO_TUTOR_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DEMO_TUTOR_MVC.Configurations
{
    public class SanPhamConfig : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable(" Sản Phẩm ");

            builder.HasKey(x => x.Id);
           
            builder.Property(x=>x.Name).IsRequired().HasColumnName("Tên SP");
            builder.Property(x=>x.Description).IsRequired().HasColumnType("nvarchar(100)");
        }
    }
}
