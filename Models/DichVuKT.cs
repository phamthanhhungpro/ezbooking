namespace ezbooking.Models
{
    public class DichVuKT : BaseEntity
    {
        public string TenDichVu { get; set; }
        public int ChiPhi { get; set; }
        public int ThoiGian { get; set; }
        public ThietBi? ThietBi { get; set; }
        public ICollection<BacSiKTV> BacSiKTVs { get; set; }
    }
}
