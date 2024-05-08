namespace ezbooking;

public partial class LoginForm : Form
{
    private readonly AppForm _appForm;
    public LoginForm(AppForm appForm)
    {
        InitializeComponent();
        _appForm = appForm;
    }

    private void login_btn_Click(object sender, EventArgs e)
    {
        if (usernameTxt.Text == "admin" && passwordTxt.Text == "12341234")
        {
            // Close the login form
            this.Hide();

            // Show the main form
            _appForm.Show();
        }
        else
        {
            MessageBox.Show("Login failed!");
        }

    }

    private void LoginForm_Load(object sender, EventArgs e)
    {

    }
}
