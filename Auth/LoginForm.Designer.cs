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
        usernameLabel = new Label();
        passwordLabel = new Label();
        SuspendLayout();
        // 
        // materialButton1
        // 
        materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        materialButton1.Depth = 0;
        materialButton1.HighEmphasis = true;
        materialButton1.Icon = null;
        materialButton1.Location = new Point(189, 445);
        materialButton1.Margin = new Padding(4, 6, 4, 6);
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
        passwordTxt.AnimateReadOnly = false;
        passwordTxt.AsciiOnly = false;
        passwordTxt.BackgroundImageLayout = ImageLayout.None;
        passwordTxt.BeepOnError = false;
        passwordTxt.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
        passwordTxt.Depth = 0;
        passwordTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        passwordTxt.HidePromptOnLeave = false;
        passwordTxt.HideSelection = true;
        passwordTxt.InsertKeyMode = InsertKeyMode.Default;
        passwordTxt.LeadingIcon = null;
        passwordTxt.Location = new Point(99, 360);
        passwordTxt.Mask = "";
        passwordTxt.MaxLength = 32767;
        passwordTxt.MouseState = MaterialSkin.MouseState.OUT;
        passwordTxt.Name = "passwordTxt";
        passwordTxt.PasswordChar = '\0';
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
        passwordTxt.Size = new Size(307, 48);
        passwordTxt.SkipLiterals = true;
        passwordTxt.TabIndex = 1;
        passwordTxt.TabStop = false;
        passwordTxt.TextAlign = HorizontalAlignment.Left;
        passwordTxt.TextMaskFormat = MaskFormat.IncludeLiterals;
        passwordTxt.TrailingIcon = null;
        passwordTxt.UseSystemPasswordChar = false;
        passwordTxt.ValidatingType = null;
        // 
        // usernameTxt
        // 
        usernameTxt.AllowPromptAsInput = true;
        usernameTxt.AnimateReadOnly = false;
        usernameTxt.AsciiOnly = false;
        usernameTxt.BackgroundImageLayout = ImageLayout.None;
        usernameTxt.BeepOnError = false;
        usernameTxt.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
        usernameTxt.Depth = 0;
        usernameTxt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        usernameTxt.HidePromptOnLeave = false;
        usernameTxt.HideSelection = true;
        usernameTxt.InsertKeyMode = InsertKeyMode.Default;
        usernameTxt.LeadingIcon = null;
        usernameTxt.Location = new Point(99, 254);
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
        usernameTxt.Size = new Size(307, 48);
        usernameTxt.SkipLiterals = true;
        usernameTxt.TabIndex = 2;
        usernameTxt.TabStop = false;
        usernameTxt.TextAlign = HorizontalAlignment.Left;
        usernameTxt.TextMaskFormat = MaskFormat.IncludeLiterals;
        usernameTxt.TrailingIcon = null;
        usernameTxt.UseSystemPasswordChar = false;
        usernameTxt.ValidatingType = null;
        // 
        // usernameLabel
        // 
        usernameLabel.AutoSize = true;
        usernameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        usernameLabel.Location = new Point(99, 226);
        usernameLabel.Name = "usernameLabel";
        usernameLabel.Size = new Size(144, 25);
        usernameLabel.TabIndex = 3;
        usernameLabel.Text = "Tên đăng nhập";
        // 
        // passwordLabel
        // 
        passwordLabel.AutoSize = true;
        passwordLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        passwordLabel.Location = new Point(99, 332);
        passwordLabel.Name = "passwordLabel";
        passwordLabel.Size = new Size(96, 25);
        passwordLabel.TabIndex = 4;
        passwordLabel.Text = "Mật khẩu";
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources.login_background;
        ClientSize = new Size(494, 681);
        Controls.Add(passwordLabel);
        Controls.Add(usernameLabel);
        Controls.Add(usernameTxt);
        Controls.Add(passwordTxt);
        Controls.Add(materialButton1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(3, 2, 3, 2);
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
    private Label usernameLabel;
    private Label passwordLabel;
}
