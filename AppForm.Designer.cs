using MaterialSkin.Controls;
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
        nofuction = new ColumnHeader();
        no = new ColumnHeader();
        name = new ColumnHeader();
        phone = new ColumnHeader();
        status = new ColumnHeader();
        patient = new TabPage();
        booking = new TabPage();
        report = new TabPage();
        imageList1 = new ImageList(components);
        materialTabControl1.SuspendLayout();
        doctor.SuspendLayout();
        SuspendLayout();
        // 
        // materialTabControl1
        // 
        materialTabControl1.Controls.Add(doctor);
        materialTabControl1.Controls.Add(patient);
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
        searchTextBox.Location = new Point(15, 59);
        searchTextBox.MaxLength = 50;
        searchTextBox.MouseState = MouseState.OUT;
        searchTextBox.Multiline = false;
        searchTextBox.Name = "searchTextBox";
        searchTextBox.Size = new Size(463, 50);
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
        delete_doctor.Location = new Point(501, 8);
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
        edit_doctor.Click += materialButton1_Click;
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
        add_doctor_btn.Location = new Point(295, 9);
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
        doctorLabel.Location = new Point(15, 13);
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
        doctorListView.Columns.AddRange(new ColumnHeader[] { nofuction, no, name, phone, status });
        doctorListView.Depth = 0;
        doctorListView.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
        doctorListView.FullRowSelect = true;
        doctorListView.Location = new Point(3, 115);
        doctorListView.MinimumSize = new Size(200, 100);
        doctorListView.MouseLocation = new Point(-1, -1);
        doctorListView.MouseState = MouseState.OUT;
        doctorListView.Name = "doctorListView";
        doctorListView.OwnerDraw = true;
        doctorListView.Size = new Size(913, 325);
        doctorListView.TabIndex = 4;
        doctorListView.UseCompatibleStateImageBehavior = false;
        doctorListView.View = View.Details;
        doctorListView.SelectedIndexChanged += doctorListView_SelectedIndexChanged;
        // 
        // nofuction
        // 
        nofuction.Text = "";
        nofuction.Width = 0;
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
        // status
        // 
        status.Text = "Trạng thái";
        status.Width = 100;
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
    private ColumnHeader status;
    private ColumnHeader nofuction;
    private MaterialSkin.Controls.MaterialButton delete_doctor;
    private MaterialSkin.Controls.MaterialButton edit_doctor;
    private MaterialTextBox searchTextBox;
}
