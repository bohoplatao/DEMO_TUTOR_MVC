namespace DEMO_TUTOR_MVC.Models
{
    public class SanPham
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description {get;set;}
        public decimal Price { get; set;}
        public decimal Stock  { get; set;}// So luong ton 

        public int Status { get; set; }

        public virtual ICollection<HoaDonCT> HoaDonCTs { get; set; }
        
    }
}
