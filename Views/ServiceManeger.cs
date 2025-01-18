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
        private readonly InventoryController inventoryController; 
        private readonly BookingServiceController bookingRepository;
        private readonly washControllers washControllers;
        private readonly MaintainController maintainControllers;
        private readonly SetupController setupControllers;
        private readonly RepairController repairControllers;
        private readonly ServiceProgressController serviceProgressController;
        private  readonly VehicleInspectionController vehicleInspectionController;
        private ServiceBooking serviceBooking;
        private VehicleInspection vehicleInspection;
        private ServiceProgress serviceProgress;
        private Maintain maintain;
        private Tools tools;
        private Request request;
        private Wash wash;
        private Setup setup;
        private Repair repair;
        public ServiceManeger()
        
        {
            InitializeComponent();
            vehicleController = new VehicleController();
            serviceBookingService = new ServiceBookingService();
            serviceBooking = new ServiceBooking();
            bookingRepository = new BookingServiceController();
            setup = new Setup();
            repair = new Repair();
            vehicleInspectionController = new VehicleInspectionController();
            washControllers = new washControllers();
            maintainControllers = new MaintainController();
            serviceProgressController = new ServiceProgressController();
            setupControllers = new SetupController();
            repairControllers = new RepairController();
            wash = new Wash();
            serviceProgress = new ServiceProgress();
            vehicleInspection = new VehicleInspection();
            maintain = new Maintain();
            request = new Request();
            tools = new Tools();
            inventoryController = new InventoryController();

            InitializeMaterialSkin();
        }

        private void showprogress()
        {
            var progress = serviceProgressController.GetAllServiceProgress();
            ServiceProgressDataGridView.DataSource = progress;
            SetupDataGridView6();
        }

        private void SetupDataGridView6()
        {
            ServiceProgressDataGridView.AllowUserToAddRows = false;
            addbuttons6();
        }

        private void addbuttons6()
        {
            var editButton = new DataGridViewButtonColumn
            {
                Name = "selecButton",
                HeaderText = "select",
                Width = 100,
                Text = "select",
                UseColumnTextForButtonValue = true
            };
            ServiceProgressDataGridView.Columns.Insert(8, editButton);
        }

        private void showinspection()
        {
            var inspection = vehicleInspectionController.GetVehicleInspection();
            VehicleInspectionDataGridView1.DataSource = inspection;
            SetupDataGridView();
        }

        private void showmaintain()
        {
            var maintain = maintainControllers.GetMaintain();
            MaintenanceDataGridView1.DataSource = maintain;
            SetupDataGridView1();


        }

        private void showtools()
        {
            var tools = inventoryController.showtools();
            bunifuDataGridView3.DataSource = tools;
           
        }

        private void showwash()
        {
            var wash = washControllers.ShowWash();
            WashDataGridView1.DataSource = wash;
            SetupDataGridView5();
        }
        private void SetupDataGridView5()
        {
            WashDataGridView1.AllowUserToAddRows = false;
            addbuttons3();
        }

        private void addbuttons3()
        {
            var editButton = new DataGridViewButtonColumn
            {
                Name = "selecButton",
                HeaderText = "select",
                Width = 100,
                Text = "select",
                UseColumnTextForButtonValue = true
            };
            WashDataGridView1.Columns.Insert(5, editButton);
            // Add Delete button column
            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "Delete",
                Width = 100,
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            WashDataGridView1.Columns.Insert(6, deleteButton);
        }

        private void showswtup()
        {
            var vhsetup = setupControllers.GetSetups();
            SetupDataGridView3.DataSource = vhsetup;
            SetupDataGridView2();
        }

        private void SetupDataGridView2()
        {
            SetupDataGridView3.AllowUserToAddRows = false;
            addbuttons2();
        }

        private void addbuttons2()
        {
            var editButton = new DataGridViewButtonColumn
            {
                Name = "selecButton",
                HeaderText = "select",
                Width = 100,
                Text = "select",
                UseColumnTextForButtonValue = true
            };
            SetupDataGridView3.Columns.Insert(6, editButton);
            // Add Delete button column
            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "Delete",
                Width = 100,
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            SetupDataGridView3.Columns.Insert(7, deleteButton);
        }
        private void showspareparts()
        {
            var spareparts = inventoryController.getInventory();
            bunifuDataGridView4.DataSource = spareparts;
            
        }
        private void SetupDataGridView7()
        {
            bunifuDataGridView4.AllowUserToAddRows = false;
            addbuttons8();
        }
        private void addbuttons8()
        {
            var editButton = new DataGridViewButtonColumn
            {
                Name = "selecButton",
                HeaderText = "select",
                Width = 100,
                Text = "select",
                UseColumnTextForButtonValue = true
            };
            bunifuDataGridView4.Columns.Insert(6, editButton);
        }

        private void SetupDataGridView1()
        {
            VehicleInspectionDataGridView1.AllowUserToAddRows = false;
            addbuttons();
        }

        private void SetupDataGridView()
        {
            MaintenanceDataGridView1.AllowUserToAddRows = false;
            addbuttons1();
        }
        private void addbuttons1()
        {
            var editButton = new DataGridViewButtonColumn
            {
                Name = "selecButton",
                HeaderText = "select",
                Width = 100,
                Text = "select",
                UseColumnTextForButtonValue = true
            };

            if (MaintenanceDataGridView1.Columns.Count >= 6)
            {
                MaintenanceDataGridView1.Columns.Insert(6, editButton);
            }
            else
            {
                MaintenanceDataGridView1.Columns.Add(editButton);
            }

            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "Delete",
                Width = 100,
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };

            if (MaintenanceDataGridView1.Columns.Count >= 7)
            {
                MaintenanceDataGridView1.Columns.Insert(7, deleteButton);
            }
            else
            {
                MaintenanceDataGridView1.Columns.Add(deleteButton);
            }
        }
        private void addbuttons()
        {
            

            var editButton = new DataGridViewButtonColumn
            {
                Name = "selecButton",
                HeaderText = "select",
                Width = 100,
                Text = "select",
                UseColumnTextForButtonValue = true
            };
            VehicleInspectionDataGridView1.Columns.Insert(6, editButton);
            // Add Delete button column
            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "Delete",
                Width = 100,
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            VehicleInspectionDataGridView1.Columns.Insert(7, deleteButton);
        }

        private void showRepair() 
        {
            var srepair = repairControllers.showRepair();
             RepairDataGridView1.DataSource = srepair;

            SetupDataGridView4();
        }

        private void SetupDataGridView4() 
        {
            RepairDataGridView1.AllowUserToAddRows = false;
            addbutton2();
        }
         
        private void addbutton2() 
        {
            var editButton = new DataGridViewButtonColumn
            {
                Name = "selecButton",
                HeaderText = "select",
                Width = 100,
                Text = "select",
                UseColumnTextForButtonValue = true
            };
            RepairDataGridView1.Columns.Insert(6, editButton);
            // Add Delete button column
            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "Delete",
                Width = 100,
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            RepairDataGridView1.Columns.Insert(7, deleteButton);
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
         
        private void showspareparts1()
        {
            var spareparts = inventoryController.getTools();
            SparePartsDataGridView.DataSource = spareparts;
            addbuttons5();
        }
        private void addbuttons5()
        {
            var editButton = new DataGridViewButtonColumn
            {
                Name = "selecButton",
                HeaderText = "select",
                Width = 100,
                Text = "select",
                UseColumnTextForButtonValue = true
            };
            SparePartsDataGridView.Columns.Insert(6, editButton);
        }

        private void ServiceManeger_Load(object sender, EventArgs e)
        {
            Hidelable();
            showbooking();
            showinspection();
            showmaintain();
            showswtup();
            showRepair();
            showwash();
            showprogress();
            showspareparts1();
            showtools();
            showspareparts();
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

            serviceProgress.Vehicle_ID = Convert.ToInt32(VehicleID.Text);
            serviceProgress.Booking_Date = Convert.ToDateTime(bunifuDatePicker1.Value);
            serviceProgress.Inspection = Inspectioncheck.Checked;
            serviceProgress.Maintain = maintanceCheckbox.Checked;
            serviceProgress.Repair = RepairsCheckbox.Checked;
            serviceProgress.Wash = washCheckbox.Checked;
            serviceProgress.Status = "pending";
            serviceProgress.Setup = InstallationCheckbox.Checked;

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

            serviceProgressController.AddServiceProgress(serviceProgress);
            serviceBookingService.InsertServiceBooking(serviceBooking);
            MessageBox.Show("Service Booking Added Successfully");
            showbooking();
        }

        private void materialMultiLineTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void VehicleInspectionDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (VehicleInspectionDataGridView1.Columns[e.ColumnIndex].Name == "selecButton") // Check if Edit button column is clicked
            {
                DataGridViewRow rows1 = VehicleInspectionDataGridView1.Rows[e.RowIndex]; // Get the clicked row
                if (MessageBox.Show(string.Format("Are you sure you want to Edit this row?", rows1.Cells["Inspection_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    InspectionID.Text = Convert.ToString(rows1.Cells["Inspection_ID"].Value);
                    Console.WriteLine(InspectionID.Text);
                    Vehicl_IDLabel1.Text = Convert.ToString(rows1.Cells["Vehicle_ID"].Value);
                    Inspection_Date.Text = Convert.ToString(rows1.Cells["Inspection_Date"].Value);
                }
            }
            if (VehicleInspectionDataGridView1.Columns[e.ColumnIndex].Name == "DeleteButton") // Check if Delete button column is clicked
            {
                DataGridViewRow rows1 = VehicleInspectionDataGridView1.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Are you sure you want to delete this row?", rows1.Cells["Inspection_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    vehicleInspectionController.RemoveVehicleInspection(Convert.ToInt32(rows1.Cells["Inspection_ID"].Value), Convert.ToInt32(rows1.Cells["Vehicle_ID"].Value));
                    var inspection = vehicleInspectionController.GetVehicleInspection();
                    VehicleInspectionDataGridView1.DataSource = inspection;
                    SetupDataGridView();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            vehicleInspection.Inspection_ID = Convert.ToInt32(InspectionID.Text);
            vehicleInspection.Vehicle_ID = Convert.ToInt32(Vehicl_IDLabel1.Text);
            vehicleInspection.Inspector_DESC = Inspector_DESCMultiLineTextBox.Text;
            vehicleInspection.Status = materialComboBox1.Text;

            vehicleInspectionController.UpdateVehicleInspection(vehicleInspection);

            var inspection = vehicleInspectionController.GetVehicleInspection();
            VehicleInspectionDataGridView1.DataSource = inspection;

            // Ensure the button columns are still present
            if (VehicleInspectionDataGridView1.Columns["DeleteButton"] == null ||
           VehicleInspectionDataGridView1.Columns["EditButton"] == null)
            {
                SetupDataGridView();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maintain.Maintain_ID = Convert.ToInt32(Maintain_IDlbl.Text);
            maintain.Vehicle_ID = Convert.ToInt32(Vehicle_IDlbl1.Text);
            maintain.Description = MaintenanceMultiLineTextBox.Text;
            maintain.Status = MaintenanceComboBox.Text;

            maintainControllers.UpdateMaintain(maintain);

            var Vmaintain = maintainControllers.GetMaintain();
            MaintenanceDataGridView1.DataSource = Vmaintain;
    

            // Ensure the button columns are still present
            if (MaintenanceDataGridView1.Columns["DeleteButton"] == null ||
           MaintenanceDataGridView1.Columns["EditButton"] == null)
            {
                SetupDataGridView();

            }
        }

        private void MaintenanceDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MaintenanceDataGridView1.Columns[e.ColumnIndex].Name == "selecButton") // Check if Edit button column is clicked
            {
                DataGridViewRow rows1 = MaintenanceDataGridView1.Rows[e.RowIndex]; // Get the clicked row
                if (MessageBox.Show(string.Format("Are you sure you want to Edit this row?", rows1.Cells["Maintain_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Maintain_IDlbl.Text = Convert.ToString(rows1.Cells["Maintain_ID"].Value);
                    //Console.WriteLine(InspectionID.Text);
                    Vehicle_IDlbl1.Text = Convert.ToString(rows1.Cells["Vehicle_ID"].Value);
                    Maintain_Date.Text = Convert.ToString(rows1.Cells["Maintain_Date"].Value);
                }
            }
            if (MaintenanceDataGridView1.Columns[e.ColumnIndex].Name == "DeleteButton") // Check if Delete button column is clicked
            {
                DataGridViewRow rows1 = MaintenanceDataGridView1.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Are you sure you want to delete this row?", rows1.Cells["Maintain_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    maintainControllers.RemoveMaintain(Convert.ToInt32(rows1.Cells["Maintain_ID"].Value));
                    //, Convert.ToInt32(rows1.Cells["Vehicle_ID"].Value)

                    var Vmaintain = maintainControllers.GetMaintain();
                    MaintenanceDataGridView1.DataSource = Vmaintain;

                    SetupDataGridView();
                }
            }
        }

        private void InstallationSetup_Click(object sender, EventArgs e)
        {

        }

        private void SetupDataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SetupDataGridView3.Columns[e.ColumnIndex].Name == "selecButton")
            {
                DataGridViewRow rows1 = SetupDataGridView3.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Are you sure you want to Edit this row?", rows1.Cells["Setup_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Setup_IDlbl.Text = Convert.ToString(rows1.Cells["Setup_ID"].Value);
                    //Console.WriteLine(InspectionID.Text);
                    Vehicle_IDlbl4.Text = Convert.ToString(rows1.Cells["Vehicle_ID"].Value);
                    Setup_Datelbl.Text = Convert.ToString(rows1.Cells["Setup_Date"].Value);
                }

            }
            if (SetupDataGridView3.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                DataGridViewRow rows1 = SetupDataGridView3.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Are you sure you want to delete this row?", rows1.Cells["Setup_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    setupControllers.RemoveSetup(Convert.ToInt32(rows1.Cells["Setup_ID"].Value));
                    var vhsetup = setupControllers.GetSetups();
                    SetupDataGridView3.DataSource = vhsetup;
                    SetupDataGridView2();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            setup.Setup_ID = Convert.ToInt32(Setup_IDlbl.Text);
            setup.Vehicle_ID = Convert.ToInt32(Vehicle_IDlbl4.Text);
            setup.Setup_Details = Setup_DetailsMultiline.Text;
            setup.Status = StatusComboBox2.Text;

            setupControllers.UpdateSetup(setup);
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (RepairDataGridView1.Columns[e.ColumnIndex].Name == "selecButton")
            {
                DataGridViewRow rows1 = RepairDataGridView1.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Are you sure you want to Edit this row?", rows1.Cells["Repair_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    RepairLabel3.Text = Convert.ToString(rows1.Cells["Repair_ID"].Value);
                    //Console.WriteLine(InspectionID.Text);
                    RepairvehicleLabel2.Text = Convert.ToString(rows1.Cells["Vehicle_ID"].Value);
                    materialLabel1.Text = Convert.ToString(rows1.Cells["Repair_Date"].Value);
                }

            }
            if (RepairDataGridView1.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                DataGridViewRow rows1 = RepairDataGridView1.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Are you sure you want to delete this row?", rows1.Cells["Repair_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    repairControllers.RemoveRepair(Convert.ToInt32(rows1.Cells["Repair_ID"].Value));
                    var vhsetup = repairControllers.showRepair();
                    RepairDataGridView1.DataSource = vhsetup;
                    SetupDataGridView2();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            repair.Repair_ID = Convert.ToInt32(RepairLabel3.Text);
            repair.Vehicle_ID = Convert.ToInt32(RepairvehicleLabel2.Text);
            repair.Repair_Description = RepairMultiLineTextBox21.Text;
            repair.Status = RepairComboBox2.Text;
            repairControllers.UpdateRepair(repair);
        }

        private void button4_Click(object sender, EventArgs e)
        {
              wash.Wash_ID = Convert.ToInt32(materialLabel4.Text);
            wash.Vehicle_ID = Convert.ToInt32(materialLabel3.Text);
            wash.Status = materialComboBox2.Text;
            washControllers.UpdateWash(wash);

        }

        private void WashDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (WashDataGridView1.Columns[e.ColumnIndex].Name == "selecButton")
            {
                DataGridViewRow rows1 = WashDataGridView1.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Are you sure you want to Edit this row?", rows1.Cells["Wash_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    materialLabel4.Text = Convert.ToString(rows1.Cells["Wash_ID"].Value);
                    //Console.WriteLine(InspectionID.Text);
                    materialLabel3.Text = Convert.ToString(rows1.Cells["Vehicle_ID"].Value);
                    materialLabel2.Text = Convert.ToString(rows1.Cells["Repair_Date"].Value);
                }

            }
            if (WashDataGridView1.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                DataGridViewRow rows1 = WashDataGridView1.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Are you sure you want to delete this row?", rows1.Cells["Wash_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    washControllers.RemoveWash(Convert.ToInt32(rows1.Cells["Wash_ID"].Value));
                    var vhsetup = washControllers.ShowWash();
                    WashDataGridView1.DataSource = vhsetup;
                    SetupDataGridView5();
                }
            }
        }

        private void Vehiclesearchbox_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox21_TextChanged(object sender, EventArgs e)
        {
            if (materialTextBox21.TextLength >= 1)
            {
                string search = materialTextBox21.Text;
                var searchResult = vehicleController.autosearchvehicle(search);

                if (searchResult != null && searchResult.Rows.Count > 0)
                {

                    bunifuDataGridView2.DataSource = searchResult;
                    bunifuDataGridView2.Height = searchResult.Rows.Count * 35;

                }
                else
                {
                    bunifuDataGridView2.Height = searchResult.Rows.Count * 0;
                }
            }
            else if (materialTextBox21.TextLength == 0)
            {
                materialTextBox21.Height = 0;
            }
        }

        private void bunifuDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = bunifuDataGridView2.Rows[e.RowIndex];
            label23.Text = row.Cells[0].Value.ToString();
            
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(label23.Text);
            var booking = serviceProgressController.serchbyID(id);
            ServiceProgressDataGridView.DataSource = booking;
        }

        private void ServiceProgressDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ServiceProgressDataGridView.Columns[e.ColumnIndex].Name == "selecButton")
            {
                DataGridViewRow rows1 = ServiceProgressDataGridView.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Are you sure you want to Edit this row?", rows1.Cells["Progress_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    label27.Text = Convert.ToString(rows1.Cells["Progress_ID"].Value);
                    //Console.WriteLine(InspectionID.Text);
                    label23.Text = Convert.ToString(rows1.Cells["Vehicle_ID"].Value);
                }

            }
        }

        

        private void materialButton3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(label23.Text);
            serviceProgress.Progress_ID = Convert.ToInt32(label27.Text);
            serviceProgress.Vehicle_ID = Convert.ToInt32(label23.Text);
            serviceProgress.Status = materialComboBox3.Text;
            serviceProgressController.UpdateServiceProgress(serviceProgress);
            bookingRepository.RemoveServiceBooking(id);
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            request.Request_type = "Spare Parts";
            request.Request_Qty = int.Parse(materialTextBox1.Text); 
            request.Request_Desc = materialLabel6.Text;
            tools.Tool_name = materialLabel5.Text;
            tools.Tool_desc = materialLabel6.Text;
            tools.Tool_status = "Pending";
            tools.User_ID = "1";
            inventoryController.AddRequest(request, tools);
        }

        private void SparePartsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SparePartsDataGridView.Columns[e.ColumnIndex].Name == "selecButton")
            {
                DataGridViewRow rows1 = SparePartsDataGridView.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Are you sure you want to Edit this row?", rows1.Cells["Tool_ID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    materialLabel5.Text = Convert.ToString(rows1.Cells["Tool_Name"].Value);
                    materialLabel6.Text = Convert.ToString(rows1.Cells["Tool_Description"].Value);
                }
            }
        }

    }

}
