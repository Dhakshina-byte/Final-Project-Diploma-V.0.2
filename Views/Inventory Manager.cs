using Finalproject.Controllers;
using Finalproject.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalproject.Views
{
    public partial class Inventory_Manager : MaterialForm
    {

        private readonly InventoryController inventoryController;
        private Inventory inventory;

        public Inventory_Manager()
        {
            InitializeComponent();
            InitializeMaterialSkin();
            inventoryController = new InventoryController();
            inventory = new Inventory();
        }

        private void InitializeMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
            Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200,
            TextShade.WHITE);
        }
        private void Inventory_Manager_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            inventory.Inventory_item_name = ItemNametxtbox.Text;
            inventory.Category = "Spare Parts";
            inventory.Qty = int.Parse(Quantitytxtbox.Text);
            inventory.Per_price = decimal.Parse(PricePerItemtxtbox.Text);
            inventory.Serial_number = SerialNumbertxtbox.Text;

            inventoryController.AddInventory(inventory);

            ItemNametxtbox.Text = "";
            Quantitytxtbox.Text = "";
            PricePerItemtxtbox.Text = "";
            SerialNumbertxtbox.Text = "";

            DataTable dt = inventoryController.getInventory();

            sparePartDataGridView.DataSource = dt;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            inventory.Inventory_item_name = ToolNametxtbox.Text;
            inventory.Category = "Tools";
            inventory.Qty = int.Parse(materialTextBox1.Text);
            inventory.Per_price = decimal.Parse(Descriptiontxtbox.Text);


            inventoryController.AddInventory(inventory);

            ItemNametxtbox.Text = "";
            Quantitytxtbox.Text = "";
            PricePerItemtxtbox.Text = "";
            SerialNumbertxtbox.Text = "";

            DataTable dt = inventoryController.getTools();

            sparePartDataGridView.DataSource = dt;
        }
    }
}
