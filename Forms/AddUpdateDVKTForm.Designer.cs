namespace ezbooking.Forms
{
    partial class AddUpdateDVKTForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            TimeTxt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            ChiPhiTxt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            ComboThietBi = new MaterialSkin.Controls.MaterialComboBox();
            serviceNameTxt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            save_service_btn = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(TimeTxt, 0, 1);
            tableLayoutPanel1.Controls.Add(ChiPhiTxt, 0, 1);
            tableLayoutPanel1.Controls.Add(ComboThietBi, 1, 0);
            tableLayoutPanel1.Controls.Add(serviceNameTxt, 0, 0);
            tableLayoutPanel1.Location = new Point(61, 71);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(618, 296);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // TimeTxt
            // 
            TimeTxt.AllowPromptAsInput = true;
            TimeTxt.AnimateReadOnly = false;
            TimeTxt.AsciiOnly = false;
            TimeTxt.BackgroundImageLayout = ImageLayout.None;
            TimeTxt.BeepOnError = false;
            TimeTxt.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            TimeTxt.Depth = 0;
            TimeTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TimeTxt.HidePromptOnLeave = false;
            TimeTxt.HideSelection = true;
            TimeTxt.Hint = "Thời gian";
            TimeTxt.InsertKeyMode = InsertKeyMode.Default;
            TimeTxt.LeadingIcon = null;
            TimeTxt.Location = new Point(3, 151);
            TimeTxt.Mask = "";
            TimeTxt.MaxLength = 32767;
            TimeTxt.MouseState = MaterialSkin.MouseState.OUT;
            TimeTxt.Name = "TimeTxt";
            TimeTxt.PasswordChar = '\0';
            TimeTxt.PrefixSuffixText = null;
            TimeTxt.PromptChar = '_';
            TimeTxt.ReadOnly = false;
            TimeTxt.RejectInputOnFirstFailure = false;
            TimeTxt.ResetOnPrompt = true;
            TimeTxt.ResetOnSpace = true;
            TimeTxt.RightToLeft = RightToLeft.No;
            TimeTxt.SelectedText = "";
            TimeTxt.SelectionLength = 0;
            TimeTxt.SelectionStart = 0;
            TimeTxt.ShortcutsEnabled = true;
            TimeTxt.Size = new Size(303, 48);
            TimeTxt.SkipLiterals = true;
            TimeTxt.TabIndex = 6;
            TimeTxt.TabStop = false;
            TimeTxt.TextAlign = HorizontalAlignment.Left;
            TimeTxt.TextMaskFormat = MaskFormat.IncludeLiterals;
            TimeTxt.TrailingIcon = null;
            TimeTxt.UseSystemPasswordChar = false;
            TimeTxt.ValidatingType = null;
            // 
            // ChiPhiTxt
            // 
            ChiPhiTxt.AllowPromptAsInput = true;
            ChiPhiTxt.AnimateReadOnly = false;
            ChiPhiTxt.AsciiOnly = false;
            ChiPhiTxt.BackgroundImageLayout = ImageLayout.None;
            ChiPhiTxt.BeepOnError = false;
            ChiPhiTxt.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            ChiPhiTxt.Depth = 0;
            ChiPhiTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ChiPhiTxt.HidePromptOnLeave = false;
            ChiPhiTxt.HideSelection = true;
            ChiPhiTxt.Hint = "Chi phí";
            ChiPhiTxt.InsertKeyMode = InsertKeyMode.Default;
            ChiPhiTxt.LeadingIcon = null;
            ChiPhiTxt.Location = new Point(312, 151);
            ChiPhiTxt.Mask = "";
            ChiPhiTxt.MaxLength = 32767;
            ChiPhiTxt.MouseState = MaterialSkin.MouseState.OUT;
            ChiPhiTxt.Name = "ChiPhiTxt";
            ChiPhiTxt.PasswordChar = '\0';
            ChiPhiTxt.PrefixSuffixText = null;
            ChiPhiTxt.PromptChar = '_';
            ChiPhiTxt.ReadOnly = false;
            ChiPhiTxt.RejectInputOnFirstFailure = false;
            ChiPhiTxt.ResetOnPrompt = true;
            ChiPhiTxt.ResetOnSpace = true;
            ChiPhiTxt.RightToLeft = RightToLeft.No;
            ChiPhiTxt.SelectedText = "";
            ChiPhiTxt.SelectionLength = 0;
            ChiPhiTxt.SelectionStart = 0;
            ChiPhiTxt.ShortcutsEnabled = true;
            ChiPhiTxt.Size = new Size(303, 48);
            ChiPhiTxt.SkipLiterals = true;
            ChiPhiTxt.TabIndex = 5;
            ChiPhiTxt.TabStop = false;
            ChiPhiTxt.TextAlign = HorizontalAlignment.Left;
            ChiPhiTxt.TextMaskFormat = MaskFormat.IncludeLiterals;
            ChiPhiTxt.TrailingIcon = null;
            ChiPhiTxt.UseSystemPasswordChar = false;
            ChiPhiTxt.ValidatingType = null;
            // 
            // ComboThietBi
            // 
            ComboThietBi.AutoResize = false;
            ComboThietBi.BackColor = Color.FromArgb(255, 255, 255);
            ComboThietBi.Depth = 0;
            ComboThietBi.DrawMode = DrawMode.OwnerDrawVariable;
            ComboThietBi.DropDownHeight = 174;
            ComboThietBi.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboThietBi.DropDownWidth = 121;
            ComboThietBi.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboThietBi.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboThietBi.FormattingEnabled = true;
            ComboThietBi.Hint = "Thiết bị";
            ComboThietBi.IntegralHeight = false;
            ComboThietBi.ItemHeight = 43;
            ComboThietBi.Location = new Point(312, 3);
            ComboThietBi.MaxDropDownItems = 4;
            ComboThietBi.MouseState = MaterialSkin.MouseState.OUT;
            ComboThietBi.Name = "ComboThietBi";
            ComboThietBi.Size = new Size(303, 49);
            ComboThietBi.StartIndex = 0;
            ComboThietBi.TabIndex = 7;
            // 
            // serviceNameTxt
            // 
            serviceNameTxt.AllowPromptAsInput = true;
            serviceNameTxt.AnimateReadOnly = false;
            serviceNameTxt.AsciiOnly = false;
            serviceNameTxt.BackgroundImageLayout = ImageLayout.None;
            serviceNameTxt.BeepOnError = false;
            serviceNameTxt.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            serviceNameTxt.Depth = 0;
            serviceNameTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            serviceNameTxt.HidePromptOnLeave = false;
            serviceNameTxt.HideSelection = true;
            serviceNameTxt.Hint = "Tên dịch vụ";
            serviceNameTxt.InsertKeyMode = InsertKeyMode.Default;
            serviceNameTxt.LeadingIcon = null;
            serviceNameTxt.Location = new Point(3, 3);
            serviceNameTxt.Mask = "";
            serviceNameTxt.MaxLength = 32767;
            serviceNameTxt.MouseState = MaterialSkin.MouseState.OUT;
            serviceNameTxt.Name = "serviceNameTxt";
            serviceNameTxt.PasswordChar = '\0';
            serviceNameTxt.PrefixSuffixText = null;
            serviceNameTxt.PromptChar = '_';
            serviceNameTxt.ReadOnly = false;
            serviceNameTxt.RejectInputOnFirstFailure = false;
            serviceNameTxt.ResetOnPrompt = true;
            serviceNameTxt.ResetOnSpace = true;
            serviceNameTxt.RightToLeft = RightToLeft.No;
            serviceNameTxt.SelectedText = "";
            serviceNameTxt.SelectionLength = 0;
            serviceNameTxt.SelectionStart = 0;
            serviceNameTxt.ShortcutsEnabled = true;
            serviceNameTxt.Size = new Size(303, 48);
            serviceNameTxt.SkipLiterals = true;
            serviceNameTxt.TabIndex = 4;
            serviceNameTxt.TabStop = false;
            serviceNameTxt.TextAlign = HorizontalAlignment.Left;
            serviceNameTxt.TextMaskFormat = MaskFormat.IncludeLiterals;
            serviceNameTxt.TrailingIcon = null;
            serviceNameTxt.UseSystemPasswordChar = false;
            serviceNameTxt.ValidatingType = null;
            // 
            // save_service_btn
            // 
            save_service_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            save_service_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            save_service_btn.Depth = 0;
            save_service_btn.HighEmphasis = true;
            save_service_btn.Icon = null;
            save_service_btn.Location = new Point(61, 388);
            save_service_btn.Margin = new Padding(4, 6, 4, 6);
            save_service_btn.MouseState = MaterialSkin.MouseState.HOVER;
            save_service_btn.Name = "save_service_btn";
            save_service_btn.NoAccentTextColor = Color.Empty;
            save_service_btn.Size = new Size(110, 36);
            save_service_btn.TabIndex = 2;
            save_service_btn.Text = "Lưu dịch vụ";
            save_service_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            save_service_btn.UseAccentColor = false;
            save_service_btn.UseVisualStyleBackColor = true;
            save_service_btn.Click += save_service_btn_Click;
            // 
            // AddUpdateDVKTForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(save_service_btn);
            Controls.Add(tableLayoutPanel1);
            Name = "AddUpdateDVKTForm";
            Text = "AddUpdateDVKT";
            FormClosing += AddUpdateDVTKForm_FormClosing;
            Load += AddUpdateDVKTForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox serviceNameTxt;
        private MaterialSkin.Controls.MaterialMaskedTextBox TimeTxt;
        private MaterialSkin.Controls.MaterialMaskedTextBox ChiPhiTxt;
        private MaterialSkin.Controls.MaterialComboBox ComboThietBi;
        private MaterialSkin.Controls.MaterialButton save_service_btn;
    }
}