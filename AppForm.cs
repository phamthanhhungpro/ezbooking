using ezbooking.Forms;
using ezbooking.Models;
using ezbooking.Shared;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ezbooking;

public partial class AppForm : MaterialForm
{
    private readonly AppDbContext _appDbContext;
    private readonly AddUpdateBacSiForm _addUpdateBacSiForm;
    private readonly AddUpdateThietBiForm _addUpdateThietBiForm;
    public AppForm(AppDbContext appDbContext,
                   AddUpdateBacSiForm addUpdateBacSiForm,
                   AddUpdateThietBiForm addUpdateThietBiForm)
    {
        InitializeComponent();

        this.FormClosed += AppForm_FormClosed;

        // Set the form to full screen when it is loaded
        this.WindowState = FormWindowState.Maximized;

        // Apply material skin
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = false;

        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        materialSkinManager.ColorScheme = new ColorScheme(
                                             Primary.Blue600, // Primary color
                                             Primary.Blue700, // Primary dark color
                                             Primary.Blue200, // Primary light color
                                             Accent.Blue700,  // Accent color
                                             TextShade.WHITE   // Text color
                                         );

        _appDbContext = appDbContext;
        _addUpdateBacSiForm = addUpdateBacSiForm;
        _addUpdateThietBiForm = addUpdateThietBiForm;

        materialTabControl1.SelectedIndexChanged += TabChanged;
        _addUpdateBacSiForm.DataChanged += TabChanged;
        _addUpdateThietBiForm.DataChanged += TabChanged;
    }

    private void AppForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void AppForm_Load(object sender, EventArgs e)
    {
        LoadTabBacSiKtv();
    }

    private void TabChanged(object sender, EventArgs e)
    {
        switch (materialTabControl1.SelectedIndex)
        {
            case 0:
                // load tab 1 here
                LoadTabBacSiKtv();
                break;
            case 1:
                Console.WriteLine("Tab 2");
                break;
            case 2:
                LoadTabThietBi();
                break;
            default:
                break;
        }
    }

    private void LoadTabBacSiKtv()
    {
        var data = _appDbContext.BacSiKTVs.OrderByDescending(o => o.CreatedAt).ToList();

        FillDataToDoctorListView(data);
    }

    private void edit_doctor_Click(object sender, EventArgs e)
    {
        if (doctorListView.SelectedItems.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn bác sĩ cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        // Get selected row data
        var selectedRow = doctorListView.SelectedItems[0];
        var id = selectedRow.SubItems[7].Text;

        if (id == null)
        {
            MessageBox.Show("Vui lòng chọn bác sĩ cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        // Open a new form and pass data into it for update
        _addUpdateBacSiForm.IdBacSiKTV = int.Parse(id);
        _addUpdateBacSiForm.LoadData(int.Parse(id));

        _addUpdateBacSiForm.ShowDialog();
    }

    private void add_doctor_btn_Click(object sender, EventArgs e)
    {
        // Open a new form
        _addUpdateBacSiForm.ShowDialog();
    }

    private void doctorListView_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void searchTextBox_TextChanged(object sender, EventArgs e)
    {
        var data = _appDbContext.BacSiKTVs.ToList();

        if (searchTextBox.Text != null)
        {
            data = data.Where(x => x.TenBacSiKTV.ToLower().Contains(searchTextBox.Text.ToLower(), StringComparison.OrdinalIgnoreCase)).ToList();
        }
        else
        {
            return;
        }

        FillDataToDoctorListView(data);
    }

    private void FillDataToDoctorListView(List<BacSiKTV> data)
    {
        doctorListView.Items.Clear();
        int stt = 0;
        foreach (var item in data)
        {
            stt++;
            var newItem = new ListViewItem();

            newItem.SubItems.Add(stt.ToString());
            newItem.SubItems.Add(item.TenBacSiKTV);
            newItem.SubItems.Add(item.SoDienThoai);
            newItem.SubItems.Add(item.DiaChi);
            newItem.SubItems.Add(item.Email);
            newItem.SubItems.Add(Helpers.GetWorkingTimeRange(item.GioBatDau, item.GioKetThuc));
            newItem.SubItems.Add(item.Id.ToString());

            doctorListView.Items.Add(newItem);
        }
    }

    private void delete_doctor_Click(object sender, EventArgs e)
    {
        // Get selected row data
        if (doctorListView.SelectedItems.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn bác sĩ cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        var selectedRow = doctorListView.SelectedItems[0];
        var id = selectedRow.SubItems[7].Text;

        if (id == null)
        {
            MessageBox.Show("Vui lòng chọn bác sĩ cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        var toDelete = _appDbContext.BacSiKTVs.FirstOrDefault(x => x.Id == int.Parse(id));
        _appDbContext.BacSiKTVs.Remove(toDelete);
        _appDbContext.SaveChanges();

        LoadTabBacSiKtv();

        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void LoadTabThietBi()
    {
        var data = _appDbContext.ThietBis.OrderByDescending(o => o.CreatedAt).ToList();

        FillDataToDeviceListView(data);
    }

    private void FillDataToDeviceListView(List<ThietBi> data)
    {
        deviceListView.Items.Clear();
        int stt = 0;
        foreach (var item in data)
        {
            stt++;
            var newItem = new ListViewItem();

            newItem.SubItems.Add(stt.ToString());
            newItem.SubItems.Add(item.TenThietBi);
            newItem.SubItems.Add(item.SoLuong.ToString());
            newItem.SubItems.Add(item.ThoiGianCachNhau.ToString());
            newItem.SubItems.Add(item.Id.ToString());

            deviceListView.Items.Add(newItem);
        }
    }

    private void searchDeviceTxt_TextChanged(object sender, EventArgs e)
    {
        var data = _appDbContext.ThietBis.ToList();

        if (searchTextBox.Text != null)
        {
            data = data.Where(x => x.TenThietBi.ToLower().Contains(searchTextBox.Text.ToLower(), StringComparison.OrdinalIgnoreCase)).ToList();
        }
        else
        {
            return;
        }

        FillDataToDeviceListView(data);
    }

    private void add_device_btn_Click(object sender, EventArgs e)
    {
        // Open a new form
        _addUpdateThietBiForm.ShowDialog();
    }

    private void update_device_btn_Click(object sender, EventArgs e)
    {
        if (deviceListView.SelectedItems.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn thiết bị cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        // Get selected row data
        var selectedRow = deviceListView.SelectedItems[0];
        var id = selectedRow.SubItems[5].Text;

        if (id == null)
        {
            MessageBox.Show("Vui lòng chọn thiết bị cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        // Open a new form and pass data into it for update
        _addUpdateThietBiForm.IdDevice = int.Parse(id);
        _addUpdateThietBiForm.LoadData(int.Parse(id));

        _addUpdateThietBiForm.ShowDialog();
    }

    private void delete_device_btn_Click(object sender, EventArgs e)
    {
        // Get selected row data
        if (deviceListView.SelectedItems.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn thiết bị cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        var selectedRow = deviceListView.SelectedItems[0];
        var id = selectedRow.SubItems[5].Text;

        if (id == null)
        {
            MessageBox.Show("Vui lòng chọn thiết bị cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        var toDelete = _appDbContext.ThietBis.FirstOrDefault(x => x.Id == int.Parse(id));
        _appDbContext.ThietBis.Remove(toDelete);
        _appDbContext.SaveChanges();

        LoadTabThietBi();

        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
