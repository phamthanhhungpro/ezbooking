namespace ezbooking.Models
{
    public class ThietBi : BaseEntity
    {
        public string TenThietBi { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }
        public int SoLuong { get; set; }
        public int ThoiGianCachNhau { get; set; }
    }
}
