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
    public partial class AddUpdateBenhNhanForm : Form
    {
        private readonly AppDbContext _appDbContext;
        private List<DichVuKT> _dichVuKTs = [];

        private bool _isUpdate = false;
        public int IdBenhNhan = 0;
        public event EventHandler DataChanged;

        public AddUpdateBenhNhanForm(AppDbContext appDbContext)
        {
            InitializeComponent();
            _appDbContext = appDbContext;
        }

        private void AddUpdateBenhNhanForm_Load(object sender, EventArgs e)
        {
            // Load data to checklist
            _dichVuKTs = _appDbContext.DichVuKTs.OrderByDescending(o => o.TenDichVu)
                                                .AsEnumerable()
                                                .DistinctBy(o => o.TenDichVu)
                                                .ToList();
            foreach (var dichVuKT in _dichVuKTs)
            {
                if (benhnhanDvkts.Items.All(x => x.Text != dichVuKT.TenDichVu))
                {
                    benhnhanDvkts.Items.Add(dichVuKT.TenDichVu);
                }
            }

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedDichVuKTs = new List<DichVuKT>();
                foreach (var item in benhnhanDvkts.Items)
                {
                    if (item.Checked == true)
                    {
                        var dichVuKT = _dichVuKTs.FirstOrDefault(d => d.TenDichVu == item.Text);
                        selectedDichVuKTs.Add(dichVuKT);
                    };
                }

                // Save data to database
                var benhNhan = new BenhNhan
                {
                    TenBenhNhan = name.Text,
                    SoDienThoai = phone.Text,
                    DiaChi = address.Text,
                    DichVuKTs = selectedDichVuKTs
                };

                if(!_isUpdate)
                {
                    _appDbContext.Add(benhNhan);
                    _appDbContext.SaveChanges();
                }
                else
                {
                    var toUpdate = _appDbContext.BenhNhans
                        .Include(x => x.DichVuKTs)
                        .FirstOrDefault(x => x.Id == IdBenhNhan);

                    toUpdate.TenBenhNhan = benhNhan.TenBenhNhan;
                    toUpdate.SoDienThoai = benhNhan.SoDienThoai;
                    toUpdate.DiaChi = benhNhan.DiaChi;
                    toUpdate.DichVuKTs = benhNhan.DichVuKTs;

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
            name.Text = "";
            phone.Text = "";
            address.Text = "";
            Helpers.UnCheckAllItems(benhnhanDvkts);
        }

        // Method to trigger the DataInserted event
        protected virtual void OnDataChanged(EventArgs e)
        {
            DataChanged?.Invoke(this, e);
        }

        private void AddUpdateBenhNhanForm_Close(object sender, EventArgs e)
        {
            ClearForm();
        }

        public void LoadData(int id)
        {
            _isUpdate = true;
            var benhNhan = _appDbContext.BenhNhans.FirstOrDefault(x => x.Id == IdBenhNhan);
            if (benhNhan != null)
            {
                name.Text = benhNhan.TenBenhNhan;
                address.Text = benhNhan.DiaChi;
                phone.Text = benhNhan.SoDienThoai;

                foreach (var item in benhnhanDvkts.Items)
                {
                    var dichVuKT = _dichVuKTs.FirstOrDefault(d => d.TenDichVu == item.Text);
                    if (benhNhan.DichVuKTs != null && benhNhan.DichVuKTs.Contains(dichVuKT))
                    {
                        item.Checked = true;
                    }
                }
            }
        }
    }
}
