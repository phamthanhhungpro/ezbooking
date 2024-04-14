namespace ezbooking.Shared.Dtos
{
    public class ThoiGianBieuDto
    {
        public int Id { get; set; }
        public string TenBenhNhan { get; set; }
        public string TenBacSi { get; set; }
        public string Dvkt { get; set; }

        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
    }
}
