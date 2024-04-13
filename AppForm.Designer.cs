﻿using MaterialSkin.Controls;
using MaterialSkin;

namespace ezbooking;

partial class AppForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
        materialTabControl1 = new MaterialTabControl();
        doctor = new TabPage();
        searchTextBox = new MaterialTextBox();
        delete_doctor = new MaterialButton();
        edit_doctor = new MaterialButton();
        add_doctor_btn = new MaterialButton();
        doctorLabel = new Label();
        doctorListView = new MaterialListView();
        nofunction = new ColumnHeader();
        no = new ColumnHeader();
        name = new ColumnHeader();
        phone = new ColumnHeader();
        address = new ColumnHeader();
        email = new ColumnHeader();
        workingTime = new ColumnHeader();
        hiddenId = new ColumnHeader();
        patient = new TabPage();
        device = new TabPage();
        delete_device_btn = new MaterialButton();
        update_device_btn = new MaterialButton();
        add_device_btn = new MaterialButton();
        searchDeviceTxt = new MaterialTextBox();
        deviceListView = new MaterialListView();
        function = new ColumnHeader();
        Id = new ColumnHeader();
        tenThietBi = new ColumnHeader();
        soLuongThietBi = new ColumnHeader();
        thoiGianCachNhau = new ColumnHeader();
        hiddenDeviceId = new ColumnHeader();
        deviceTitleLabel = new Label();
        booking = new TabPage();
        report = new TabPage();
        imageList1 = new ImageList(components);
        materialTabControl1.SuspendLayout();
        doctor.SuspendLayout();
        device.SuspendLayout();
        SuspendLayout();
        // 
        // materialTabControl1
        // 
        materialTabControl1.Controls.Add(doctor);
        materialTabControl1.Controls.Add(patient);
        materialTabControl1.Controls.Add(device);
        materialTabControl1.Controls.Add(booking);
        materialTabControl1.Controls.Add(report);
        materialTabControl1.Depth = 0;
        materialTabControl1.Dock = DockStyle.Fill;
        materialTabControl1.Font = new Font("Segoe UI", 9F);
        materialTabControl1.ImageList = imageList1;
        materialTabControl1.Location = new Point(3, 64);
        materialTabControl1.MouseState = MouseState.HOVER;
        materialTabControl1.Multiline = true;
        materialTabControl1.Name = "materialTabControl1";
        materialTabControl1.SelectedIndex = 0;
        materialTabControl1.Size = new Size(927, 486);
        materialTabControl1.TabIndex = 0;
        // 
        // doctor
        // 
        doctor.Controls.Add(searchTextBox);
        doctor.Controls.Add(delete_doctor);
        doctor.Controls.Add(edit_doctor);
        doctor.Controls.Add(add_doctor_btn);
        doctor.Controls.Add(doctorLabel);
        doctor.Controls.Add(doctorListView);
        doctor.ImageKey = "icons8-medical-doctor-48.png";
        doctor.Location = new Point(4, 39);
        doctor.Name = "doctor";
        doctor.Padding = new Padding(3);
        doctor.Size = new Size(919, 443);
        doctor.TabIndex = 0;
        doctor.Text = "Bác sĩ - KTV";
        doctor.UseVisualStyleBackColor = true;
        // 
        // searchTextBox
        // 
        searchTextBox.AnimateReadOnly = false;
        searchTextBox.BorderStyle = BorderStyle.None;
        searchTextBox.Depth = 0;
        searchTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        searchTextBox.Hint = "Nhập họ tên cần tìm kiếm";
        searchTextBox.LeadingIcon = null;
        searchTextBox.Location = new Point(6, 58);
        searchTextBox.MaxLength = 50;
        searchTextBox.MouseState = MouseState.OUT;
        searchTextBox.Multiline = false;
        searchTextBox.Name = "searchTextBox";
        searchTextBox.Size = new Size(228, 50);
        searchTextBox.TabIndex = 7;
        searchTextBox.Text = "";
        searchTextBox.TrailingIcon = null;
        searchTextBox.TextChanged += searchTextBox_TextChanged;
        // 
        // delete_doctor
        // 
        delete_doctor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        delete_doctor.Cursor = Cursors.Hand;
        delete_doctor.Density = MaterialButton.MaterialButtonDensity.Default;
        delete_doctor.Depth = 0;
        delete_doctor.ForeColor = Color.Red;
        delete_doctor.HighEmphasis = true;
        delete_doctor.Icon = null;
        delete_doctor.Location = new Point(488, 9);
        delete_doctor.Margin = new Padding(5);
        delete_doctor.MouseState = MouseState.HOVER;
        delete_doctor.Name = "delete_doctor";
        delete_doctor.NoAccentTextColor = Color.Empty;
        delete_doctor.Size = new Size(64, 36);
        delete_doctor.TabIndex = 6;
        delete_doctor.Text = "Xóa";
        delete_doctor.Type = MaterialButton.MaterialButtonType.Outlined;
        delete_doctor.UseAccentColor = true;
        delete_doctor.UseVisualStyleBackColor = true;
        delete_doctor.Click += delete_doctor_Click;
        // 
        // edit_doctor
        // 
        edit_doctor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        edit_doctor.BackColor = Color.Red;
        edit_doctor.Cursor = Cursors.Hand;
        edit_doctor.Density = MaterialButton.MaterialButtonDensity.Default;
        edit_doctor.Depth = 0;
        edit_doctor.ForeColor = SystemColors.ActiveCaption;
        edit_doctor.HighEmphasis = true;
        edit_doctor.Icon = null;
        edit_doctor.Location = new Point(385, 9);
        edit_doctor.Margin = new Padding(5);
        edit_doctor.MouseState = MouseState.HOVER;
        edit_doctor.Name = "edit_doctor";
        edit_doctor.NoAccentTextColor = Color.Empty;
        edit_doctor.Size = new Size(93, 36);
        edit_doctor.TabIndex = 5;
        edit_doctor.Text = "Cập nhật";
        edit_doctor.Type = MaterialButton.MaterialButtonType.Outlined;
        edit_doctor.UseAccentColor = false;
        edit_doctor.UseVisualStyleBackColor = false;
        edit_doctor.Click += edit_doctor_Click;
        // 
        // add_doctor_btn
        // 
        add_doctor_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        add_doctor_btn.Cursor = Cursors.Hand;
        add_doctor_btn.Density = MaterialButton.MaterialButtonDensity.Default;
        add_doctor_btn.Depth = 0;
        add_doctor_btn.ForeColor = SystemColors.ActiveCaption;
        add_doctor_btn.HighEmphasis = true;
        add_doctor_btn.Icon = null;
        add_doctor_btn.Location = new Point(311, 9);
        add_doctor_btn.Margin = new Padding(5);
        add_doctor_btn.MouseState = MouseState.HOVER;
        add_doctor_btn.Name = "add_doctor_btn";
        add_doctor_btn.NoAccentTextColor = Color.Empty;
        add_doctor_btn.Size = new Size(64, 36);
        add_doctor_btn.TabIndex = 3;
        add_doctor_btn.Text = "Thêm";
        add_doctor_btn.Type = MaterialButton.MaterialButtonType.Outlined;
        add_doctor_btn.UseAccentColor = false;
        add_doctor_btn.UseVisualStyleBackColor = false;
        add_doctor_btn.Click += add_doctor_btn_Click;
        // 
        // doctorLabel
        // 
        doctorLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
        doctorLabel.ForeColor = SystemColors.ActiveCaption;
        doctorLabel.Location = new Point(6, 13);
        doctorLabel.Name = "doctorLabel";
        doctorLabel.Size = new Size(273, 32);
        doctorLabel.TabIndex = 2;
        doctorLabel.Text = "Danh sách bác sĩ - KTV";
        // 
        // doctorListView
        // 
        doctorListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        doctorListView.AutoSizeTable = false;
        doctorListView.BackColor = Color.FromArgb(255, 255, 255);
        doctorListView.BorderStyle = BorderStyle.None;
        doctorListView.Columns.AddRange(new ColumnHeader[] { nofunction, no, name, phone, address, email, workingTime, hiddenId });
        doctorListView.Depth = 0;
        doctorListView.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
        doctorListView.FullRowSelect = true;
        doctorListView.Location = new Point(3, 125);
        doctorListView.MinimumSize = new Size(200, 100);
        doctorListView.MouseLocation = new Point(-1, -1);
        doctorListView.MouseState = MouseState.OUT;
        doctorListView.Name = "doctorListView";
        doctorListView.OwnerDraw = true;
        doctorListView.Size = new Size(913, 315);
        doctorListView.TabIndex = 4;
        doctorListView.UseCompatibleStateImageBehavior = false;
        doctorListView.View = View.Details;
        doctorListView.SelectedIndexChanged += doctorListView_SelectedIndexChanged;
        // 
        // nofunction
        // 
        nofunction.Text = "";
        nofunction.Width = 0;
        // 
        // no
        // 
        no.Text = "STT";
        // 
        // name
        // 
        name.Text = "Họ tên";
        name.Width = 200;
        // 
        // phone
        // 
        phone.Text = "Số điện thoại";
        phone.Width = 120;
        // 
        // address
        // 
        address.Text = "Địa chỉ";
        address.Width = 100;
        // 
        // email
        // 
        email.Text = "Email";
        email.Width = 100;
        // 
        // workingTime
        // 
        workingTime.Text = "Thời gian làm việc";
        workingTime.Width = 150;
        // 
        // hiddenId
        // 
        hiddenId.Text = "";
        hiddenId.Width = 0;
        // 
        // patient
        // 
        patient.ImageKey = "icons8-nurse-call-48.png";
        patient.Location = new Point(4, 39);
        patient.Name = "patient";
        patient.Padding = new Padding(3);
        patient.Size = new Size(919, 443);
        patient.TabIndex = 1;
        patient.Text = "Người bệnh";
        patient.UseVisualStyleBackColor = true;
        // 
        // device
        // 
        device.Controls.Add(delete_device_btn);
        device.Controls.Add(update_device_btn);
        device.Controls.Add(add_device_btn);
        device.Controls.Add(searchDeviceTxt);
        device.Controls.Add(deviceListView);
        device.Controls.Add(deviceTitleLabel);
        device.Location = new Point(4, 39);
        device.Name = "device";
        device.Padding = new Padding(3);
        device.Size = new Size(919, 443);
        device.TabIndex = 4;
        device.Text = "Thiết bị";
        device.UseVisualStyleBackColor = true;
        // 
        // delete_device_btn
        // 
        delete_device_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        delete_device_btn.Density = MaterialButton.MaterialButtonDensity.Default;
        delete_device_btn.Depth = 0;
        delete_device_btn.HighEmphasis = true;
        delete_device_btn.Icon = null;
        delete_device_btn.Location = new Point(441, 9);
        delete_device_btn.Margin = new Padding(4, 6, 4, 6);
        delete_device_btn.MouseState = MouseState.HOVER;
        delete_device_btn.Name = "delete_device_btn";
        delete_device_btn.NoAccentTextColor = Color.Empty;
        delete_device_btn.Size = new Size(64, 36);
        delete_device_btn.TabIndex = 5;
        delete_device_btn.Text = "Xoá";
        delete_device_btn.Type = MaterialButton.MaterialButtonType.Outlined;
        delete_device_btn.UseAccentColor = false;
        delete_device_btn.UseVisualStyleBackColor = false;
        delete_device_btn.Click += delete_device_btn_Click;
        // 
        // update_device_btn
        // 
        update_device_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        update_device_btn.Density = MaterialButton.MaterialButtonDensity.Default;
        update_device_btn.Depth = 0;
        update_device_btn.HighEmphasis = true;
        update_device_btn.Icon = null;
        update_device_btn.Location = new Point(369, 9);
        update_device_btn.Margin = new Padding(4, 6, 4, 6);
        update_device_btn.MouseState = MouseState.HOVER;
        update_device_btn.Name = "update_device_btn";
        update_device_btn.NoAccentTextColor = Color.Empty;
        update_device_btn.Size = new Size(64, 36);
        update_device_btn.TabIndex = 4;
        update_device_btn.Text = "Sửa";
        update_device_btn.Type = MaterialButton.MaterialButtonType.Outlined;
        update_device_btn.UseAccentColor = false;
        update_device_btn.UseVisualStyleBackColor = false;
        update_device_btn.Click += update_device_btn_Click;
        // 
        // add_device_btn
        // 
        add_device_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        add_device_btn.Density = MaterialButton.MaterialButtonDensity.Default;
        add_device_btn.Depth = 0;
        add_device_btn.HighEmphasis = true;
        add_device_btn.Icon = null;
        add_device_btn.Location = new Point(297, 9);
        add_device_btn.Margin = new Padding(4, 6, 4, 6);
        add_device_btn.MouseState = MouseState.HOVER;
        add_device_btn.Name = "add_device_btn";
        add_device_btn.NoAccentTextColor = Color.Empty;
        add_device_btn.Size = new Size(64, 36);
        add_device_btn.TabIndex = 3;
        add_device_btn.Text = "Thêm";
        add_device_btn.Type = MaterialButton.MaterialButtonType.Outlined;
        add_device_btn.UseAccentColor = false;
        add_device_btn.UseVisualStyleBackColor = false;
        add_device_btn.Click += add_device_btn_Click;
        // 
        // searchDeviceTxt
        // 
        searchDeviceTxt.AnimateReadOnly = false;
        searchDeviceTxt.BorderStyle = BorderStyle.None;
        searchDeviceTxt.Depth = 0;
        searchDeviceTxt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        searchDeviceTxt.Hint = "Nhập tên thiết bị cần tìm kiếm";
        searchDeviceTxt.LeadingIcon = null;
        searchDeviceTxt.Location = new Point(6, 57);
        searchDeviceTxt.MaxLength = 50;
        searchDeviceTxt.MouseState = MouseState.OUT;
        searchDeviceTxt.Multiline = false;
        searchDeviceTxt.Name = "searchDeviceTxt";
        searchDeviceTxt.Size = new Size(271, 50);
        searchDeviceTxt.TabIndex = 2;
        searchDeviceTxt.Text = "";
        searchDeviceTxt.TrailingIcon = null;
        searchDeviceTxt.TextChanged += searchDeviceTxt_TextChanged;
        // 
        // deviceListView
        // 
        deviceListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        deviceListView.AutoSizeTable = false;
        deviceListView.BackColor = Color.FromArgb(255, 255, 255);
        deviceListView.BorderStyle = BorderStyle.None;
        deviceListView.Columns.AddRange(new ColumnHeader[] { function, Id, tenThietBi, soLuongThietBi, thoiGianCachNhau, hiddenDeviceId });
        deviceListView.Depth = 0;
        deviceListView.FullRowSelect = true;
        deviceListView.Location = new Point(3, 125);
        deviceListView.MinimumSize = new Size(200, 100);
        deviceListView.MouseLocation = new Point(-1, -1);
        deviceListView.MouseState = MouseState.OUT;
        deviceListView.Name = "deviceListView";
        deviceListView.OwnerDraw = true;
        deviceListView.Size = new Size(913, 315);
        deviceListView.TabIndex = 1;
        deviceListView.UseCompatibleStateImageBehavior = false;
        deviceListView.View = View.Details;
        // 
        // function
        // 
        function.Text = "";
        function.Width = 0;
        // 
        // Id
        // 
        Id.Text = "STT";
        // 
        // tenThietBi
        // 
        tenThietBi.Text = "Tên thiết bị";
        tenThietBi.Width = 200;
        // 
        // soLuongThietBi
        // 
        soLuongThietBi.Text = "Số lượng";
        soLuongThietBi.Width = 100;
        // 
        // thoiGianCachNhau
        // 
        thoiGianCachNhau.Text = "Thời gian cách nhau";
        thoiGianCachNhau.Width = 200;
        // 
        // hiddenDeviceId
        // 
        hiddenDeviceId.Text = "";
        hiddenDeviceId.Width = 0;
        // 
        // deviceTitleLabel
        // 
        deviceTitleLabel.AutoSize = true;
        deviceTitleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        deviceTitleLabel.ForeColor = SystemColors.ActiveCaption;
        deviceTitleLabel.Location = new Point(6, 12);
        deviceTitleLabel.Name = "deviceTitleLabel";
        deviceTitleLabel.Size = new Size(212, 31);
        deviceTitleLabel.TabIndex = 0;
        deviceTitleLabel.Text = "Danh sách thiết bị";
        // 
        // booking
        // 
        booking.ImageKey = "icons8-reserve-48.png";
        booking.Location = new Point(4, 39);
        booking.Name = "booking";
        booking.Size = new Size(919, 443);
        booking.TabIndex = 2;
        booking.Text = "Đặt lịch";
        booking.UseVisualStyleBackColor = true;
        // 
        // report
        // 
        report.ImageKey = "icons8-report-48.png";
        report.Location = new Point(4, 39);
        report.Name = "report";
        report.Size = new Size(919, 443);
        report.TabIndex = 3;
        report.Text = "Báo cáo";
        report.UseVisualStyleBackColor = true;
        // 
        // imageList1
        // 
        imageList1.ColorDepth = ColorDepth.Depth32Bit;
        imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
        imageList1.TransparentColor = Color.Transparent;
        imageList1.Images.SetKeyName(0, "report.png");
        imageList1.Images.SetKeyName(1, "calendar.png");
        imageList1.Images.SetKeyName(2, "hospitalisation.png");
        imageList1.Images.SetKeyName(3, "medical-team.png");
        imageList1.Images.SetKeyName(4, "icons8-reserve-32.png");
        imageList1.Images.SetKeyName(5, "icons8-reserve-48.png");
        imageList1.Images.SetKeyName(6, "icons8-report-48.png");
        imageList1.Images.SetKeyName(7, "icons8-nurse-call-48.png");
        imageList1.Images.SetKeyName(8, "icons8-medical-doctor-48.png");
        imageList1.Images.SetKeyName(9, "icons8-reserve-48.png");
        // 
        // AppForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(933, 553);
        Controls.Add(materialTabControl1);
        DrawerAutoShow = true;
        DrawerShowIconsWhenHidden = true;
        DrawerTabControl = materialTabControl1;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "AppForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Khoa PHCN – Đông y";
        Load += AppForm_Load;
        materialTabControl1.ResumeLayout(false);
        doctor.ResumeLayout(false);
        doctor.PerformLayout();
        device.ResumeLayout(false);
        device.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
    private TabPage doctor;
    private TabPage patient;
    private ImageList imageList1;
    private TabPage booking;
    private TabPage report;
    private Label doctorLabel;
    private MaterialSkin.Controls.MaterialButton add_doctor_btn;
    private MaterialSkin.Controls.MaterialListView doctorListView;
    private ColumnHeader no;
    private ColumnHeader name;
    private ColumnHeader phone;
    private ColumnHeader address;
    private ColumnHeader nofunction;
    private MaterialSkin.Controls.MaterialButton delete_doctor;
    private MaterialSkin.Controls.MaterialButton edit_doctor;
    private MaterialTextBox searchTextBox;
    private ColumnHeader email;
    private ColumnHeader workingTime;
    private TabPage device;
    private MaterialListView deviceListView;
    private Label deviceTitleLabel;
    private ColumnHeader function;
    private ColumnHeader Id;
    private ColumnHeader tenThietBi;
    private ColumnHeader soLuongThietBi;
    private ColumnHeader thoiGianCachNhau;
    private MaterialTextBox searchDeviceTxt;
    private MaterialButton add_device_btn;
    private MaterialButton delete_device_btn;
    private MaterialButton update_device_btn;
    private ColumnHeader hiddenId;
    private ColumnHeader hiddenDeviceId;
}
