namespace ezbooking.Models
{
    public class BacSiKTV : BaseEntity
    {
        public string TenBacSiKTV { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string TrangThai { get; set; }
        public bool IsKtv { get; set; }
        public TimeOnly GioBatDau { get; set; }
        public TimeOnly GioKetThuc { get; set; }

        public ICollection<DichVuKT> DichVuKTs { get; set; }
        public ICollection<ThoiGianBieu> ThoiGianBieus { get; set; }
    }
}
