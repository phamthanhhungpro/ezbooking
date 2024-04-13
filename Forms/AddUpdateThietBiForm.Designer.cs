namespace ezbooking.Forms
{
    partial class AddUpdateThietBiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateThietBiForm));
            device_title_label = new Label();
            panel1 = new Panel();
            time_device_txt = new MaterialSkin.Controls.MaterialTextBox();
            soluong_device_txt = new MaterialSkin.Controls.MaterialTextBox();
            name_device_txt = new MaterialSkin.Controls.MaterialTextBox();
            save_device_btn = new MaterialSkin.Controls.MaterialButton();
            panel2 = new Panel();
            mota_device_txt = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // device_title_label
            // 
            device_title_label.AutoSize = true;
            device_title_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            device_title_label.ForeColor = SystemColors.ActiveCaption;
            device_title_label.Location = new Point(12, 9);
            device_title_label.Name = "device_title_label";
            device_title_label.Size = new Size(203, 31);
            device_title_label.TabIndex = 0;
            device_title_label.Text = "Thông tin thiết bị";
            // 
            // panel1
            // 
            panel1.Controls.Add(time_device_txt);
            panel1.Controls.Add(soluong_device_txt);
            panel1.Controls.Add(name_device_txt);
            panel1.Controls.Add(save_device_btn);
            panel1.Location = new Point(21, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 311);
            panel1.TabIndex = 1;
            // 
            // time_device_txt
            // 
            time_device_txt.AnimateReadOnly = false;
            time_device_txt.BorderStyle = BorderStyle.None;
            time_device_txt.Depth = 0;
            time_device_txt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            time_device_txt.Hint = "Thời gian cách nhau";
            time_device_txt.LeadingIcon = null;
            time_device_txt.Location = new Point(0, 177);
            time_device_txt.MaxLength = 50;
            time_device_txt.MouseState = MaterialSkin.MouseState.OUT;
            time_device_txt.Multiline = false;
            time_device_txt.Name = "time_device_txt";
            time_device_txt.Size = new Size(374, 50);
            time_device_txt.TabIndex = 3;
            time_device_txt.Text = "";
            time_device_txt.TrailingIcon = null;
            // 
            // soluong_device_txt
            // 
            soluong_device_txt.AnimateReadOnly = false;
            soluong_device_txt.BorderStyle = BorderStyle.None;
            soluong_device_txt.Depth = 0;
            soluong_device_txt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            soluong_device_txt.Hint = "Số lượng";
            soluong_device_txt.LeadingIcon = null;
            soluong_device_txt.Location = new Point(0, 88);
            soluong_device_txt.MaxLength = 50;
            soluong_device_txt.MouseState = MaterialSkin.MouseState.OUT;
            soluong_device_txt.Multiline = false;
            soluong_device_txt.Name = "soluong_device_txt";
            soluong_device_txt.Size = new Size(374, 50);
            soluong_device_txt.TabIndex = 2;
            soluong_device_txt.Text = "";
            soluong_device_txt.TrailingIcon = null;
            // 
            // name_device_txt
            // 
            name_device_txt.AnimateReadOnly = false;
            name_device_txt.BorderStyle = BorderStyle.None;
            name_device_txt.Depth = 0;
            name_device_txt.Dock = DockStyle.Top;
            name_device_txt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            name_device_txt.Hint = "Tên thiết bị";
            name_device_txt.LeadingIcon = null;
            name_device_txt.Location = new Point(0, 0);
            name_device_txt.MaxLength = 50;
            name_device_txt.MouseState = MaterialSkin.MouseState.OUT;
            name_device_txt.Multiline = false;
            name_device_txt.Name = "name_device_txt";
            name_device_txt.Size = new Size(374, 50);
            name_device_txt.TabIndex = 1;
            name_device_txt.Text = "";
            name_device_txt.TrailingIcon = null;
            // 
            // save_device_btn
            // 
            save_device_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            save_device_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            save_device_btn.Depth = 0;
            save_device_btn.HighEmphasis = true;
            save_device_btn.Icon = null;
            save_device_btn.Location = new Point(0, 275);
            save_device_btn.Margin = new Padding(4, 6, 4, 6);
            save_device_btn.MouseState = MaterialSkin.MouseState.HOVER;
            save_device_btn.Name = "save_device_btn";
            save_device_btn.NoAccentTextColor = Color.Empty;
            save_device_btn.Size = new Size(111, 36);
            save_device_btn.TabIndex = 0;
            save_device_btn.Text = "Lưu thiết bị";
            save_device_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            save_device_btn.UseAccentColor = false;
            save_device_btn.UseVisualStyleBackColor = true;
            save_device_btn.Click += save_device_btn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(mota_device_txt);
            panel2.Location = new Point(414, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 311);
            panel2.TabIndex = 2;
            // 
            // mota_device_txt
            // 
            mota_device_txt.AnimateReadOnly = false;
            mota_device_txt.BackgroundImageLayout = ImageLayout.None;
            mota_device_txt.CharacterCasing = CharacterCasing.Normal;
            mota_device_txt.Depth = 0;
            mota_device_txt.Dock = DockStyle.Fill;
            mota_device_txt.HideSelection = true;
            mota_device_txt.Hint = "Mô tả";
            mota_device_txt.Location = new Point(0, 0);
            mota_device_txt.MaxLength = 32767;
            mota_device_txt.MouseState = MaterialSkin.MouseState.OUT;
            mota_device_txt.Name = "mota_device_txt";
            mota_device_txt.PasswordChar = '\0';
            mota_device_txt.ReadOnly = false;
            mota_device_txt.ScrollBars = ScrollBars.None;
            mota_device_txt.SelectedText = "";
            mota_device_txt.SelectionLength = 0;
            mota_device_txt.SelectionStart = 0;
            mota_device_txt.ShortcutsEnabled = true;
            mota_device_txt.Size = new Size(374, 311);
            mota_device_txt.TabIndex = 0;
            mota_device_txt.TabStop = false;
            mota_device_txt.TextAlign = HorizontalAlignment.Left;
            mota_device_txt.UseSystemPasswordChar = false;
            // 
            // AddUpdateThietBiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 410);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(device_title_label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUpdateThietBiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUpdateThietBiForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label device_title_label;
        private Panel panel1;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox time_device_txt;
        private MaterialSkin.Controls.MaterialTextBox soluong_device_txt;
        private MaterialSkin.Controls.MaterialTextBox name_device_txt;
        private MaterialSkin.Controls.MaterialButton save_device_btn;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 mota_device_txt;
    }
}