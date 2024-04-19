using ezbooking.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ezbooking.Forms
{
    public partial class AddUpdateDVKTForm : Form
    {
        private readonly AppDbContext _appDbContext;
        private bool _isUpdate = false;
        private ThietBi thietBi;
        public int IdDVKT = 0;
        public event EventHandler DataChanged;
        public AddUpdateDVKTForm(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            InitializeComponent();
        }
        private void AddUpdateDVKTForm_Load(object sender, EventArgs e)
        {
            // Load data to checklist
            var listThietbi = _appDbContext.ThietBis.ToList();

            var data = _appDbContext.ThietBis.Select(oneData => new {
                Value = oneData.Id,
                Text = oneData.TenThietBi
            }).ToList();
            ComboThietBi.ValueMember = "Value";
            ComboThietBi.DisplayMember = "Text";
            ComboThietBi.DataSource = data;
        }
        protected virtual void OnDataChanged(EventArgs e)
        {
            DataChanged?.Invoke(this, e);
        }

        public void LoadData(int id)
        {
            _isUpdate = true;
            var dvkt = _appDbContext.DichVuKTs.FirstOrDefault(x => x.Id == id);
            if (dvkt != null)
            {
                serviceNameTxt.Text = dvkt.TenDichVu;
                ChiPhiTxt.Text = dvkt.ChiPhi.ToString();
                TimeTxt.Text = dvkt.ThoiGian.ToString();

            }
        }

        private void ClearForm()
        {
            serviceNameTxt.Text = "";
            ChiPhiTxt.Text = "";
            TimeTxt.Text = "";
        }

        private void AddUpdateDVTKForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ClearForm();
        }

        private void save_service_btn_Click(object sender, EventArgs e)
        {
            try
            {
                thietBi = _appDbContext.ThietBis.FirstOrDefault(x => x.Id == int.Parse(ComboThietBi.SelectedValue.ToString()));
                var item = new DichVuKT()
                {
                    TenDichVu = serviceNameTxt.Text,
                    ChiPhi = int.Parse(ChiPhiTxt.Text),
                    ThoiGian = int.Parse(TimeTxt.Text),
                    ThietBi = thietBi,
                };

                if (!_isUpdate)
                {
                    _appDbContext.Add(item);
                    _appDbContext.SaveChanges();
                }
                else
                {
                    var toUpdate = _appDbContext.DichVuKTs.FirstOrDefault(x => x.Id == IdDVKT);

                    toUpdate.TenDichVu = item.TenDichVu;
                    toUpdate.ChiPhi = item.ChiPhi;
                    toUpdate.ThoiGian = item.ThoiGian;

                    _appDbContext.SaveChanges();
                }


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
    }
}
