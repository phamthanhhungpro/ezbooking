using ezbooking.Shared;

namespace ezbooking;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void login_btn_Click(object sender, EventArgs e)
    {
        MessageBox.Show(Constants.SuccessLoginMessage, Constants.Success, MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Close the login form
        this.Hide();

        // Show the main form
        new AppForm().Show();

    }

    private void LoginForm_Load(object sender, EventArgs e)
    {

    }
}
