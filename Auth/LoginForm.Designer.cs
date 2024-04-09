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
        login_btn = new Button();
        SuspendLayout();
        // 
        // login_btn
        // 
        login_btn.Location = new Point(376, 187);
        login_btn.Name = "login_btn";
        login_btn.Size = new Size(94, 29);
        login_btn.TabIndex = 0;
        login_btn.Text = "Login";
        login_btn.UseVisualStyleBackColor = true;
        login_btn.Click += login_btn_Click;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(login_btn);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "LoginForm";
        Text = "Đăng nhập";
        Load += LoginForm_Load;
        ResumeLayout(false);
    }

    #endregion

    private Button login_btn;
}
