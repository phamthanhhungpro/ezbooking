namespace ezbooking.Forms
{
    partial class DatLichBenhNhanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatLichBenhNhanForm));
            datlich_listbox = new MaterialSkin.Controls.MaterialListBox();
            save_btn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // datlich_listbox
            // 
            datlich_listbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            datlich_listbox.BackColor = Color.White;
            datlich_listbox.BorderColor = Color.LightGray;
            datlich_listbox.Depth = 0;
            datlich_listbox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            datlich_listbox.Location = new Point(-2, 41);
            datlich_listbox.MouseState = MaterialSkin.MouseState.HOVER;
            datlich_listbox.Name = "datlich_listbox";
            datlich_listbox.SelectedIndex = -1;
            datlich_listbox.SelectedItem = null;
            datlich_listbox.Size = new Size(982, 320);
            datlich_listbox.TabIndex = 0;
            // 
            // save_btn
            // 
            save_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            save_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            save_btn.Depth = 0;
            save_btn.HighEmphasis = true;
            save_btn.Icon = null;
            save_btn.Location = new Point(465, 405);
            save_btn.Margin = new Padding(4, 6, 4, 6);
            save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            save_btn.Name = "save_btn";
            save_btn.NoAccentTextColor = Color.Empty;
            save_btn.Size = new Size(86, 36);
            save_btn.TabIndex = 1;
            save_btn.Text = "Đặt lịch";
            save_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            save_btn.UseAccentColor = false;
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // DatLichBenhNhanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(save_btn);
            Controls.Add(datlich_listbox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DatLichBenhNhanForm";
            Text = "Tự động đặt lịch cho bệnh nhân";
            FormClosing += DatLichBenhNhanForm_Close;
            Load += DatLichBenhNhanForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox datlich_listbox;
        private MaterialSkin.Controls.MaterialButton save_btn;
    }
}