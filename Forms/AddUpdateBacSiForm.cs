using ezbooking.Models;
using ezbooking.Shared;
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
        public event EventHandler DataChanged;
        public AddUpdateBacSiForm(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            InitializeComponent();
            ClearForm();
        }

        private void AddUpdateBacSiForm_Load(object sender, EventArgs e)
        {
            // Load data to checklist
            _dichVuKTs = _appDbContext.DichVuKTs.OrderByDescending(o => o.TenDichVu)
                                                .ToList();
            foreach (var dichVuKT in _dichVuKTs)
            {
                doctorDvktCheckList.Items.Add(dichVuKT.TenDichVu);
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

                _appDbContext.Add(bacSiKTV);
                _appDbContext.SaveChanges();

                MessageBox.Show("Thêm bác sĩ - KTV thành công!");
                ClearForm();

                // Trigger the DataInserted event
                OnDataChanged(EventArgs.Empty);
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
            _dichVuKTs.Clear();
            doctorDvktCheckList.Items.Clear();
        }

        // Method to trigger the DataInserted event
        protected virtual void OnDataChanged(EventArgs e)
        {
            DataChanged?.Invoke(this, e);
        }
    }

}
