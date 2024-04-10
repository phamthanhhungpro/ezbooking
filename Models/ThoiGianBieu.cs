namespace ezbooking.Models
{
    public class ThoiGianBieu : BaseEntity
    {
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public int IdDichVuKT { get; set; }
        public DichVuKT DichVuKT { get; set; }
        public int IdBacSiKTV { get; set; }
        public BacSiKTV BacSiKTV { get; set; }
        public int IdBenhNhan { get; set; }
        public BenhNhan BenhNhan { get; set; }
    }
}
