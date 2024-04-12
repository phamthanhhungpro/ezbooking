namespace ezbooking;

partial class LoginForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
        materialButton1 = new MaterialSkin.Controls.MaterialButton();
        passwordTxt = new MaterialSkin.Controls.MaterialMaskedTextBox();
        usernameTxt = new MaterialSkin.Controls.MaterialMaskedTextBox();
        SuspendLayout();
        // 
        // materialButton1
        // 
        materialButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        materialButton1.Depth = 0;
        materialButton1.HighEmphasis = true;
        materialButton1.Icon = null;
        materialButton1.Location = new Point(121, 327);
        materialButton1.Margin = new Padding(5, 8, 5, 8);
        materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
        materialButton1.Name = "materialButton1";
        materialButton1.NoAccentTextColor = Color.Empty;
        materialButton1.Size = new Size(105, 36);
        materialButton1.TabIndex = 0;
        materialButton1.Text = "Đăng nhập";
        materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        materialButton1.UseAccentColor = false;
        materialButton1.UseVisualStyleBackColor = true;
        materialButton1.Click += login_btn_Click;
        // 
        // passwordTxt
        // 
        passwordTxt.AllowPromptAsInput = true;
        passwordTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        passwordTxt.AnimateReadOnly = false;
        passwordTxt.AsciiOnly = false;
        passwordTxt.BackgroundImageLayout = ImageLayout.None;
        passwordTxt.BeepOnError = false;
        passwordTxt.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
        passwordTxt.Depth = 0;
        passwordTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        passwordTxt.HidePromptOnLeave = false;
        passwordTxt.HideSelection = true;
        passwordTxt.Hint = "Mật khẩu";
        passwordTxt.InsertKeyMode = InsertKeyMode.Default;
        passwordTxt.LeadingIcon = null;
        passwordTxt.Location = new Point(42, 252);
        passwordTxt.Margin = new Padding(3, 4, 3, 4);
        passwordTxt.Mask = "";
        passwordTxt.MaxLength = 32767;
        passwordTxt.MouseState = MaterialSkin.MouseState.OUT;
        passwordTxt.Name = "passwordTxt";
        passwordTxt.PasswordChar = '●';
        passwordTxt.PrefixSuffixText = null;
        passwordTxt.PromptChar = '_';
        passwordTxt.ReadOnly = false;
        passwordTxt.RejectInputOnFirstFailure = false;
        passwordTxt.ResetOnPrompt = true;
        passwordTxt.ResetOnSpace = true;
        passwordTxt.RightToLeft = RightToLeft.No;
        passwordTxt.SelectedText = "";
        passwordTxt.SelectionLength = 0;
        passwordTxt.SelectionStart = 0;
        passwordTxt.ShortcutsEnabled = true;
        passwordTxt.Size = new Size(279, 48);
        passwordTxt.SkipLiterals = true;
        passwordTxt.TabIndex = 1;
        passwordTxt.TabStop = false;
        passwordTxt.TextAlign = HorizontalAlignment.Left;
        passwordTxt.TextMaskFormat = MaskFormat.IncludeLiterals;
        passwordTxt.TrailingIcon = null;
        passwordTxt.UseSystemPasswordChar = true;
        passwordTxt.ValidatingType = null;
        // 
        // usernameTxt
        // 
        usernameTxt.AllowPromptAsInput = true;
        usernameTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        usernameTxt.AnimateReadOnly = false;
        usernameTxt.AsciiOnly = false;
        usernameTxt.BackgroundImageLayout = ImageLayout.None;
        usernameTxt.BeepOnError = false;
        usernameTxt.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
        usernameTxt.Depth = 0;
        usernameTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        usernameTxt.HidePromptOnLeave = false;
        usernameTxt.HideSelection = true;
        usernameTxt.Hint = "Tên đăng nhập";
        usernameTxt.InsertKeyMode = InsertKeyMode.Default;
        usernameTxt.LeadingIcon = null;
        usernameTxt.Location = new Point(42, 187);
        usernameTxt.Margin = new Padding(3, 4, 3, 4);
        usernameTxt.Mask = "";
        usernameTxt.MaxLength = 32767;
        usernameTxt.MouseState = MaterialSkin.MouseState.OUT;
        usernameTxt.Name = "usernameTxt";
        usernameTxt.PasswordChar = '\0';
        usernameTxt.PrefixSuffixText = null;
        usernameTxt.PromptChar = '_';
        usernameTxt.ReadOnly = false;
        usernameTxt.RejectInputOnFirstFailure = false;
        usernameTxt.ResetOnPrompt = true;
        usernameTxt.ResetOnSpace = true;
        usernameTxt.RightToLeft = RightToLeft.No;
        usernameTxt.SelectedText = "";
        usernameTxt.SelectionLength = 0;
        usernameTxt.SelectionStart = 0;
        usernameTxt.ShortcutsEnabled = true;
        usernameTxt.Size = new Size(279, 48);
        usernameTxt.SkipLiterals = true;
        usernameTxt.TabIndex = 2;
        usernameTxt.TabStop = false;
        usernameTxt.TextAlign = HorizontalAlignment.Left;
        usernameTxt.TextMaskFormat = MaskFormat.IncludeLiterals;
        usernameTxt.TrailingIcon = null;
        usernameTxt.UseSystemPasswordChar = false;
        usernameTxt.ValidatingType = null;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources._2503670;
        ClientSize = new Size(822, 538);
        Controls.Add(usernameTxt);
        Controls.Add(passwordTxt);
        Controls.Add(materialButton1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Đăng nhập";
        Load += LoginForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MaterialSkin.Controls.MaterialButton materialButton1;
    private MaterialSkin.Controls.MaterialMaskedTextBox passwordTxt;
    private MaterialSkin.Controls.MaterialMaskedTextBox usernameTxt;
}
