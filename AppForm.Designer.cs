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
        materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
        doctor = new TabPage();
        materialListView1 = new MaterialSkin.Controls.MaterialListView();
        no = new ColumnHeader();
        name = new ColumnHeader();
        phone = new ColumnHeader();
        status = new ColumnHeader();
        update = new ColumnHeader();
        add_doctor_btn = new MaterialSkin.Controls.MaterialButton();
        label1 = new Label();
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
        materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
        materialTabControl1.Multiline = true;
        materialTabControl1.Name = "materialTabControl1";
        materialTabControl1.SelectedIndex = 0;
        materialTabControl1.Size = new Size(926, 486);
        materialTabControl1.TabIndex = 0;
        // 
        // doctor
        // 
        doctor.Controls.Add(materialListView1);
        doctor.Controls.Add(add_doctor_btn);
        doctor.Controls.Add(label1);
        doctor.ImageKey = "icons8-medical-doctor-48.png";
        doctor.Location = new Point(4, 39);
        doctor.Name = "doctor";
        doctor.Padding = new Padding(3);
        doctor.Size = new Size(918, 443);
        doctor.TabIndex = 0;
        doctor.Text = "Bác sĩ - KTV";
        doctor.UseVisualStyleBackColor = true;
        // 
        // materialListView1
        // 
        materialListView1.AutoSizeTable = false;
        materialListView1.BackColor = Color.FromArgb(255, 255, 255);
        materialListView1.BorderStyle = BorderStyle.None;
        materialListView1.Columns.AddRange(new ColumnHeader[] { no, name, phone, status, update });
        materialListView1.Depth = 0;
        materialListView1.FullRowSelect = true;
        materialListView1.Location = new Point(16, 70);
        materialListView1.MinimumSize = new Size(200, 100);
        materialListView1.MouseLocation = new Point(-1, -1);
        materialListView1.MouseState = MaterialSkin.MouseState.OUT;
        materialListView1.Name = "materialListView1";
        materialListView1.OwnerDraw = true;
        materialListView1.Size = new Size(885, 367);
        materialListView1.TabIndex = 4;
        materialListView1.UseCompatibleStateImageBehavior = false;
        materialListView1.View = View.Details;
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
        // update
        // 
        update.Text = "Sửa thông tin";
        update.Width = 150;
        // 
        // add_doctor_btn
        // 
        add_doctor_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        add_doctor_btn.Cursor = Cursors.Hand;
        add_doctor_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        add_doctor_btn.Depth = 0;
        add_doctor_btn.ForeColor = SystemColors.ActiveCaption;
        add_doctor_btn.HighEmphasis = true;
        add_doctor_btn.Icon = null;
        add_doctor_btn.Location = new Point(295, 9);
        add_doctor_btn.Margin = new Padding(4, 6, 4, 6);
        add_doctor_btn.MouseState = MaterialSkin.MouseState.HOVER;
        add_doctor_btn.Name = "add_doctor_btn";
        add_doctor_btn.NoAccentTextColor = Color.Empty;
        add_doctor_btn.Size = new Size(64, 36);
        add_doctor_btn.TabIndex = 3;
        add_doctor_btn.Text = "Thêm";
        add_doctor_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        add_doctor_btn.UseAccentColor = false;
        add_doctor_btn.UseVisualStyleBackColor = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
        label1.Location = new Point(15, 13);
        label1.Name = "label1";
        label1.Size = new Size(273, 32);
        label1.TabIndex = 2;
        label1.Text = "Danh sách bác sĩ - KTV";
        // 
        // patient
        // 
        patient.ImageKey = "icons8-nurse-call-48.png";
        patient.Location = new Point(4, 39);
        patient.Name = "patient";
        patient.Padding = new Padding(3);
        patient.Size = new Size(918, 443);
        patient.TabIndex = 1;
        patient.Text = "Người bệnh";
        patient.UseVisualStyleBackColor = true;
        // 
        // booking
        // 
        booking.ImageKey = "icons8-reserve-48.png";
        booking.Location = new Point(4, 39);
        booking.Name = "booking";
        booking.Size = new Size(918, 443);
        booking.TabIndex = 2;
        booking.Text = "Đặt lịch";
        booking.UseVisualStyleBackColor = true;
        // 
        // report
        // 
        report.ImageKey = "icons8-report-48.png";
        report.Location = new Point(4, 39);
        report.Name = "report";
        report.Size = new Size(918, 443);
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
        ClientSize = new Size(932, 553);
        Controls.Add(materialTabControl1);
        DrawerAutoShow = true;
        DrawerShowIconsWhenHidden = true;
        DrawerTabControl = materialTabControl1;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "AppForm";
        Text = "Phần mềm đặt lịch khám chữa bệnh";
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
    private Label label1;
    private MaterialSkin.Controls.MaterialButton add_doctor_btn;
    private MaterialSkin.Controls.MaterialListView materialListView1;
    private ColumnHeader no;
    private ColumnHeader name;
    private ColumnHeader phone;
    private ColumnHeader status;
    private ColumnHeader update;
}
