using ezbooking.Models;
using ezbooking.Shared;
using ezbooking.Shared.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ezbooking.Forms
{
    public partial class BenhNhanDatLichForm : Form
    {
        private readonly AppDbContext _appDbContext;
        private readonly AddUpdateDatLichForm _addUpdateDatLichForm;
        private readonly DatLichBenhNhanForm _datLichBenhNhanForm;

        public int BenhNhanId = 0;
        public BenhNhanDatLichForm(AppDbContext appDbContext,
                                   AddUpdateDatLichForm addUpdateDatLichForm,
                                   DatLichBenhNhanForm datLichBenhNhanForm)
        {
            InitializeComponent();
            _appDbContext = appDbContext;
            _addUpdateDatLichForm = addUpdateDatLichForm;
            _datLichBenhNhanForm = datLichBenhNhanForm;
            _datLichBenhNhanForm.DataChanged += BenhNhanDatLichForm_Load;
        }

        private List<ThoiGianBieuDto> GetListDatLich()
        {
            var query = _appDbContext.ThoiGianBieus
                .Include(a => a.BenhNhan)
                .Include(a => a.BacSiKTV)
                .Include(a => a.DichVuKT)
                .Where(a => a.BenhNhan.Id == BenhNhanId)
                .Select(a => new ThoiGianBieuDto()
                {
                    Id = a.Id,
                    TenBenhNhan = a.BenhNhan.TenBenhNhan,
                    TenBacSi = a.BacSiKTV.TenBacSiKTV,
                    Dvkt = a.DichVuKT.TenDichVu,
                    ThoiGianBatDau = a.ThoiGianBatDau,
                    ThoiGianKetThuc = a.ThoiGianKetThuc
                });

            var data = query.ToList();

            return data;
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
                newItem.SubItems.Add(item.TenBenhNhan?.ToString());
                newItem.SubItems.Add(item.Dvkt?.ToString());
                newItem.SubItems.Add(item.TenBacSi?.ToString());
                newItem.SubItems.Add(Helpers.GetWorkingTimeRange(item.ThoiGianBatDau, item.ThoiGianKetThuc));
                //newItem.SubItems.Add(item.Id.ToString());
                newItem.Tag = item.Id.ToString();

                datlichListView.Items.Add(newItem);
            }
        }

        private void BenhNhanDatLichForm_Load(object sender, EventArgs e)
        {
            LoadDataToUI();
        }

        private void add_datlich_Click(object sender, EventArgs e)
        {
            _datLichBenhNhanForm.BenhNhanId = BenhNhanId;
            _datLichBenhNhanForm.ShowDialog();
        }

        public void LoadDataToUI()
        {
            var data = GetListDatLich();

            if (data.Count > 0)
            {
                FillDataToUI(data);
            }
        }

        private void delete_datlich_Click(object sender, EventArgs e)
        {
            if (datlichListView.SelectedItems.Count > 0)
            {
                var selectedItem = datlichListView.SelectedItems[0];
                var id = int.Parse(selectedItem.Tag.ToString());
                var toDelete = _appDbContext.ThoiGianBieus.FirstOrDefault(x => x.Id == id);
                _appDbContext.Remove(toDelete);
                _appDbContext.SaveChanges();
                LoadDataToUI();
            }
        }

        private void BenhNhanDatLichForm_Close(object sender, EventArgs e)
        {
            datlichListView.Items.Clear();
            BenhNhanId = 0;
        }

        private void edit_datlich_Click(object sender, EventArgs e)
        {

        }

        private void benhnhan_doilich_btn_Click(object sender, EventArgs e)
        {
            if (datlichListView.SelectedItems.Count > 0)
            {
                var selectedItem = datlichListView.SelectedItems[0];
                var id = int.Parse(selectedItem.Tag.ToString());
                _datLichBenhNhanForm.BenhNhanId = BenhNhanId;
                _datLichBenhNhanForm.ThoiGianBieuId = id;

                _datLichBenhNhanForm.ShowDialog();
            }
        }
    }
}
