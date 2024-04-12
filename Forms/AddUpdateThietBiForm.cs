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
    public partial class AddUpdateThietBiForm : Form
    {
        private readonly AppDbContext _appDbContext;
        private List<ThietBi> _thietBis = [];
        public event EventHandler DataChanged;
        public AddUpdateThietBiForm(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            InitializeComponent();
            ClearForm();
        }

        private void ClearForm()
        {
            name_device_txt.Text = "";
            soluong_device_txt.Text = "";
            time_device_txt.Text = "";
            mota_device_txt.Text = "";
            _thietBis.Clear();
        }

        // Method to trigger the DataInserted event
        protected virtual void OnDataChanged(EventArgs e)
        {
            DataChanged?.Invoke(this, e);
        }

        private void save_device_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Save data to database
                var thietBi = new ThietBi
                {
                    TenThietBi = name_device_txt.Text,
                    SoLuong = int.Parse(soluong_device_txt.Text),
                    ThoiGianCachNhau = int.Parse(time_device_txt.Text),
                    MoTa = mota_device_txt.Text
                };

                _appDbContext.Add(thietBi);
                _appDbContext.SaveChanges();

                MessageBox.Show("Thêm thiết bị thành công!");
                ClearForm();

                // Trigger the DataInserted event
                OnDataChanged(EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
