namespace ezbooking.Forms
{
    partial class LoaiThuThuatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiThuThuatForm));
            thongke_lstview = new MaterialSkin.Controls.MaterialListView();
            temp = new ColumnHeader();
            stt = new ColumnHeader();
            name = new ColumnHeader();
            loaidvkt = new ColumnHeader();
            soluong = new ColumnHeader();
            SuspendLayout();
            // 
            // thongke_lstview
            // 
            thongke_lstview.AutoSizeTable = false;
            thongke_lstview.BackColor = Color.FromArgb(255, 255, 255);
            thongke_lstview.BorderStyle = BorderStyle.None;
            thongke_lstview.Columns.AddRange(new ColumnHeader[] { temp, stt, name, loaidvkt, soluong });
            thongke_lstview.Depth = 0;
            thongke_lstview.Dock = DockStyle.Fill;
            thongke_lstview.FullRowSelect = true;
            thongke_lstview.Location = new Point(0, 0);
            thongke_lstview.MinimumSize = new Size(200, 100);
            thongke_lstview.MouseLocation = new Point(-1, -1);
            thongke_lstview.MouseState = MaterialSkin.MouseState.OUT;
            thongke_lstview.Name = "thongke_lstview";
            thongke_lstview.OwnerDraw = true;
            thongke_lstview.Size = new Size(1006, 721);
            thongke_lstview.TabIndex = 0;
            thongke_lstview.UseCompatibleStateImageBehavior = false;
            thongke_lstview.View = View.Details;
            // 
            // temp
            // 
            temp.Text = "temp";
            temp.Width = 0;
            // 
            // stt
            // 
            stt.Text = "STT";
            stt.Width = 100;
            // 
            // name
            // 
            name.Text = "Họ và tên";
            name.Width = 200;
            // 
            // loaidvkt
            // 
            loaidvkt.Text = "Loại thủ thuật";
            loaidvkt.Width = 150;
            // 
            // soluong
            // 
            soluong.Text = "Số lượng";
            soluong.Width = 150;
            // 
            // LoaiThuThuatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(thongke_lstview);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoaiThuThuatForm";
            Text = "Thống kê loại thủ thật";
            Load += LoaiThuThuatForm_Load;
            FormClosing += LoaiThuThuatForm_Close;
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView thongke_lstview;
        private ColumnHeader temp;
        private ColumnHeader stt;
        private ColumnHeader name;
        private ColumnHeader loaidvkt;
        private ColumnHeader soluong;
    }
}