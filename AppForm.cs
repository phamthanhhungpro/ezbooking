using ezbooking.Forms;
using ezbooking.Models;
using ezbooking.Shared;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

namespace ezbooking;

public partial class AppForm : MaterialForm
{
    private readonly AppDbContext _appDbContext;
    private readonly AddUpdateBacSiForm _addUpdateBacSiForm;
    private readonly AddUpdateThietBiForm _addUpdateThietBiForm;
    private readonly AddUpdateDVKTForm _addUpdateDVKTForm;
    private readonly AddUpdateBenhNhanForm _addUpdateBenhNhanForm;
    private readonly BenhNhanDatLichForm _benhNhanDatLichForm;

    private int pageIndex = 1;
    private int pageSize = 20;
    private int totalPages = 0;

    public AppForm(AppDbContext appDbContext,
                   AddUpdateBacSiForm addUpdateBacSiForm,
                   AddUpdateThietBiForm addUpdateThietBiForm,
                   AddUpdateDVKTForm addUpdateDVKT,
                   AddUpdateBenhNhanForm addUpdateBenhNhanForm,
                   BenhNhanDatLichForm benhNhanDatLichForm)
    {
        InitializeComponent();

        this.FormClosed += AppForm_FormClosed;
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
        _addUpdateDVKTForm = addUpdateDVKT;
        _addUpdateBenhNhanForm = addUpdateBenhNhanForm;
        _benhNhanDatLichForm = benhNhanDatLichForm;

        materialTabControl1.SelectedIndexChanged += TabChanged;

        _addUpdateBacSiForm.DataChanged += TabChanged;
        _addUpdateThietBiForm.DataChanged += TabChanged;
        _addUpdateDVKTForm.DataChanged += TabChanged;
        _addUpdateBenhNhanForm.DataChanged += TabChanged;
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
        ResetPageSetting();

        switch (materialTabControl1.SelectedIndex)
        {
            case 0:
                LoadTabBacSiKtv();
                break;
            case 1:
                LoadTabNguoiBenh();
                break;
            case 2:
                LoadTabThietBi();
                break;
            case 5:
                LoadTabDVKT();
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Bac si KTV
    /// </summary>

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
        var toDelete = _appDbContext.BacSiKTVs
            .Include(id => id.ThoiGianBieus)
            .Include(id => id.DichVuKTs)
            .FirstOrDefault(x => x.Id == int.Parse(id));

        _appDbContext.BacSiKTVs.Remove(toDelete);
        _appDbContext.SaveChanges();

        LoadTabBacSiKtv();

        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Thiet Bi
    /// </summary>

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

        if (searchDeviceTxt.Text != null)
        {
            data = data.Where(x => x.TenThietBi.ToLower().Contains(searchDeviceTxt.Text.ToLower(), StringComparison.OrdinalIgnoreCase)).ToList();
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
        var toDelete = _appDbContext.ThietBis
            .FirstOrDefault(x => x.Id == int.Parse(id));
        try
        {
            _appDbContext.ThietBis.Remove(toDelete);
            _appDbContext.SaveChanges();
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception)
        {
            MessageBox.Show("Thiết bị đang được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            throw;
        }

        LoadTabThietBi();
    }

    /// <summary>
    /// Nguoi benh
    /// </summary>

    private void LoadTabNguoiBenh()
    {
        var search = search_patient_box.Text.RemoveSign4VietnameseString();

        var query = _appDbContext.BenhNhans.AsEnumerable()
            .Where(a => a.TenBenhNhan.RemoveSign4VietnameseString().Contains(search, StringComparison.OrdinalIgnoreCase));

        var data = query.Skip((pageIndex - 1) * pageSize)
                                  .Take(pageSize)
                                  .ToList();

        var count = query.Count();
        totalPages = (int)Math.Ceiling((double)count / pageSize);

        FillDataToPatientListView(data);
    }

    private void FillDataToPatientListView(List<BenhNhan> data)
    {
        patientListview.Items.Clear();
        int stt = 0;
        foreach (var item in data)
        {
            stt++;
            var newItem = new ListViewItem();

            newItem.SubItems.Add(stt.ToString());
            newItem.SubItems.Add(item.TenBenhNhan);
            newItem.SubItems.Add(item.DiaChi);
            newItem.SubItems.Add(item.SoDienThoai);
            newItem.SubItems.Add(item.Id.ToString());

            patientListview.Items.Add(newItem);
        }

        patient_next_btn.Enabled = pageIndex < totalPages;
        patient_prev_btn.Enabled = pageIndex > 1;
    }

    private void patient_prev_btn_Click(object sender, EventArgs e)
    {
        pageIndex--;
        LoadTabNguoiBenh();
    }

    private void patient_next_btn_Click(object sender, EventArgs e)
    {
        pageIndex++;
        LoadTabNguoiBenh();
    }

    private void add_patient_btn_Click(object sender, EventArgs e)
    {
        _addUpdateBenhNhanForm.ShowDialog();
    }

    private void search_patient_box_TextChanged(object sender, EventArgs e)
    {
        var search = search_patient_box.Text.RemoveSign4VietnameseString();

        var query = _appDbContext.BenhNhans.AsEnumerable()
            .Where(a => a.TenBenhNhan.RemoveSign4VietnameseString().Contains(search, StringComparison.OrdinalIgnoreCase));

        var data = query.Skip((pageIndex - 1) * pageSize)
                                  .Take(pageSize)
                                  .ToList();

        var count = query.Count();
        totalPages = (int)Math.Ceiling((double)count / pageSize);

        FillDataToPatientListView(data);
    }

    private void ResetPageSetting()
    {
        pageIndex = 1;
        pageSize = 20;
        totalPages = 0;
    }

    private void edit_patient_btn_Click(object sender, EventArgs e)
    {
        if (patientListview.SelectedItems.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn bệnh nhân cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        // Get selected row data
        var selectedRow = patientListview.SelectedItems[0];
        var id = selectedRow.SubItems[5].Text;

        if (id == null)
        {
            MessageBox.Show("Vui lòng chọn bệnh nhân cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        // Open a new form and pass data into it for update
        _addUpdateBenhNhanForm.IdBenhNhan = int.Parse(id);
        _addUpdateBenhNhanForm.LoadData(int.Parse(id));

        _addUpdateBenhNhanForm.ShowDialog();
    }

    private void del_patient_btn_Click(object sender, EventArgs e)
    {
        if (patientListview.SelectedItems.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn bệnh nhân cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        // Get selected row data
        var selectedRow = patientListview.SelectedItems[0];
        var id = selectedRow.SubItems[5].Text;

        if (id == null)
        {
            MessageBox.Show("Vui lòng chọn bệnh nhân cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var toDelete = _appDbContext.BenhNhans.FirstOrDefault(x => x.Id == int.Parse(id));

        toDelete.IsDeleted = true;
        toDelete.DeletedAt = DateTime.Now;

        _appDbContext.SaveChanges();

        LoadTabNguoiBenh();
        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Bệnh nhân đặt lịch
    /// </summary>

    private void patientBook_Click(object sender, EventArgs e)
    {
        if (patientListview.SelectedItems.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        // Get selected row data
        var selectedRow = patientListview.SelectedItems[0];
        var id = selectedRow.SubItems[5].Text;

        if (id == null)
        {
            MessageBox.Show("Vui lòng chọn bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _benhNhanDatLichForm.BenhNhanId = int.Parse(id);
        _benhNhanDatLichForm.ShowDialog();
    }

    // DVKT
    private void FillDataTodvktListView(List<DichVuKT> dichVuKTs)
    {
        dvktListView.Items.Clear();
        int stt = 0;
        foreach (var item in dichVuKTs)
        {
            stt++;
            var newItem = new ListViewItem();

            newItem.SubItems.Add(stt.ToString());
            newItem.SubItems.Add(item.TenDichVu);
            newItem.SubItems.Add(item.ChiPhi.ToString());
            newItem.SubItems.Add(item.ThoiGian.ToString());
            newItem.SubItems.Add(item.Id.ToString());

            dvktListView.Items.Add(newItem);
        }

    }

    private void LoadTabDVKT()
    {
        var data = _appDbContext.DichVuKTs.OrderByDescending(o => o.CreatedAt).ToList();
        FillDataTodvktListView(data);
    }

    private void dvktListView_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void del_dvkt_Click(object sender, EventArgs e)
    {
        if (dvktListView.SelectedItems.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn dịch vụ cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        var selectedRow = dvktListView.SelectedItems[0];
        var id = selectedRow.SubItems[5].Text;

        if (id == null)
        {
            MessageBox.Show("Vui lòng chọn dịch vụ cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            var toDelete = _appDbContext.DichVuKTs.FirstOrDefault(x => x.Id == int.Parse(id));

            _appDbContext.DichVuKTs.Remove(toDelete);

            _appDbContext.SaveChanges();


            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception)
        {
            MessageBox.Show("Dịch vụ đang được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        LoadTabDVKT();
    }

    private void dvktListView_SelectedIndexChanged_1(object sender, EventArgs e)
    {

    }

    private void add_dvkt_Click(object sender, EventArgs e)
    {
        _addUpdateDVKTForm.ShowDialog();
    }

    private void edit_dvkt_Click(object sender, EventArgs e)
    {
        if (dvktListView.SelectedItems.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn dịch vụ cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        // Get selected row data
        var selectedRow = dvktListView.SelectedItems[0];
        var id = selectedRow.SubItems[5].Text;

        if (id == null)
        {
            MessageBox.Show("Vui lòng chọn dịch vụ cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        // Open a new form and pass data into it for update
        _addUpdateDVKTForm.IdDVKT = int.Parse(id);
        _addUpdateDVKTForm.LoadData(int.Parse(id));

        _addUpdateDVKTForm.ShowDialog();
    }
}
