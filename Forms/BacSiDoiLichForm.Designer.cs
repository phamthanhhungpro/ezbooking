namespace ezbooking.Forms
{
    partial class BacSiDoiLichForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BacSiDoiLichForm));
            tenbacsi = new MaterialSkin.Controls.MaterialMaskedTextBox();
            tenbenhnhan = new MaterialSkin.Controls.MaterialMaskedTextBox();
            tendichvu = new MaterialSkin.Controls.MaterialMaskedTextBox();
            bacsi_checkbox = new CheckedListBox();
            thoigian = new MaterialSkin.Controls.MaterialMaskedTextBox();
            save_btn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // tenbacsi
            // 
            tenbacsi.AllowPromptAsInput = true;
            tenbacsi.AnimateReadOnly = false;
            tenbacsi.AsciiOnly = false;
            tenbacsi.BackgroundImageLayout = ImageLayout.None;
            tenbacsi.BeepOnError = false;
            tenbacsi.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tenbacsi.Depth = 0;
            tenbacsi.Enabled = false;
            tenbacsi.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tenbacsi.HidePromptOnLeave = false;
            tenbacsi.HideSelection = true;
            tenbacsi.Hint = "Tên bác sĩ";
            tenbacsi.InsertKeyMode = InsertKeyMode.Default;
            tenbacsi.LeadingIcon = null;
            tenbacsi.Location = new Point(15, 15);
            tenbacsi.Mask = "";
            tenbacsi.MaxLength = 32767;
            tenbacsi.MouseState = MaterialSkin.MouseState.OUT;
            tenbacsi.Name = "tenbacsi";
            tenbacsi.PasswordChar = '\0';
            tenbacsi.PrefixSuffixText = null;
            tenbacsi.PromptChar = '_';
            tenbacsi.ReadOnly = true;
            tenbacsi.RejectInputOnFirstFailure = false;
            tenbacsi.ResetOnPrompt = true;
            tenbacsi.ResetOnSpace = true;
            tenbacsi.RightToLeft = RightToLeft.No;
            tenbacsi.SelectedText = "";
            tenbacsi.SelectionLength = 0;
            tenbacsi.SelectionStart = 0;
            tenbacsi.ShortcutsEnabled = true;
            tenbacsi.Size = new Size(312, 48);
            tenbacsi.SkipLiterals = true;
            tenbacsi.TabIndex = 1;
            tenbacsi.TabStop = false;
            tenbacsi.TextAlign = HorizontalAlignment.Left;
            tenbacsi.TextMaskFormat = MaskFormat.IncludeLiterals;
            tenbacsi.TrailingIcon = null;
            tenbacsi.UseSystemPasswordChar = false;
            tenbacsi.ValidatingType = null;
            // 
            // tenbenhnhan
            // 
            tenbenhnhan.AllowPromptAsInput = true;
            tenbenhnhan.AnimateReadOnly = false;
            tenbenhnhan.AsciiOnly = false;
            tenbenhnhan.BackgroundImageLayout = ImageLayout.None;
            tenbenhnhan.BeepOnError = false;
            tenbenhnhan.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tenbenhnhan.Depth = 0;
            tenbenhnhan.Enabled = false;
            tenbenhnhan.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tenbenhnhan.HidePromptOnLeave = false;
            tenbenhnhan.HideSelection = true;
            tenbenhnhan.Hint = "Tên bệnh nhân";
            tenbenhnhan.InsertKeyMode = InsertKeyMode.Default;
            tenbenhnhan.LeadingIcon = null;
            tenbenhnhan.Location = new Point(391, 15);
            tenbenhnhan.Mask = "";
            tenbenhnhan.MaxLength = 32767;
            tenbenhnhan.MouseState = MaterialSkin.MouseState.OUT;
            tenbenhnhan.Name = "tenbenhnhan";
            tenbenhnhan.PasswordChar = '\0';
            tenbenhnhan.PrefixSuffixText = null;
            tenbenhnhan.PromptChar = '_';
            tenbenhnhan.ReadOnly = true;
            tenbenhnhan.RejectInputOnFirstFailure = false;
            tenbenhnhan.ResetOnPrompt = true;
            tenbenhnhan.ResetOnSpace = true;
            tenbenhnhan.RightToLeft = RightToLeft.No;
            tenbenhnhan.SelectedText = "";
            tenbenhnhan.SelectionLength = 0;
            tenbenhnhan.SelectionStart = 0;
            tenbenhnhan.ShortcutsEnabled = true;
            tenbenhnhan.Size = new Size(339, 48);
            tenbenhnhan.SkipLiterals = true;
            tenbenhnhan.TabIndex = 2;
            tenbenhnhan.TabStop = false;
            tenbenhnhan.TextAlign = HorizontalAlignment.Left;
            tenbenhnhan.TextMaskFormat = MaskFormat.IncludeLiterals;
            tenbenhnhan.TrailingIcon = null;
            tenbenhnhan.UseSystemPasswordChar = false;
            tenbenhnhan.ValidatingType = null;
            // 
            // tendichvu
            // 
            tendichvu.AllowPromptAsInput = true;
            tendichvu.AnimateReadOnly = false;
            tendichvu.AsciiOnly = false;
            tendichvu.BackgroundImageLayout = ImageLayout.None;
            tendichvu.BeepOnError = false;
            tendichvu.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tendichvu.Depth = 0;
            tendichvu.Enabled = false;
            tendichvu.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tendichvu.HidePromptOnLeave = false;
            tendichvu.HideSelection = true;
            tendichvu.Hint = "Dịch vụ";
            tendichvu.InsertKeyMode = InsertKeyMode.Default;
            tendichvu.LeadingIcon = null;
            tendichvu.Location = new Point(15, 101);
            tendichvu.Mask = "";
            tendichvu.MaxLength = 32767;
            tendichvu.MouseState = MaterialSkin.MouseState.OUT;
            tendichvu.Name = "tendichvu";
            tendichvu.PasswordChar = '\0';
            tendichvu.PrefixSuffixText = null;
            tendichvu.PromptChar = '_';
            tendichvu.ReadOnly = true;
            tendichvu.RejectInputOnFirstFailure = false;
            tendichvu.ResetOnPrompt = true;
            tendichvu.ResetOnSpace = true;
            tendichvu.RightToLeft = RightToLeft.No;
            tendichvu.SelectedText = "";
            tendichvu.SelectionLength = 0;
            tendichvu.SelectionStart = 0;
            tendichvu.ShortcutsEnabled = true;
            tendichvu.Size = new Size(312, 48);
            tendichvu.SkipLiterals = true;
            tendichvu.TabIndex = 3;
            tendichvu.TabStop = false;
            tendichvu.TextAlign = HorizontalAlignment.Left;
            tendichvu.TextMaskFormat = MaskFormat.IncludeLiterals;
            tendichvu.TrailingIcon = null;
            tendichvu.UseSystemPasswordChar = false;
            tendichvu.ValidatingType = null;
            // 
            // bacsi_checkbox
            // 
            bacsi_checkbox.FormattingEnabled = true;
            bacsi_checkbox.Location = new Point(15, 197);
            bacsi_checkbox.Name = "bacsi_checkbox";
            bacsi_checkbox.Size = new Size(715, 158);
            bacsi_checkbox.TabIndex = 4;
            // 
            // thoigian
            // 
            thoigian.AllowPromptAsInput = true;
            thoigian.AnimateReadOnly = false;
            thoigian.AsciiOnly = false;
            thoigian.BackgroundImageLayout = ImageLayout.None;
            thoigian.BeepOnError = false;
            thoigian.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            thoigian.Depth = 0;
            thoigian.Enabled = false;
            thoigian.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            thoigian.HidePromptOnLeave = false;
            thoigian.HideSelection = true;
            thoigian.Hint = "Thời gian";
            thoigian.InsertKeyMode = InsertKeyMode.Default;
            thoigian.LeadingIcon = null;
            thoigian.Location = new Point(391, 101);
            thoigian.Mask = "";
            thoigian.MaxLength = 32767;
            thoigian.MouseState = MaterialSkin.MouseState.OUT;
            thoigian.Name = "thoigian";
            thoigian.PasswordChar = '\0';
            thoigian.PrefixSuffixText = null;
            thoigian.PromptChar = '_';
            thoigian.ReadOnly = true;
            thoigian.RejectInputOnFirstFailure = false;
            thoigian.ResetOnPrompt = true;
            thoigian.ResetOnSpace = true;
            thoigian.RightToLeft = RightToLeft.No;
            thoigian.SelectedText = "";
            thoigian.SelectionLength = 0;
            thoigian.SelectionStart = 0;
            thoigian.ShortcutsEnabled = true;
            thoigian.Size = new Size(339, 48);
            thoigian.SkipLiterals = true;
            thoigian.TabIndex = 5;
            thoigian.TabStop = false;
            thoigian.TextAlign = HorizontalAlignment.Left;
            thoigian.TextMaskFormat = MaskFormat.IncludeLiterals;
            thoigian.TrailingIcon = null;
            thoigian.UseSystemPasswordChar = false;
            thoigian.ValidatingType = null;
            // 
            // save_btn
            // 
            save_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            save_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            save_btn.Depth = 0;
            save_btn.HighEmphasis = true;
            save_btn.Icon = null;
            save_btn.Location = new Point(288, 399);
            save_btn.Margin = new Padding(4, 6, 4, 6);
            save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            save_btn.Name = "save_btn";
            save_btn.NoAccentTextColor = Color.Empty;
            save_btn.Size = new Size(158, 36);
            save_btn.TabIndex = 6;
            save_btn.Text = "Lưu thay đổi";
            save_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            save_btn.UseAccentColor = false;
            save_btn.UseVisualStyleBackColor = true;
            // 
            // BacSiDoiLichForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(save_btn);
            Controls.Add(thoigian);
            Controls.Add(bacsi_checkbox);
            Controls.Add(tendichvu);
            Controls.Add(tenbenhnhan);
            Controls.Add(tenbacsi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BacSiDoiLichForm";
            Text = "Đổi lịch";
            Load += BacSiDoiLichForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox tenbacsi;
        private MaterialSkin.Controls.MaterialMaskedTextBox tenbenhnhan;
        private MaterialSkin.Controls.MaterialMaskedTextBox tendichvu;
        private CheckedListBox bacsi_checkbox;
        private MaterialSkin.Controls.MaterialMaskedTextBox thoigian;
        private MaterialSkin.Controls.MaterialButton save_btn;
    }
}