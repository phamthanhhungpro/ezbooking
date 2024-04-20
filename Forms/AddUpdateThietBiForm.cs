using ezbooking.Models;

namespace ezbooking.Forms
{
    public partial class AddUpdateThietBiForm : Form
    {
        private readonly AppDbContext _appDbContext;
        private List<ThietBi> _thietBis = [];
        private bool _isUpdate = false;
        public int IdDevice = 0;
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
            _isUpdate = false;
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

                if (!_isUpdate)
                {
                    _appDbContext.Add(thietBi);
                    _appDbContext.SaveChanges();
                }
                else
                {
                    var toUpdate = _appDbContext.ThietBis
                        .FirstOrDefault(x => x.Id == IdDevice);

                    toUpdate.TenThietBi = thietBi.TenThietBi;
                    toUpdate.SoLuong = thietBi.SoLuong;
                    toUpdate.ThoiGianCachNhau = thietBi.ThoiGianCachNhau;
                    toUpdate.MoTa = thietBi.MoTa;

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

        public void LoadData(int IdDevice)
        {
            _isUpdate = true;
            var device = _appDbContext.ThietBis.FirstOrDefault(x => x.Id == IdDevice);
            if (device != null)
            {
                name_device_txt.Text = device.TenThietBi.ToString();
                soluong_device_txt.Text = device.SoLuong.ToString();
                time_device_txt.Text = device.ThoiGianCachNhau.ToString();
                mota_device_txt.Text = device.MoTa.ToString();
            }
        }

        private void AddUpdateThietBiForm_Load(object sender, EventArgs e)
        {

        }


        private void AddUpdateThietBiForm_FormClosing(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
