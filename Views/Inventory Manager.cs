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
        public Inventory_Manager()
        {
            InitializeComponent();
            InitializeMaterialSkin();
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
    }
}
