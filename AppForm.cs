﻿using ezbooking.Forms;
using ezbooking.Models;
using ezbooking.Shared;
using ezbooking.Shared.Dtos;
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
    private readonly BacSiDatLichForm _bacsiDatLichForm;
    private readonly LoaiThuThuatForm _loaiThuThuatForm;

    private int pageIndex = 1;
    private int pageSize = 20;
    private int totalPages = 0;

    public AppForm(AppDbContext appDbContext,
                   AddUpdateBacSiForm addUpdateBacSiForm,
                   AddUpdateThietBiForm addUpdateThietBiForm,
                   AddUpdateDVKTForm addUpdateDVKT,
                   AddUpdateBenhNhanForm addUpdateBenhNhanForm,
                   BenhNhanDatLichForm benhNhanDatLichForm,
                   BacSiDatLichForm bacsiDatLichForm,
                   LoaiThuThuatForm loaiThuThuatForm)
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
        _bacsiDatLichForm = bacsiDatLichForm;
        _loaiThuThuatForm = loaiThuThuatForm;
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
            case 3:
                LoadTabBaoCao();
                break;
            case 4:
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

    private void bacsi_changelich_Click(object sender, EventArgs e)
    {
        if (doctorListView.SelectedItems.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn bác sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        // Get selected row data
        var selectedRow = doctorListView.SelectedItems[0];
        var id = selectedRow.SubItems[7].Text;

        if (id == null)
        {
            MessageBox.Show("Vui lòng chọn bác sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _bacsiDatLichForm.BacSiId = int.Parse(id);
        _bacsiDatLichForm.ShowDialog();
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

        // remove all related data
        var thoiGianBieus = _appDbContext.ThoiGianBieus.Where(x => x.BacSiKTV.Id == int.Parse(id)).ToList();
        _appDbContext.ThoiGianBieus.RemoveRange(thoiGianBieus);

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

        // check if the device is being used
        var isBeingUsed = _appDbContext.DichVuKTs
                            .Include(x => x.ThietBi)
                            .Any(x => x.ThietBi.Id == int.Parse(id));

        if (isBeingUsed)
        {
            MessageBox.Show("Thiết bị đang được sử dụng! Vui lòng xóa DVKT trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        try
        {
            _appDbContext.ThietBis.Remove(toDelete);

            // remove all related data
            var thoiGianSuDungThietBi = _appDbContext.ThoiGianSuDungThietBis.Where(x => x.ThietBi.Id == int.Parse(id)).ToList();
            _appDbContext.ThoiGianSuDungThietBis.RemoveRange(thoiGianSuDungThietBi);

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

        patient_paging_label.Text = totalPages > 0 ? $"Trang {pageIndex}/{totalPages}" : "";

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

        // remove all related data
        var thoiGianBieus = _appDbContext.ThoiGianBieus.Where(x => x.BenhNhan.Id == int.Parse(id)).ToList();
        _appDbContext.ThoiGianBieus.RemoveRange(thoiGianBieus);

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

            // remove all related data
            var thoiGianBieus = _appDbContext.ThoiGianBieus.Where(x => x.DichVuKT.Id == int.Parse(id)).ToList();
            _appDbContext.ThoiGianBieus.RemoveRange(thoiGianBieus);

            // remove relation with bacsi
            var bacSiKTVs = _appDbContext.BacSiKTVs.Include(x => x.DichVuKTs).ToList();
            foreach (var bacSiKTV in bacSiKTVs)
            {
                var dvkt = bacSiKTV.DichVuKTs.FirstOrDefault(x => x.Id == int.Parse(id));
                if (dvkt != null)
                {
                    bacSiKTV.DichVuKTs.Remove(dvkt);
                }
            }

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

    /// <summary>
    /// BAO CAO
    /// </summary>

    private void LoadTabBaoCao()
    {
        var startOfWeek = Helpers.GetStartOfWeek(DateTime.Now);
        var endOfWeek = startOfWeek.AddDays(6);

        var thoigianbieuInWeek = _appDbContext.ThoiGianBieus
                                            .Include(tgb => tgb.DichVuKT)
                                            .Include(tgb => tgb.BacSiKTV)
                                            .Where(tgb => tgb.ThoiGianBatDau >= startOfWeek)
                                            .Where(tgb => tgb.ThoiGianKetThuc <= endOfWeek)
                                            .ToList();
        var groupData = thoigianbieuInWeek.GroupBy(tgb => tgb.BacSiKTV.TenBacSiKTV)
            .Select(tgb => new BacSiThuNhap
            {
                TenBacSi = tgb.Key,
                ThuNhap = tgb.Sum(tgb => tgb.DichVuKT.ChiPhi)
            }).ToList();

        // fill data to listview
        FillDataToBaoCaoListView(groupData);
    }

    private void FillDataToBaoCaoListView(List<BacSiThuNhap> data)
    {
        thunhap_lstview.Items.Clear();
        int stt = 0;
        foreach (var item in data)
        {
            stt++;
            var newItem = new ListViewItem();

            newItem.SubItems.Add(stt.ToString());
            newItem.SubItems.Add(item.TenBacSi);
            newItem.SubItems.Add(item.ThuNhap.ToString());

            thunhap_lstview.Items.Add(newItem);
        }
    }


    /// <summary>
    /// Thống kê loại thủ thuật
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void thongke_btn_Click(object sender, EventArgs e)
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
        _loaiThuThuatForm.Id = int.Parse(id);
        _loaiThuThuatForm.ViewType = 0;

        _loaiThuThuatForm.ShowDialog();
    }

    private void nguoibenh_thongke_btn_Click(object sender, EventArgs e)
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
        _loaiThuThuatForm.Id = int.Parse(id);
        _loaiThuThuatForm.ViewType = 0;

        _loaiThuThuatForm.ShowDialog();
    }
}
