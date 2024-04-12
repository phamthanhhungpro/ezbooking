namespace ezbooking.Models
{
    public class ThoiGianBieu : BaseEntity
    {
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public DichVuKT DichVuKT { get; set; }
        public BacSiKTV BacSiKTV { get; set; }
        public BenhNhan BenhNhan { get; set; }
    }
}
