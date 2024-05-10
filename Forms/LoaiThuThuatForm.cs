using ezbooking.Models;
using ezbooking.Shared;
using ezbooking.Shared.Dtos;
using MaterialSkin;
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
    public partial class LoaiThuThuatForm : Form
    {

        private readonly AppDbContext _context;

        // this ID can be Id bacsi or Id benhnhan
        public int Id = 0;

        // 0: BacSi view ; 1: BenhNhan view
        public int ViewType = 0;
        public LoaiThuThuatForm(AppDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void LoaiThuThuatForm_Load(object sender, EventArgs e)
        {
            // Get the current date
            DateTime currentDate = DateTime.Now.AddDays(19);

            // Get the current month
            int currentMonth = currentDate.Month;
            int currentYear = currentDate.Year;

            DateTime startDateOfMonth = new DateTime(currentYear, currentMonth, 1);

            var groupedData = new List<LoaiThuThuat>();
            if (this.ViewType == 0)
            {
                var data = _context.ThoiGianBieus.Include(tgb => tgb.BacSiKTV)
                    .Include(tgb => tgb.DichVuKT)
                    .Where(tgb => tgb.BacSiKTV.Id == Id)
                    .Where(tgb => tgb.ThoiGianKetThuc >= startDateOfMonth && tgb.ThoiGianKetThuc <= currentDate)
                    .ToList();

                groupedData = data.GroupBy(a => a.DichVuKT.LoaiDichVu)
                                      .Select(a => new LoaiThuThuat
                                      {
                                          Name = data.FirstOrDefault().BacSiKTV.TenBacSiKTV,
                                          LoaiThuThat = a.Key,
                                          SoLuong = a.Count()
                                      })
                                      .ToList();
            }
            else
            {
                var data = _context.ThoiGianBieus.Include(tgb => tgb.BenhNhan)
                                        .Include(tgb => tgb.DichVuKT)
                                        .Where(tgb => tgb.BenhNhan.Id == Id)
                                        .Where(tgb => tgb.ThoiGianKetThuc >= startDateOfMonth && tgb.ThoiGianKetThuc <= currentDate)
                                        .ToList();

                groupedData = data.GroupBy(a => a.DichVuKT.LoaiDichVu)
                                      .Select(a => new LoaiThuThuat
                                      {
                                          Name = data.FirstOrDefault().BenhNhan.TenBenhNhan,
                                          LoaiThuThat = a.Key,
                                          SoLuong = a.Count()
                                      })
                                      .ToList();
            }

            // fill data to UI
            thongke_lstview.Items.Clear();
            int stt = 0;
            foreach (var item in groupedData)
            {
                stt++;
                var newItem = new ListViewItem();

                newItem.SubItems.Add(stt.ToString());
                newItem.SubItems.Add(item.Name);
                newItem.SubItems.Add(item.LoaiThuThat.ToString());
                newItem.SubItems.Add(item.SoLuong.ToString());

                thongke_lstview.Items.Add(newItem);
            }
        }

        private void LoaiThuThuatForm_Close(object sender, EventArgs e)
        {
            thongke_lstview.Items.Clear();
        }
    }
}
