namespace ezbooking.Models
{
    public class BenhNhan : BaseEntity
    {
        public string TenBenhNhan { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public ICollection<DichVuKT> DichVuKTs { get; set;}
        public ICollection<ThoiGianBieu> ThoiGianBieus { get; set; }
    }
}
