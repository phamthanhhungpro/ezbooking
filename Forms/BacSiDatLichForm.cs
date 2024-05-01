using ezbooking.Models;
using ezbooking.Shared;
using ezbooking.Shared.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ezbooking.Forms
{
    public partial class BacSiDatLichForm : Form
    {
        public int BacSiId { get; set; }

        private readonly BacSiDoiLichForm _bacSiDoiLichForm;

        private readonly AppDbContext _appDbContext;

        public BacSiDatLichForm(AppDbContext appDbContext, BacSiDoiLichForm bacSiDoiLichForm)
        {
            _appDbContext = appDbContext;
            InitializeComponent();
            _bacSiDoiLichForm = bacSiDoiLichForm;
        }

        private void BacSiDatLichForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var query = _appDbContext.ThoiGianBieus
                .Include(a => a.BenhNhan)
                .Include(a => a.BacSiKTV)
                .Include(a => a.DichVuKT)
                .Where(a => a.BacSiKTV.Id == BacSiId)
                .Select(a => new ThoiGianBieuDto
                {
                    Id = a.Id,
                    TenBenhNhan = a.BenhNhan.TenBenhNhan,
                    TenBacSi = a.BacSiKTV.TenBacSiKTV,
                    Dvkt = a.DichVuKT.TenDichVu,
                    ThoiGianBatDau = a.ThoiGianBatDau,
                    ThoiGianKetThuc = a.ThoiGianKetThuc
                });

            var data = query.ToList();

            FillDataToUI(data);
        }

        private void FillDataToUI(List<ThoiGianBieuDto> data)
        {
            datlichListView.Items.Clear();
            int stt = 0;
            foreach (var item in data)
            {
                stt++;
                var newItem = new ListViewItem();

                newItem.SubItems.Add(stt.ToString());
                newItem.SubItems.Add(item.TenBenhNhan.ToString());
                newItem.SubItems.Add(item.Dvkt.ToString());
                newItem.SubItems.Add(item.TenBacSi.ToString());
                newItem.SubItems.Add(Helpers.GetWorkingTimeRange(item.ThoiGianBatDau, item.ThoiGianKetThuc));
                newItem.Tag = item.Id.ToString();

                datlichListView.Items.Add(newItem);
            }
        }

        private void edit_datlich_Click(object sender, EventArgs e)
        {
            // Get the selected item
            if (datlichListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một lịch khám để chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = datlichListView.SelectedItems[0];
            var id = selectedItem.Tag.ToString();

            _bacSiDoiLichForm.ThoiGianBieuId = int.Parse(id);
            _bacSiDoiLichForm.ShowDialog();
        }
    }
}
