namespace ezbooking.Forms
{
    partial class AddUpdateBacSiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateBacSiForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            doctorEndTime = new MaterialSkin.Controls.MaterialMaskedTextBox();
            doctorStartTime = new MaterialSkin.Controls.MaterialMaskedTextBox();
            doctorEmail = new MaterialSkin.Controls.MaterialMaskedTextBox();
            doctorPhone = new MaterialSkin.Controls.MaterialMaskedTextBox();
            doctorAddress = new MaterialSkin.Controls.MaterialMaskedTextBox();
            doctorName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            doctorSave = new MaterialSkin.Controls.MaterialButton();
            doctorDvktCheckList = new MaterialSkin.Controls.MaterialCheckedListBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(doctorEndTime, 1, 2);
            tableLayoutPanel1.Controls.Add(doctorStartTime, 0, 2);
            tableLayoutPanel1.Controls.Add(doctorEmail, 1, 1);
            tableLayoutPanel1.Controls.Add(doctorPhone, 0, 1);
            tableLayoutPanel1.Controls.Add(doctorAddress, 1, 0);
            tableLayoutPanel1.Controls.Add(doctorName, 0, 0);
            tableLayoutPanel1.Controls.Add(doctorSave, 0, 4);
            tableLayoutPanel1.Controls.Add(doctorDvktCheckList, 0, 3);
            tableLayoutPanel1.Location = new Point(12, 36);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(776, 402);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // doctorEndTime
            // 
            doctorEndTime.AllowPromptAsInput = true;
            doctorEndTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            doctorEndTime.AnimateReadOnly = false;
            doctorEndTime.AsciiOnly = false;
            doctorEndTime.BackgroundImageLayout = ImageLayout.None;
            doctorEndTime.BeepOnError = false;
            doctorEndTime.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            doctorEndTime.Depth = 0;
            doctorEndTime.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            doctorEndTime.HidePromptOnLeave = false;
            doctorEndTime.HideSelection = true;
            doctorEndTime.Hint = "Giờ kết thúc làm việc";
            doctorEndTime.InsertKeyMode = InsertKeyMode.Default;
            doctorEndTime.LeadingIcon = null;
            doctorEndTime.Location = new Point(391, 176);
            doctorEndTime.Mask = "";
            doctorEndTime.MaxLength = 32767;
            doctorEndTime.MouseState = MaterialSkin.MouseState.OUT;
            doctorEndTime.Name = "doctorEndTime";
            doctorEndTime.PasswordChar = '\0';
            doctorEndTime.PrefixSuffixText = null;
            doctorEndTime.PromptChar = '_';
            doctorEndTime.ReadOnly = false;
            doctorEndTime.RejectInputOnFirstFailure = false;
            doctorEndTime.ResetOnPrompt = true;
            doctorEndTime.ResetOnSpace = true;
            doctorEndTime.RightToLeft = RightToLeft.No;
            doctorEndTime.SelectedText = "";
            doctorEndTime.SelectionLength = 0;
            doctorEndTime.SelectionStart = 0;
            doctorEndTime.ShortcutsEnabled = true;
            doctorEndTime.Size = new Size(382, 48);
            doctorEndTime.SkipLiterals = true;
            doctorEndTime.TabIndex = 5;
            doctorEndTime.TabStop = false;
            doctorEndTime.TextAlign = HorizontalAlignment.Left;
            doctorEndTime.TextMaskFormat = MaskFormat.IncludeLiterals;
            doctorEndTime.TrailingIcon = null;
            doctorEndTime.UseSystemPasswordChar = false;
            doctorEndTime.ValidatingType = null;
            // 
            // doctorStartTime
            // 
            doctorStartTime.AllowPromptAsInput = true;
            doctorStartTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            doctorStartTime.AnimateReadOnly = false;
            doctorStartTime.AsciiOnly = false;
            doctorStartTime.BackgroundImageLayout = ImageLayout.None;
            doctorStartTime.BeepOnError = false;
            doctorStartTime.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            doctorStartTime.Depth = 0;
            doctorStartTime.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            doctorStartTime.HidePromptOnLeave = false;
            doctorStartTime.HideSelection = true;
            doctorStartTime.Hint = "Giờ bắt đầu làm việc";
            doctorStartTime.InsertKeyMode = InsertKeyMode.Default;
            doctorStartTime.LeadingIcon = null;
            doctorStartTime.Location = new Point(3, 176);
            doctorStartTime.Mask = "";
            doctorStartTime.MaxLength = 32767;
            doctorStartTime.MouseState = MaterialSkin.MouseState.OUT;
            doctorStartTime.Name = "doctorStartTime";
            doctorStartTime.PasswordChar = '\0';
            doctorStartTime.PrefixSuffixText = null;
            doctorStartTime.PromptChar = '_';
            doctorStartTime.ReadOnly = false;
            doctorStartTime.RejectInputOnFirstFailure = false;
            doctorStartTime.ResetOnPrompt = true;
            doctorStartTime.ResetOnSpace = true;
            doctorStartTime.RightToLeft = RightToLeft.No;
            doctorStartTime.SelectedText = "";
            doctorStartTime.SelectionLength = 0;
            doctorStartTime.SelectionStart = 0;
            doctorStartTime.ShortcutsEnabled = true;
            doctorStartTime.Size = new Size(382, 48);
            doctorStartTime.SkipLiterals = true;
            doctorStartTime.TabIndex = 4;
            doctorStartTime.TabStop = false;
            doctorStartTime.TextAlign = HorizontalAlignment.Left;
            doctorStartTime.TextMaskFormat = MaskFormat.IncludeLiterals;
            doctorStartTime.TrailingIcon = null;
            doctorStartTime.UseSystemPasswordChar = false;
            doctorStartTime.ValidatingType = null;
            // 
            // doctorEmail
            // 
            doctorEmail.AllowPromptAsInput = true;
            doctorEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            doctorEmail.AnimateReadOnly = false;
            doctorEmail.AsciiOnly = false;
            doctorEmail.BackgroundImageLayout = ImageLayout.None;
            doctorEmail.BeepOnError = false;
            doctorEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            doctorEmail.Depth = 0;
            doctorEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            doctorEmail.HidePromptOnLeave = false;
            doctorEmail.HideSelection = true;
            doctorEmail.Hint = "Email";
            doctorEmail.InsertKeyMode = InsertKeyMode.Default;
            doctorEmail.LeadingIcon = null;
            doctorEmail.Location = new Point(391, 96);
            doctorEmail.Mask = "";
            doctorEmail.MaxLength = 32767;
            doctorEmail.MouseState = MaterialSkin.MouseState.OUT;
            doctorEmail.Name = "doctorEmail";
            doctorEmail.PasswordChar = '\0';
            doctorEmail.PrefixSuffixText = null;
            doctorEmail.PromptChar = '_';
            doctorEmail.ReadOnly = false;
            doctorEmail.RejectInputOnFirstFailure = false;
            doctorEmail.ResetOnPrompt = true;
            doctorEmail.ResetOnSpace = true;
            doctorEmail.RightToLeft = RightToLeft.No;
            doctorEmail.SelectedText = "";
            doctorEmail.SelectionLength = 0;
            doctorEmail.SelectionStart = 0;
            doctorEmail.ShortcutsEnabled = true;
            doctorEmail.Size = new Size(382, 48);
            doctorEmail.SkipLiterals = true;
            doctorEmail.TabIndex = 3;
            doctorEmail.TabStop = false;
            doctorEmail.TextAlign = HorizontalAlignment.Left;
            doctorEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            doctorEmail.TrailingIcon = null;
            doctorEmail.UseSystemPasswordChar = false;
            doctorEmail.ValidatingType = null;
            // 
            // doctorPhone
            // 
            doctorPhone.AllowPromptAsInput = true;
            doctorPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            doctorPhone.AnimateReadOnly = false;
            doctorPhone.AsciiOnly = false;
            doctorPhone.BackgroundImageLayout = ImageLayout.None;
            doctorPhone.BeepOnError = false;
            doctorPhone.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            doctorPhone.Depth = 0;
            doctorPhone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            doctorPhone.HidePromptOnLeave = false;
            doctorPhone.HideSelection = true;
            doctorPhone.Hint = "Số điện thoại";
            doctorPhone.InsertKeyMode = InsertKeyMode.Default;
            doctorPhone.LeadingIcon = null;
            doctorPhone.Location = new Point(3, 96);
            doctorPhone.Mask = "";
            doctorPhone.MaxLength = 32767;
            doctorPhone.MouseState = MaterialSkin.MouseState.OUT;
            doctorPhone.Name = "doctorPhone";
            doctorPhone.PasswordChar = '\0';
            doctorPhone.PrefixSuffixText = null;
            doctorPhone.PromptChar = '_';
            doctorPhone.ReadOnly = false;
            doctorPhone.RejectInputOnFirstFailure = false;
            doctorPhone.ResetOnPrompt = true;
            doctorPhone.ResetOnSpace = true;
            doctorPhone.RightToLeft = RightToLeft.No;
            doctorPhone.SelectedText = "";
            doctorPhone.SelectionLength = 0;
            doctorPhone.SelectionStart = 0;
            doctorPhone.ShortcutsEnabled = true;
            doctorPhone.Size = new Size(382, 48);
            doctorPhone.SkipLiterals = true;
            doctorPhone.TabIndex = 2;
            doctorPhone.TabStop = false;
            doctorPhone.TextAlign = HorizontalAlignment.Left;
            doctorPhone.TextMaskFormat = MaskFormat.IncludeLiterals;
            doctorPhone.TrailingIcon = null;
            doctorPhone.UseSystemPasswordChar = false;
            doctorPhone.ValidatingType = null;
            // 
            // doctorAddress
            // 
            doctorAddress.AllowPromptAsInput = true;
            doctorAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            doctorAddress.AnimateReadOnly = false;
            doctorAddress.AsciiOnly = false;
            doctorAddress.BackgroundImageLayout = ImageLayout.None;
            doctorAddress.BeepOnError = false;
            doctorAddress.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            doctorAddress.Depth = 0;
            doctorAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            doctorAddress.HidePromptOnLeave = false;
            doctorAddress.HideSelection = true;
            doctorAddress.Hint = "Địa chỉ";
            doctorAddress.InsertKeyMode = InsertKeyMode.Default;
            doctorAddress.LeadingIcon = null;
            doctorAddress.Location = new Point(391, 16);
            doctorAddress.Mask = "";
            doctorAddress.MaxLength = 32767;
            doctorAddress.MouseState = MaterialSkin.MouseState.OUT;
            doctorAddress.Name = "doctorAddress";
            doctorAddress.PasswordChar = '\0';
            doctorAddress.PrefixSuffixText = null;
            doctorAddress.PromptChar = '_';
            doctorAddress.ReadOnly = false;
            doctorAddress.RejectInputOnFirstFailure = false;
            doctorAddress.ResetOnPrompt = true;
            doctorAddress.ResetOnSpace = true;
            doctorAddress.RightToLeft = RightToLeft.No;
            doctorAddress.SelectedText = "";
            doctorAddress.SelectionLength = 0;
            doctorAddress.SelectionStart = 0;
            doctorAddress.ShortcutsEnabled = true;
            doctorAddress.Size = new Size(382, 48);
            doctorAddress.SkipLiterals = true;
            doctorAddress.TabIndex = 1;
            doctorAddress.TabStop = false;
            doctorAddress.TextAlign = HorizontalAlignment.Left;
            doctorAddress.TextMaskFormat = MaskFormat.IncludeLiterals;
            doctorAddress.TrailingIcon = null;
            doctorAddress.UseSystemPasswordChar = false;
            doctorAddress.ValidatingType = null;
            // 
            // doctorName
            // 
            doctorName.AllowPromptAsInput = true;
            doctorName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            doctorName.AnimateReadOnly = false;
            doctorName.AsciiOnly = false;
            doctorName.BackgroundImageLayout = ImageLayout.None;
            doctorName.BeepOnError = false;
            doctorName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            doctorName.Depth = 0;
            doctorName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            doctorName.HidePromptOnLeave = false;
            doctorName.HideSelection = true;
            doctorName.Hint = "Họ và tên";
            doctorName.InsertKeyMode = InsertKeyMode.Default;
            doctorName.LeadingIcon = null;
            doctorName.Location = new Point(3, 16);
            doctorName.Mask = "";
            doctorName.MaxLength = 32767;
            doctorName.MouseState = MaterialSkin.MouseState.OUT;
            doctorName.Name = "doctorName";
            doctorName.PasswordChar = '\0';
            doctorName.PrefixSuffixText = null;
            doctorName.PromptChar = '_';
            doctorName.ReadOnly = false;
            doctorName.RejectInputOnFirstFailure = false;
            doctorName.ResetOnPrompt = true;
            doctorName.ResetOnSpace = true;
            doctorName.RightToLeft = RightToLeft.No;
            doctorName.SelectedText = "";
            doctorName.SelectionLength = 0;
            doctorName.SelectionStart = 0;
            doctorName.ShortcutsEnabled = true;
            doctorName.Size = new Size(382, 48);
            doctorName.SkipLiterals = true;
            doctorName.TabIndex = 0;
            doctorName.TabStop = false;
            doctorName.TextAlign = HorizontalAlignment.Left;
            doctorName.TextMaskFormat = MaskFormat.IncludeLiterals;
            doctorName.TrailingIcon = null;
            doctorName.UseSystemPasswordChar = false;
            doctorName.ValidatingType = null;
            // 
            // doctorSave
            // 
            doctorSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            doctorSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            doctorSave.Cursor = Cursors.Hand;
            doctorSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            doctorSave.Depth = 0;
            doctorSave.HighEmphasis = true;
            doctorSave.Icon = null;
            doctorSave.Location = new Point(4, 366);
            doctorSave.Margin = new Padding(4, 6, 4, 6);
            doctorSave.MouseState = MaterialSkin.MouseState.HOVER;
            doctorSave.Name = "doctorSave";
            doctorSave.NoAccentTextColor = Color.Empty;
            doctorSave.Size = new Size(130, 30);
            doctorSave.TabIndex = 7;
            doctorSave.Text = "Lưu thông tin";
            doctorSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            doctorSave.UseAccentColor = false;
            doctorSave.UseVisualStyleBackColor = true;
            doctorSave.Click += doctorSave_Click;
            // 
            // doctorDvktCheckList
            // 
            doctorDvktCheckList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            doctorDvktCheckList.AutoScroll = true;
            doctorDvktCheckList.BackColor = SystemColors.Control;
            doctorDvktCheckList.Depth = 0;
            doctorDvktCheckList.Location = new Point(3, 243);
            doctorDvktCheckList.MouseState = MaterialSkin.MouseState.HOVER;
            doctorDvktCheckList.Name = "doctorDvktCheckList";
            doctorDvktCheckList.Size = new Size(382, 114);
            doctorDvktCheckList.Striped = false;
            doctorDvktCheckList.StripeDarkColor = Color.Empty;
            doctorDvktCheckList.TabIndex = 1;
            // 
            // AddUpdateBacSiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUpdateBacSiForm";
            Text = "Thêm/Sửa thông tin bác sĩ-Ktv";
            Load += AddUpdateBacSiForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox doctorEndTime;
        private MaterialSkin.Controls.MaterialMaskedTextBox doctorStartTime;
        private MaterialSkin.Controls.MaterialMaskedTextBox doctorEmail;
        private MaterialSkin.Controls.MaterialMaskedTextBox doctorPhone;
        private MaterialSkin.Controls.MaterialMaskedTextBox doctorAddress;
        private MaterialSkin.Controls.MaterialMaskedTextBox doctorName;
        private MaterialSkin.Controls.MaterialButton doctorSave;
        private MaterialSkin.Controls.MaterialCheckedListBox doctorDvktCheckList;
    }
}