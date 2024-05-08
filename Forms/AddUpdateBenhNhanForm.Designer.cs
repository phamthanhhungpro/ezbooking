﻿namespace ezbooking.Forms
{
    partial class AddUpdateBenhNhanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateBenhNhanForm));
            AddUpdateBenhNhanLayout = new TableLayoutPanel();
            phone = new MaterialSkin.Controls.MaterialMaskedTextBox();
            name = new MaterialSkin.Controls.MaterialMaskedTextBox();
            address = new MaterialSkin.Controls.MaterialMaskedTextBox();
            benhnhanDvkts = new MaterialSkin.Controls.MaterialCheckedListBox();
            save_btn = new MaterialSkin.Controls.MaterialButton();
            AddUpdateBenhNhanLayout.SuspendLayout();
            SuspendLayout();
            // 
            // AddUpdateBenhNhanLayout
            // 
            AddUpdateBenhNhanLayout.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddUpdateBenhNhanLayout.ColumnCount = 2;
            AddUpdateBenhNhanLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            AddUpdateBenhNhanLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            AddUpdateBenhNhanLayout.Controls.Add(phone, 0, 1);
            AddUpdateBenhNhanLayout.Controls.Add(name, 0, 0);
            AddUpdateBenhNhanLayout.Controls.Add(address, 1, 0);
            AddUpdateBenhNhanLayout.Controls.Add(benhnhanDvkts, 0, 2);
            AddUpdateBenhNhanLayout.Controls.Add(save_btn, 0, 3);
            AddUpdateBenhNhanLayout.Location = new Point(1, 54);
            AddUpdateBenhNhanLayout.Name = "AddUpdateBenhNhanLayout";
            AddUpdateBenhNhanLayout.RowCount = 4;
            AddUpdateBenhNhanLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            AddUpdateBenhNhanLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            AddUpdateBenhNhanLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            AddUpdateBenhNhanLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            AddUpdateBenhNhanLayout.Size = new Size(982, 413);
            AddUpdateBenhNhanLayout.TabIndex = 0;
            // 
            // phone
            // 
            phone.AllowPromptAsInput = true;
            phone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            phone.AnimateReadOnly = false;
            phone.AsciiOnly = false;
            phone.BackgroundImageLayout = ImageLayout.None;
            phone.BeepOnError = false;
            phone.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            phone.Depth = 0;
            phone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            phone.HidePromptOnLeave = false;
            phone.HideSelection = true;
            phone.Hint = "Số điện thoại";
            phone.InsertKeyMode = InsertKeyMode.Default;
            phone.LeadingIcon = null;
            phone.Location = new Point(3, 99);
            phone.Mask = "";
            phone.MaxLength = 32767;
            phone.MouseState = MaterialSkin.MouseState.OUT;
            phone.Name = "phone";
            phone.PasswordChar = '\0';
            phone.PrefixSuffixText = null;
            phone.PromptChar = '_';
            phone.ReadOnly = false;
            phone.RejectInputOnFirstFailure = false;
            phone.ResetOnPrompt = true;
            phone.ResetOnSpace = true;
            phone.RightToLeft = RightToLeft.No;
            phone.SelectedText = "";
            phone.SelectionLength = 0;
            phone.SelectionStart = 0;
            phone.ShortcutsEnabled = true;
            phone.Size = new Size(485, 48);
            phone.SkipLiterals = true;
            phone.TabIndex = 2;
            phone.TabStop = false;
            phone.TextAlign = HorizontalAlignment.Left;
            phone.TextMaskFormat = MaskFormat.IncludeLiterals;
            phone.TrailingIcon = null;
            phone.UseSystemPasswordChar = false;
            phone.ValidatingType = null;
            // 
            // name
            // 
            name.AllowPromptAsInput = true;
            name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            name.AnimateReadOnly = false;
            name.AsciiOnly = false;
            name.BackgroundImageLayout = ImageLayout.None;
            name.BeepOnError = false;
            name.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            name.Depth = 0;
            name.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            name.HidePromptOnLeave = false;
            name.HideSelection = true;
            name.Hint = "Tên bệnh nhân";
            name.InsertKeyMode = InsertKeyMode.Default;
            name.LeadingIcon = null;
            name.Location = new Point(3, 17);
            name.Mask = "";
            name.MaxLength = 32767;
            name.MouseState = MaterialSkin.MouseState.OUT;
            name.Name = "name";
            name.PasswordChar = '\0';
            name.PrefixSuffixText = null;
            name.PromptChar = '_';
            name.ReadOnly = false;
            name.RejectInputOnFirstFailure = false;
            name.ResetOnPrompt = true;
            name.ResetOnSpace = true;
            name.RightToLeft = RightToLeft.No;
            name.SelectedText = "";
            name.SelectionLength = 0;
            name.SelectionStart = 0;
            name.ShortcutsEnabled = true;
            name.Size = new Size(485, 48);
            name.SkipLiterals = true;
            name.TabIndex = 0;
            name.TabStop = false;
            name.TextAlign = HorizontalAlignment.Left;
            name.TextMaskFormat = MaskFormat.IncludeLiterals;
            name.TrailingIcon = null;
            name.UseSystemPasswordChar = false;
            name.ValidatingType = null;
            // 
            // address
            // 
            address.AllowPromptAsInput = true;
            address.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            address.AnimateReadOnly = false;
            address.AsciiOnly = false;
            address.BackgroundImageLayout = ImageLayout.None;
            address.BeepOnError = false;
            address.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            address.Depth = 0;
            address.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            address.HidePromptOnLeave = false;
            address.HideSelection = true;
            address.Hint = "Địa chỉ";
            address.InsertKeyMode = InsertKeyMode.Default;
            address.LeadingIcon = null;
            address.Location = new Point(494, 17);
            address.Mask = "";
            address.MaxLength = 32767;
            address.MouseState = MaterialSkin.MouseState.OUT;
            address.Name = "address";
            address.PasswordChar = '\0';
            address.PrefixSuffixText = null;
            address.PromptChar = '_';
            address.ReadOnly = false;
            address.RejectInputOnFirstFailure = false;
            address.ResetOnPrompt = true;
            address.ResetOnSpace = true;
            address.RightToLeft = RightToLeft.No;
            address.SelectedText = "";
            address.SelectionLength = 0;
            address.SelectionStart = 0;
            address.ShortcutsEnabled = true;
            address.Size = new Size(485, 48);
            address.SkipLiterals = true;
            address.TabIndex = 1;
            address.TabStop = false;
            address.TextAlign = HorizontalAlignment.Left;
            address.TextMaskFormat = MaskFormat.IncludeLiterals;
            address.TrailingIcon = null;
            address.UseSystemPasswordChar = false;
            address.ValidatingType = null;
            // 
            // benhnhanDvkts
            // 
            benhnhanDvkts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            benhnhanDvkts.AutoScroll = true;
            benhnhanDvkts.BackColor = SystemColors.Control;
            benhnhanDvkts.Depth = 0;
            benhnhanDvkts.Location = new Point(3, 167);
            benhnhanDvkts.MouseState = MaterialSkin.MouseState.HOVER;
            benhnhanDvkts.Name = "benhnhanDvkts";
            benhnhanDvkts.Size = new Size(485, 200);
            benhnhanDvkts.Striped = false;
            benhnhanDvkts.StripeDarkColor = Color.Empty;
            benhnhanDvkts.TabIndex = 3;
            // 
            // save_btn
            // 
            save_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            save_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            save_btn.Depth = 0;
            save_btn.HighEmphasis = true;
            save_btn.Icon = null;
            save_btn.Location = new Point(4, 376);
            save_btn.Margin = new Padding(4, 6, 4, 6);
            save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            save_btn.Name = "save_btn";
            save_btn.NoAccentTextColor = Color.Empty;
            save_btn.Size = new Size(64, 31);
            save_btn.TabIndex = 4;
            save_btn.Text = "Lưu";
            save_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            save_btn.UseAccentColor = false;
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // AddUpdateBenhNhanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(AddUpdateBenhNhanLayout);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUpdateBenhNhanForm";
            Text = "Thêm/Cập nhật thông tin bệnh nhân";
            FormClosing += AddUpdateBenhNhanForm_Close;
            Load += AddUpdateBenhNhanForm_Load;
            AddUpdateBenhNhanLayout.ResumeLayout(false);
            AddUpdateBenhNhanLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel AddUpdateBenhNhanLayout;
        private MaterialSkin.Controls.MaterialMaskedTextBox name;
        private MaterialSkin.Controls.MaterialMaskedTextBox phone;
        private MaterialSkin.Controls.MaterialMaskedTextBox address;
        private MaterialSkin.Controls.MaterialCheckedListBox benhnhanDvkts;
        private MaterialSkin.Controls.MaterialButton save_btn;
    }
}