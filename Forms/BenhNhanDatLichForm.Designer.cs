namespace ezbooking.Forms
{
    partial class BenhNhanDatLichForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BenhNhanDatLichForm));
            add_datlich = new MaterialSkin.Controls.MaterialButton();
            patientBookingLabel = new Label();
            datlichListView = new MaterialSkin.Controls.MaterialListView();
            temp = new ColumnHeader();
            no = new ColumnHeader();
            patientName = new ColumnHeader();
            dvkt = new ColumnHeader();
            doctorName = new ColumnHeader();
            time = new ColumnHeader();
            SuspendLayout();
            // 
            // add_datlich
            // 
            add_datlich.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            add_datlich.Cursor = Cursors.Hand;
            add_datlich.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            add_datlich.Depth = 0;
            add_datlich.ForeColor = SystemColors.ActiveCaption;
            add_datlich.HighEmphasis = true;
            add_datlich.Icon = null;
            add_datlich.Location = new Point(485, 5);
            add_datlich.Margin = new Padding(5);
            add_datlich.MouseState = MaterialSkin.MouseState.HOVER;
            add_datlich.Name = "add_datlich";
            add_datlich.NoAccentTextColor = Color.Empty;
            add_datlich.Size = new Size(64, 36);
            add_datlich.TabIndex = 8;
            add_datlich.Text = "Thêm";
            add_datlich.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            add_datlich.UseAccentColor = false;
            add_datlich.UseVisualStyleBackColor = false;
            add_datlich.Click += add_datlich_Click;
            // 
            // patientBookingLabel
            // 
            patientBookingLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            patientBookingLabel.ForeColor = SystemColors.ActiveCaption;
            patientBookingLabel.Location = new Point(12, 9);
            patientBookingLabel.Name = "patientBookingLabel";
            patientBookingLabel.Size = new Size(465, 32);
            patientBookingLabel.TabIndex = 7;
            patientBookingLabel.Text = "Danh sách đặt lịch của bệnh nhân";
            // 
            // datlichListView
            // 
            datlichListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datlichListView.AutoSizeTable = false;
            datlichListView.BackColor = Color.FromArgb(255, 255, 255);
            datlichListView.BorderStyle = BorderStyle.None;
            datlichListView.Columns.AddRange(new ColumnHeader[] { temp, no, patientName, dvkt, doctorName, time });
            datlichListView.Depth = 0;
            datlichListView.FullRowSelect = true;
            datlichListView.Location = new Point(12, 75);
            datlichListView.MinimumSize = new Size(200, 100);
            datlichListView.MouseLocation = new Point(-1, -1);
            datlichListView.MouseState = MaterialSkin.MouseState.OUT;
            datlichListView.Name = "datlichListView";
            datlichListView.OwnerDraw = true;
            datlichListView.Size = new Size(982, 634);
            datlichListView.TabIndex = 11;
            datlichListView.UseCompatibleStateImageBehavior = false;
            datlichListView.View = View.Details;
            // 
            // temp
            // 
            temp.Text = "";
            temp.Width = 0;
            // 
            // no
            // 
            no.Text = "STT";
            // 
            // patientName
            // 
            patientName.Text = "Tên bệnh nhân";
            patientName.Width = 150;
            // 
            // dvkt
            // 
            dvkt.Text = "Dịch vụ kĩ thuật";
            dvkt.Width = 200;
            // 
            // doctorName
            // 
            doctorName.Text = "Người thực hiện";
            doctorName.Width = 150;
            // 
            // time
            // 
            time.Text = "Khung giờ";
            time.Width = 300;
            // 
            // BenhNhanDatLichForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(datlichListView);
            Controls.Add(add_datlich);
            Controls.Add(patientBookingLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BenhNhanDatLichForm";
            Text = "Đặt lịch";
            FormClosing += BenhNhanDatLichForm_Close;
            Load += BenhNhanDatLichForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton add_datlich;
        private Label patientBookingLabel;
        private MaterialSkin.Controls.MaterialListView datlichListView;
        private ColumnHeader temp;
        private ColumnHeader no;
        private ColumnHeader patientName;
        private ColumnHeader dvkt;
        private ColumnHeader doctorName;
        private ColumnHeader time;
    }
}