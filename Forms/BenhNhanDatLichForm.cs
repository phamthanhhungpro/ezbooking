using ezbooking.Models;
using ezbooking.Shared;
using ezbooking.Shared.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ezbooking.Forms
{
    public partial class BenhNhanDatLichForm : Form
    {
        private readonly AppDbContext _appDbContext;
        private readonly AddUpdateDatLichForm _addUpdateDatLichForm;

        public int BenhNhanId = 0;
        public BenhNhanDatLichForm(AppDbContext appDbContext,
                                   AddUpdateDatLichForm addUpdateDatLichForm)
        {
            InitializeComponent();
            _appDbContext = appDbContext;
            _addUpdateDatLichForm = addUpdateDatLichForm;
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
                newItem.SubItems.Add(item.TenBenhNhan.ToString());
                newItem.SubItems.Add(item.Dvkt.ToString());
                newItem.SubItems.Add(item.TenBacSi.ToString());
                newItem.SubItems.Add(Helpers.GetWorkingTimeRange(item.ThoiGianBatDau, item.ThoiGianKetThuc));
                //newItem.SubItems.Add(item.Id.ToString());
                newItem.Tag = item.Id.ToString();

                datlichListView.Items.Add(newItem);
            }
        }

        private void datlichListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BenhNhanDatLichForm_Load(object sender, EventArgs e)
        {
            var data = GetListDatLich();

            if (data.Count > 0)
            {
                FillDataToUI(data);
            }
        }

        private void add_datlich_Click(object sender, EventArgs e)
        {
            _addUpdateDatLichForm.BenhNhanId = BenhNhanId;
            _addUpdateDatLichForm.ShowDialog();
            ////
            //var benhNhan = _appDbContext.BenhNhans.FirstOrDefault(bn => bn.Id == BenhNhanId);
            //var bacSi = _appDbContext.BacSiKTVs.FirstOrDefault(bs => bs.Id == 1);
            //var dvkt = _appDbContext.DichVuKTs.FirstOrDefault(dv => dv.Id == 1);
            //var datlich = new ThoiGianBieu()
            //{
            //    BenhNhan = benhNhan,
            //    BacSiKTV = bacSi,
            //    DichVuKT = dvkt,
            //    ThoiGianBatDau = DateTime.Now,
            //    ThoiGianKetThuc = DateTime.Now
            //};

            //_appDbContext.Add(datlich);
            //_appDbContext.SaveChanges();

            //BenhNhanDatLichForm_Load(sender, e);
        }
    }
}
