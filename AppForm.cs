using MaterialSkin;
using MaterialSkin.Controls;

namespace ezbooking;

public partial class AppForm : MaterialForm
{
    public AppForm()
    {
        InitializeComponent();

        this.FormClosed += AppForm_FormClosed;

        // Set the form to full screen when it is loaded
        this.WindowState = FormWindowState.Maximized;

        // Apply material skin
        //var materialSkinManager = MaterialSkinManager.Instance;
        //materialSkinManager.AddFormToManage(this);
        //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        //materialSkinManager.ColorScheme = new ColorScheme(
        //                                     Primary.Blue600, // Primary color
        //                                     Primary.Blue700, // Primary dark color
        //                                     Primary.Blue200, // Primary light color
        //                                     Accent.Blue700,  // Accent color
        //                                     TextShade.WHITE   // Text color
        //                                 );

    }

    private void AppForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void AppForm_Load(object sender, EventArgs e)
    {

    }

    private void materialLabel1_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void docter_add_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
