using Bunifu.UI.WinForms;
using Finalproject.Controllers;
using Finalproject.Models;
using Finalproject.Services;
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
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace Finalproject.Views
{
    public partial class ServiceManeger : MaterialForm
    {
        private readonly VehicleController vehicleController;
        private readonly ServiceBookingService serviceBookingService;
        private readonly washControllers washControllers;
        private readonly MaintainController maintainControllers;
        private readonly SetupController setupControllers;
        private readonly RepairController repairControllers;
        private  readonly VehicleInspectionController vehicleInspectionController;
        private ServiceBooking serviceBooking;
        private VehicleInspection vehicleInspection;
        private Maintain maintain;
        private Setup setup;
        private Repair repair;
        public ServiceManeger()
        
        {
            InitializeComponent();
            vehicleController = new VehicleController();
            serviceBookingService = new ServiceBookingService();
            serviceBooking = new ServiceBooking();
            setup = new Setup();
            repair = new Repair();
            vehicleInspectionController = new VehicleInspectionController();
            washControllers = new washControllers();
            maintainControllers = new MaintainController();
            setupControllers = new SetupController();
            repairControllers = new RepairController();
            vehicleInspection = new VehicleInspection();
            maintain = new Maintain();


            InitializeMaterialSkin();
        }

       private void showbooking()
        {
            var booking = serviceBookingService.GetServiceBooking();
            ServiceBookingGridview.DataSource = booking;
        }
        private void Hidelable() 
        {
            VehicleID.Visible = false;
        }
        private void showlable()
        {
            VehicleID.Visible = true;
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

        private void ServiceManeger_Load(object sender, EventArgs e)
        {
            Hidelable();
            showbooking();
        }


        private void Vehiclesearchbox_TextChanged(object sender, EventArgs e)
        {
            if(Vehiclesearchbox.TextLength >= 1)
            {
                string search = Vehiclesearchbox.Text;
                var searchResult = vehicleController.autosearchvehicle(search);

                if (searchResult !=null && searchResult.Rows.Count > 0) 
                {
                    
                    Vehiclesearchbox1.DataSource = searchResult;
                    Vehiclesearchbox1.Height = searchResult.Rows.Count * 35;

                }
                else
                {
                    Vehiclesearchbox1.Height = searchResult.Rows.Count * 0;
                }
            }
            else if (Vehiclesearchbox.TextLength == 0)
            {
                Vehiclesearchbox1.Height = 0;
            }
        }

        private void Vehiclesearchbox1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Vehiclesearchbox1.Rows[e.RowIndex];
            VehicleID.Text = row.Cells[0].Value.ToString();
            showlable();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            serviceBooking.Vehicle_ID = Convert.ToInt32(VehicleID.Text);
            serviceBooking.Booking_Date = Convert.ToDateTime(bunifuDatePicker1.Value);
            serviceBooking.Inspection = Inspectioncheck.Checked;
            serviceBooking.Maintain = maintanceCheckbox.Checked;
            serviceBooking.Setup = InstallationCheckbox.Checked;
            serviceBooking.Repair = RepairsCheckbox.Checked;
            serviceBooking.wash = washCheckbox.Checked;
            serviceBooking.Status = Statuscombo.Text;

            if (Inspectioncheck.Checked)
            {
                vehicleInspection.Vehicle_ID = Convert.ToInt32(VehicleID.Text);
                vehicleInspection.Inspection_Date = Convert.ToDateTime(bunifuDatePicker1.Value);
                vehicleInspection.Inspector_DESC = "Inspection";
                vehicleInspection.Status = "Pending";
                Console.WriteLine(vehicleInspection.Vehicle_ID);
                vehicleInspectionController.AddVehicleInspection(vehicleInspection);
            }
            if (maintanceCheckbox.Checked)
            {
                maintain.Vehicle_ID = Convert.ToInt32(VehicleID.Text);
                maintain.Maintain_Date = Convert.ToDateTime(bunifuDatePicker1.Value);
                maintain.Description = "Maintain";
                maintain.Status = "Pending";
                maintainControllers.AddMaintain(maintain);
            }
            if (InstallationCheckbox.Checked)
            {
                setup.Vehicle_ID = Convert.ToInt32(VehicleID.Text);
                setup.Setup_Date = Convert.ToDateTime(bunifuDatePicker1.Value);
                setup.Setup_Details = "Setup";
                setup.Status = "Pending";
                setupControllers.AddSetup(setup);
            }
            if (RepairsCheckbox.Checked)
            {
                repair.Vehicle_ID = Convert.ToInt32(VehicleID.Text);
                repair.Repair_Date = Convert.ToDateTime(bunifuDatePicker1.Value);
                repair.Repair_Description = "Repair";
                repair.Status = "Pending";
                repairControllers.AddRepair(repair);
            }
            if (washCheckbox.Checked)
            {
                Wash wash = new Wash
                {
                    Vehicle_ID = Convert.ToInt32(VehicleID.Text),
                    Repair_Date = Convert.ToDateTime(bunifuDatePicker1.Value),
                    Status = "Pending"
                };
                washControllers.AddWash(wash);
            }

            serviceBookingService.InsertServiceBooking(serviceBooking);
            MessageBox.Show("Service Booking Added Successfully");
            showbooking();
        }
    }

}
