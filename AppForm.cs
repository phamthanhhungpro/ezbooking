using ezbooking.Forms;
using ezbooking.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ezbooking;

public partial class AppForm : MaterialForm
{
    private readonly AppDbContext _appDbContext;
    private readonly AddUpdateBacSiForm _addUpdateBacSiForm;
    public AppForm(AppDbContext appDbContext,
                   AddUpdateBacSiForm addUpdateBacSiForm)
    {
        InitializeComponent();

        this.FormClosed += AppForm_FormClosed;

        // Set the form to full screen when it is loaded
        this.WindowState = FormWindowState.Maximized;

        // Apply material skin
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = false;

        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        materialSkinManager.ColorScheme = new ColorScheme(
                                             Primary.Blue600, // Primary color
                                             Primary.Blue700, // Primary dark color
                                             Primary.Blue200, // Primary light color
                                             Accent.Blue700,  // Accent color
                                             TextShade.WHITE   // Text color
                                         );

        _appDbContext = appDbContext;
        _addUpdateBacSiForm = addUpdateBacSiForm;

        materialTabControl1.SelectedIndexChanged += TabChanged;
        _addUpdateBacSiForm.DataChanged += TabChanged;
    }

    private void AppForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void AppForm_Load(object sender, EventArgs e)
    {
        LoadTabBacSiKtv();
    }

    private void TabChanged(object sender, EventArgs e)
    {
        switch (materialTabControl1.SelectedIndex)
        {
            case 0:
                // load tab 1 here
                LoadTabBacSiKtv();
                break;
            case 1:
                Console.WriteLine("Tab 2");
                break;
            case 2:
                Console.WriteLine("Tab 3");
                break;
            default:
                break;
        }
    }

    private void LoadTabBacSiKtv()
    {
        var data = _appDbContext.BacSiKTVs.OrderByDescending(o => o.CreatedAt).ToList();

        FillDataToDoctorListView(data);
    }

    private void materialButton1_Click(object sender, EventArgs e)
    {

    }

    private void add_doctor_btn_Click(object sender, EventArgs e)
    {
        //var addDoctorModel = new BacSiKTV()
        //{
        //    TenBacSiKTV = "Bác sĩ Hải",
        //    DiaChi = "Trái đất",
        //    SoDienThoai = "0912345678",
        //    Email = "abc@gmail.com",
        //    TrangThai = "Online",
        //    GioBatDau = new TimeOnly(08, 00),
        //    GioKetThuc = new TimeOnly(17, 00)
        //};

        //_appDbContext.Add(addDoctorModel);
        //_appDbContext.SaveChanges();

        //LoadTabBacSiKtv();

        // Open a new form
        _addUpdateBacSiForm.ShowDialog();
    }

    private void doctorListView_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void searchTextBox_TextChanged(object sender, EventArgs e)
    {
        var data = _appDbContext.BacSiKTVs.ToList();

        if (searchTextBox.Text != null)
        {
            data = data.Where(x => x.TenBacSiKTV.ToLower().Contains(searchTextBox.Text.ToLower(), StringComparison.OrdinalIgnoreCase)).ToList();
        }
        else
        {
            return;
        }

        FillDataToDoctorListView(data);
    }

    private void FillDataToDoctorListView(List<BacSiKTV> data)
    {
        doctorListView.Items.Clear();

        foreach (var item in data)
        {
            var newItem = new ListViewItem();

            newItem.SubItems.Add(item.Id.ToString());
            newItem.SubItems.Add(item.TenBacSiKTV);
            newItem.SubItems.Add(item.SoDienThoai);
            newItem.SubItems.Add(item.TrangThai);

            doctorListView.Items.Add(newItem);
        }
    }
}
