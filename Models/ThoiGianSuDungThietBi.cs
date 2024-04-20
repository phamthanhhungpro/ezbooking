namespace ezbooking.Models
{
    public class ThoiGianSuDungThietBi : BaseEntity
    {
        public ThietBi ThietBi { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
    }
}
