namespace ezbooking.Forms
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
            SuspendLayout();
            // 
            // AddUpdateBenhNhanLayout
            // 
            AddUpdateBenhNhanLayout.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddUpdateBenhNhanLayout.ColumnCount = 2;
            AddUpdateBenhNhanLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            AddUpdateBenhNhanLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            AddUpdateBenhNhanLayout.Location = new Point(12, 25);
            AddUpdateBenhNhanLayout.Name = "AddUpdateBenhNhanLayout";
            AddUpdateBenhNhanLayout.RowCount = 5;
            AddUpdateBenhNhanLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            AddUpdateBenhNhanLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            AddUpdateBenhNhanLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            AddUpdateBenhNhanLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            AddUpdateBenhNhanLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            AddUpdateBenhNhanLayout.Size = new Size(776, 413);
            AddUpdateBenhNhanLayout.TabIndex = 0;
            // 
            // AddUpdateBenhNhanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddUpdateBenhNhanLayout);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddUpdateBenhNhanForm";
            Text = "Thêm/Cập nhật thông tin bệnh nhân";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel AddUpdateBenhNhanLayout;
    }
}