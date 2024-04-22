namespace ezbooking.Forms
{
    partial class AddUpdateDatLichForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateDatLichForm));
            panel1 = new Panel();
            save_btn = new MaterialSkin.Controls.MaterialButton();
            bacsiLabel = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dvktCheckList = new CheckedListBox();
            bacsiCheckBox = new CheckedListBox();
            tenbenhnhan = new MaterialSkin.Controls.MaterialMaskedTextBox();
            dvktLabel = new MaterialSkin.Controls.MaterialLabel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(save_btn);
            panel1.Controls.Add(bacsiLabel);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(tenbenhnhan);
            panel1.Controls.Add(dvktLabel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 570);
            panel1.TabIndex = 0;
            // 
            // save_btn
            // 
            save_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            save_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            save_btn.Depth = 0;
            save_btn.HighEmphasis = true;
            save_btn.Icon = null;
            save_btn.Location = new Point(446, 473);
            save_btn.Margin = new Padding(4, 6, 4, 6);
            save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            save_btn.Name = "save_btn";
            save_btn.NoAccentTextColor = Color.Empty;
            save_btn.Size = new Size(130, 36);
            save_btn.TabIndex = 6;
            save_btn.Text = "Lưu thông tin";
            save_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            save_btn.UseAccentColor = false;
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // bacsiLabel
            // 
            bacsiLabel.AutoSize = true;
            bacsiLabel.Depth = 0;
            bacsiLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            bacsiLabel.Location = new Point(515, 70);
            bacsiLabel.MouseState = MaterialSkin.MouseState.HOVER;
            bacsiLabel.Name = "bacsiLabel";
            bacsiLabel.Size = new Size(84, 19);
            bacsiLabel.TabIndex = 3;
            bacsiLabel.Text = "Chọn bác sĩ";
            bacsiLabel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dvktCheckList, 0, 0);
            tableLayoutPanel1.Controls.Add(bacsiCheckBox, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 93);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1000, 309);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dvktCheckList
            // 
            dvktCheckList.Dock = DockStyle.Fill;
            dvktCheckList.FormattingEnabled = true;
            dvktCheckList.Location = new Point(3, 3);
            dvktCheckList.Name = "dvktCheckList";
            dvktCheckList.Size = new Size(494, 303);
            dvktCheckList.TabIndex = 0;
            dvktCheckList.ItemCheck += dvktCheckList_ItemCheck;
            // 
            // bacsiCheckBox
            // 
            bacsiCheckBox.Dock = DockStyle.Fill;
            bacsiCheckBox.FormattingEnabled = true;
            bacsiCheckBox.Location = new Point(503, 3);
            bacsiCheckBox.Name = "bacsiCheckBox";
            bacsiCheckBox.Size = new Size(494, 303);
            bacsiCheckBox.TabIndex = 1;
            bacsiCheckBox.Visible = false;
            bacsiCheckBox.ItemCheck += bacsiCheckList_ItemCheck;
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
            tenbenhnhan.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tenbenhnhan.HidePromptOnLeave = false;
            tenbenhnhan.HideSelection = true;
            tenbenhnhan.Hint = "Tên bệnh nhân";
            tenbenhnhan.InsertKeyMode = InsertKeyMode.Default;
            tenbenhnhan.LeadingIcon = null;
            tenbenhnhan.Location = new Point(350, 12);
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
            tenbenhnhan.Size = new Size(312, 48);
            tenbenhnhan.SkipLiterals = true;
            tenbenhnhan.TabIndex = 0;
            tenbenhnhan.TabStop = false;
            tenbenhnhan.TextAlign = HorizontalAlignment.Left;
            tenbenhnhan.TextMaskFormat = MaskFormat.IncludeLiterals;
            tenbenhnhan.TrailingIcon = null;
            tenbenhnhan.UseSystemPasswordChar = false;
            tenbenhnhan.ValidatingType = null;
            // 
            // dvktLabel
            // 
            dvktLabel.AutoSize = true;
            dvktLabel.Depth = 0;
            dvktLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dvktLabel.Location = new Point(16, 70);
            dvktLabel.MouseState = MaterialSkin.MouseState.HOVER;
            dvktLabel.Name = "dvktLabel";
            dvktLabel.Size = new Size(180, 19);
            dvktLabel.TabIndex = 2;
            dvktLabel.Text = "Chọn dịch vụ cần đặt lịch";
            // 
            // AddUpdateDatLichForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 582);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUpdateDatLichForm";
            Text = "Thêm/Cập nhật đặt lịch của bệnh nhân";
            FormClosing += AddUpdateDatLichForm_Close;
            Load += AddUpdateDatLichForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox tenbenhnhan;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel bacsiLabel;
        private MaterialSkin.Controls.MaterialLabel dvktLabel;
        private CheckedListBox dvktCheckList;
        private CheckedListBox bacsiCheckBox;
        private MaterialSkin.Controls.MaterialButton save_btn;
    }
}