using Finalproject.Models;
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
    public partial class VehicleDisplay : UserControl
    {
        private Vehicles vehicle;
        private CEO ceo;
        private readonly Controllers.VehicleController vehicleController;
        public VehicleDisplay()
        {
            InitializeComponent();
            vehicle = new Vehicles();
            ceo = new CEO();
        }
        
        private Image icon;
        private string vehicleName;
        private string vehicleType;

        public Image Icon
        {
            get { return icon; }
            set { icon = value; Vehiclepic.Image = value; }
        }
        public string VehicleName
        {
            get { return vehicleName; }
            set { vehicleName = value; Titlelbl.Text = value; }
        }

        public string VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; Sub.Text = value; }
        }
        public string Chassis_no 
        {
            get { return vehicle.Chassis_no; }
            set { vehicle.Chassis_no = value; label1.Text = value; }
        }


        private void VehicleDisplay_Load(object sender, EventArgs e)
        {

        }

        private void VehicleDisplay_Click(object sender, EventArgs e)
        {


        }

    }

}
