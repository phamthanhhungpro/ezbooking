namespace ezbooking.Forms
{
    partial class BacSiDatLichForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BacSiDatLichForm));
            bacsi_datlich_label = new Label();
            edit_datlich = new MaterialSkin.Controls.MaterialButton();
            datlichListView = new MaterialSkin.Controls.MaterialListView();
            temp = new ColumnHeader();
            no = new ColumnHeader();
            patientName = new ColumnHeader();
            dvkt = new ColumnHeader();
            doctorName = new ColumnHeader();
            time = new ColumnHeader();
            SuspendLayout();
            // 
            // bacsi_datlich_label
            // 
            bacsi_datlich_label.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            bacsi_datlich_label.ForeColor = SystemColors.ActiveCaption;
            bacsi_datlich_label.Location = new Point(12, 9);
            bacsi_datlich_label.Name = "bacsi_datlich_label";
            bacsi_datlich_label.Size = new Size(322, 32);
            bacsi_datlich_label.TabIndex = 8;
            bacsi_datlich_label.Text = "Lịch làm việc của bác sĩ";
            // 
            // edit_datlich
            // 
            edit_datlich.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            edit_datlich.BackColor = Color.Red;
            edit_datlich.Cursor = Cursors.Hand;
            edit_datlich.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            edit_datlich.Depth = 0;
            edit_datlich.ForeColor = SystemColors.ActiveCaption;
            edit_datlich.HighEmphasis = true;
            edit_datlich.Icon = null;
            edit_datlich.Location = new Point(342, 9);
            edit_datlich.Margin = new Padding(5);
            edit_datlich.MouseState = MaterialSkin.MouseState.HOVER;
            edit_datlich.Name = "edit_datlich";
            edit_datlich.NoAccentTextColor = Color.Empty;
            edit_datlich.Size = new Size(82, 36);
            edit_datlich.TabIndex = 10;
            edit_datlich.Text = "Đổi lịch";
            edit_datlich.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            edit_datlich.UseAccentColor = false;
            edit_datlich.UseVisualStyleBackColor = false;
            edit_datlich.Click += edit_datlich_Click;
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
            datlichListView.Location = new Point(12, 65);
            datlichListView.MinimumSize = new Size(200, 100);
            datlichListView.MouseLocation = new Point(-1, -1);
            datlichListView.MouseState = MaterialSkin.MouseState.OUT;
            datlichListView.Name = "datlichListView";
            datlichListView.OwnerDraw = true;
            datlichListView.Size = new Size(970, 644);
            datlichListView.TabIndex = 12;
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
            // BacSiDatLichForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(datlichListView);
            Controls.Add(edit_datlich);
            Controls.Add(bacsi_datlich_label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BacSiDatLichForm";
            Text = "Lịch làm việc của bác sĩ";
            Load += BacSiDatLichForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bacsi_datlich_label;
        private MaterialSkin.Controls.MaterialButton edit_datlich;
        private MaterialSkin.Controls.MaterialListView datlichListView;
        private ColumnHeader temp;
        private ColumnHeader no;
        private ColumnHeader patientName;
        private ColumnHeader dvkt;
        private ColumnHeader doctorName;
        private ColumnHeader time;
    }
}