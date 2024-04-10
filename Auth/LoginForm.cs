using ezbooking.Shared;

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
        // Close the login form
        this.Hide();

        // Show the main form
        _appForm.Show();

    }

    private void LoginForm_Load(object sender, EventArgs e)
    {

    }
}
