﻿using ezbooking.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ezbooking;

public partial class AppForm : MaterialForm
{
    private readonly AppDbContext _appDbContext;
    public AppForm(AppDbContext appDbContext)
    {
        InitializeComponent();

        this.FormClosed += AppForm_FormClosed;

        // Set the form to full screen when it is loaded
        this.WindowState = FormWindowState.Maximized;

        // Apply material skin
        var materialSkinManager = MaterialSkinManager.Instance;
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
        materialTabControl1.SelectedIndexChanged += TabChanged;

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
        var data = _appDbContext.BacSiKTVs.ToList();

        var exampleData = new List<BacSiKTV>()
        {
            new(){Id = 1, TenBacSiKTV = "Phạm Thành Hưng", SoDienThoai = "12345678", TrangThai= "Đang trong giờ làm việc" }
        };

        materialListView1.Items.Clear();

        foreach ( var item in exampleData )
        {
            var newItem = new ListViewItem();

            newItem.SubItems.Add(item.Id.ToString());
            newItem.SubItems.Add(item.TenBacSiKTV);
            newItem.SubItems.Add(item.SoDienThoai);
            newItem.SubItems.Add(item.TrangThai);

            materialListView1.Items.Add(newItem);
        }    

    }
}
