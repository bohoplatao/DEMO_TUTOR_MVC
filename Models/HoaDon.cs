namespace DEMO_TUTOR_MVC.Models
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        public DateTime SellDate { get; set; } // Thời điểm bán 
        public Decimal Total {  get; set; }
        public Guid IdKhachHang { get; set; }
        public int Status { get;set; }
        // tạo navigation để thiết lập quan hệ 
        public virtual KhachHang KhachHang { get; set;}
        public virtual ICollection<HoaDonCT> HoaDonCTs { get; set; }
    }
}
