using ezbooking.Models;
using ezbooking.Shared;
using ezbooking.Shared.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ezbooking.Forms
{
    public partial class BacSiDoiLichForm : Form
    {
        public int ThoiGianBieuId { get; set; }

        private readonly AppDbContext _appDbContext;
        public event EventHandler DataChanged;

        public BacSiDoiLichForm(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            InitializeComponent();
        }

        private void BacSiDoiLichForm_Load(object sender, EventArgs e)
        {
            var query = _appDbContext.ThoiGianBieus.Include(a => a.BenhNhan)
                .Include(a => a.BacSiKTV)
                .Include(a => a.DichVuKT)
                .Where(a => a.Id == ThoiGianBieuId)
                .Select(a => new ThoiGianBieuDto
                {
                    Id = a.Id,
                    TenBenhNhan = a.BenhNhan.TenBenhNhan,
                    TenBacSi = a.BacSiKTV.TenBacSiKTV,
                    Dvkt = a.DichVuKT.TenDichVu,
                    ThoiGianBatDau = a.ThoiGianBatDau,
                    ThoiGianKetThuc = a.ThoiGianKetThuc
                }).FirstOrDefault();

            tenbacsi.Text = query.TenBacSi;
            tenbenhnhan.Text = query.TenBenhNhan;
            tendichvu.Text = query.Dvkt;
            thoigian.Text = Helpers.GetWorkingTimeRange(query.ThoiGianBatDau, query.ThoiGianKetThuc);

            // get free doctors in the same time

            var thoigianbieu = _appDbContext.ThoiGianBieus
                .Include(a => a.BacSiKTV)
                .Include(a => a.DichVuKT)
                .Where(a => a.ThoiGianBatDau == query.ThoiGianBatDau && a.ThoiGianKetThuc == query.ThoiGianKetThuc)
                .Select(a => new ThoiGianBieuDto
                {
                    Id = a.Id,
                    TenBacSi = a.BacSiKTV.TenBacSiKTV,
                    Dvkt = a.DichVuKT.TenDichVu,
                    ThoiGianBatDau = a.ThoiGianBatDau,
                    ThoiGianKetThuc = a.ThoiGianKetThuc
                }).ToList();

            var freeDoctor = _appDbContext.BacSiKTVs.Include(a => a.DichVuKTs)
                                .Where(a => a.DichVuKTs.Any(b => b.TenDichVu == query.Dvkt))
                .Select(a => new BacSiFreeTime
                {
                    Id = a.Id,
                    Name = a.TenBacSiKTV
                }).ToList()
                .Where(a => !thoigianbieu.Any(b => b.TenBacSi == a.Name))
;

            foreach (var bacsi in freeDoctor)
            {
                bacsi_checkbox.Items.Add(bacsi.Name);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            // get selected bacsi
            var selectedBacSi = bacsi_checkbox.SelectedItem.ToString();
            var bacsi = _appDbContext.BacSiKTVs.FirstOrDefault(a => a.TenBacSiKTV == selectedBacSi);

            if (bacsi != null)
            {
                var thoiGianBieu = _appDbContext.ThoiGianBieus
                    .Include(tgb => tgb.BacSiKTV)
                    .FirstOrDefault(a => a.Id == ThoiGianBieuId);
                thoiGianBieu.BacSiKTV = bacsi;
                _appDbContext.ThoiGianBieus.Update(thoiGianBieu);
                _appDbContext.SaveChanges();
                MessageBox.Show("Đã đổi lịch thành công");
                OnDataChanged(EventArgs.Empty);
                this.Close();
            }
        }

        // Method to trigger the DataInserted event
        protected virtual void OnDataChanged(EventArgs e)
        {
            DataChanged?.Invoke(this, e);
        }

        // bacsi_checkbox_ItemCheck
        private void bacsi_checkbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // single selection
            Helpers.SingleSelect(bacsi_checkbox, e.Index);
        }

        // Form close event
        private void BacSiDoiLichForm_FormClosed(object sender, EventArgs e)
        {
            // reset the selected index
            bacsi_checkbox.Items.Clear();
        }
    }
}
