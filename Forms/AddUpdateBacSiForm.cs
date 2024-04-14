using ezbooking.Models;
using ezbooking.Shared;
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

namespace ezbooking.Forms
{
    public partial class AddUpdateBacSiForm : Form
    {
        private readonly AppDbContext _appDbContext;
        private List<DichVuKT> _dichVuKTs = [];
        private bool _isUpdate = false;
        public int IdBacSiKTV = 0;
        public event EventHandler DataChanged;
        public AddUpdateBacSiForm(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            InitializeComponent();
        }

        private void AddUpdateBacSiForm_Load(object sender, EventArgs e)
        {
            if(!_isUpdate)
            {
                LoadDvktList();
            }
        }

        private void LoadDvktList()
        {
            // Load data to checklist
            _dichVuKTs = _appDbContext.DichVuKTs.OrderByDescending(o => o.TenDichVu)
                                                .AsEnumerable()
                                                .DistinctBy(o => o.TenDichVu)
                                                .ToList();
            foreach (var dichVuKT in _dichVuKTs)
            {
                if (doctorDvktCheckList.Items.All(x => x.Text != dichVuKT.TenDichVu))
                {
                    doctorDvktCheckList.Items.Add(dichVuKT.TenDichVu);
                }
            }
        }
        private void doctorSave_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedDichVuKTs = new List<DichVuKT>();
                foreach (var item in doctorDvktCheckList.Items)
                {
                    if (item.Checked == true)
                    {
                        var dichVuKT = _dichVuKTs.FirstOrDefault(d => d.TenDichVu == item.Text);
                        selectedDichVuKTs.Add(dichVuKT);
                    };
                }

                // Save data to database
                var bacSiKTV = new BacSiKTV
                {
                    TenBacSiKTV = doctorName.Text,
                    DiaChi = doctorAddress.Text,
                    SoDienThoai = doctorPhone.Text,
                    Email = doctorEmail.Text,
                    TrangThai = "active",
                    GioBatDau = Helpers.GetTime(doctorStartTime.Text),
                    GioKetThuc = Helpers.GetTime(doctorEndTime.Text),
                    DichVuKTs = selectedDichVuKTs
                };

                if(!_isUpdate)
                {
                    _appDbContext.Add(bacSiKTV);
                    _appDbContext.SaveChanges();
                }
                else
                {
                    var toUpdate = _appDbContext.BacSiKTVs
                        .Include(x => x.DichVuKTs)
                        .FirstOrDefault(x => x.Id == IdBacSiKTV);

                    toUpdate.TenBacSiKTV = bacSiKTV.TenBacSiKTV;
                    toUpdate.DiaChi = bacSiKTV.DiaChi;
                    toUpdate.SoDienThoai = bacSiKTV.SoDienThoai;
                    toUpdate.Email = bacSiKTV.Email;
                    toUpdate.TrangThai = bacSiKTV.TrangThai;
                    toUpdate.GioBatDau = bacSiKTV.GioBatDau;
                    toUpdate.GioKetThuc = bacSiKTV.GioKetThuc;
                    toUpdate.DichVuKTs = selectedDichVuKTs;

                    _appDbContext.SaveChanges();
                }

                // Trigger the DataInserted event
                OnDataChanged(EventArgs.Empty);


                MessageBox.Show("Thao tác thành công!");

                // close the form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearForm()
        {
            doctorName.Text = "";
            doctorAddress.Text = "";
            doctorPhone.Text = "";
            doctorEmail.Text = "";
            doctorStartTime.Text = "";
            doctorEndTime.Text = "";
            Helpers.UnCheckAllItems(doctorDvktCheckList);
        }

        // Method to trigger the DataChanged event
        protected virtual void OnDataChanged(EventArgs e)
        {
            DataChanged?.Invoke(this, e);
        }

        public void LoadData(int IdBacSiKTV)
        {
            _isUpdate = true;
            var bacSiKTV = _appDbContext.BacSiKTVs
                                        .Include(a => a.DichVuKTs)
                                        .FirstOrDefault(x => x.Id == IdBacSiKTV);
            if (bacSiKTV != null)
            {
                doctorName.Text = bacSiKTV.TenBacSiKTV;
                doctorAddress.Text = bacSiKTV.DiaChi;
                doctorPhone.Text = bacSiKTV.SoDienThoai;
                doctorEmail.Text = bacSiKTV.Email;
                doctorStartTime.Text = bacSiKTV.GioBatDau.ToString();
                doctorEndTime.Text = bacSiKTV.GioKetThuc.ToString();

                LoadDvktList();
                foreach (var item in doctorDvktCheckList.Items)
                {
                    var dichVuKT = _dichVuKTs.FirstOrDefault(d => d.TenDichVu == item.Text);
                    if (bacSiKTV.DichVuKTs != null && bacSiKTV.DichVuKTs.Contains(dichVuKT))
                    {
                        item.Checked = true;
                    }
                }
            }
        }

        private void AddUpdateBacSiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ClearForm();
        }
    }

}
