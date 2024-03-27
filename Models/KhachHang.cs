using System;
using System.Collections.Generic;

namespace DEMO_TUTOR_MVC.Models
{
    public partial class KhachHang
    {
        public string Sdt { get; set; } = null!;
        public string? Ten { get; set; }
        public string? Diachi { get; set; }
        public string? Email { get; set; }
        public int? Point { get; set; }
        public int? Status { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
