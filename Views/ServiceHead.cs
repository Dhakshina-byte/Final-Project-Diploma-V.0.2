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
using System.Windows.Forms;

namespace Finalproject.Views
{
    public partial class ServiceHead : MaterialForm
    {
        private readonly ServiceBookingService serviceBookingService = new ServiceBookingService();
        private ComplaintDataAccess dataAccess = new ComplaintDataAccess();
        public ServiceHead()
        {
            InitializeComponent();
            InitializeMaterialSkin();
            showbooking();
            showcomplaints();

        }
        private void showcomplaints()
        {
            var complaints = dataAccess.showcComplaints();
            bunifuDataGridView2.DataSource = complaints;
        }
        private void showbooking()
        {
            var booking = serviceBookingService.GetServiceBooking();
            bunifuDataGridView1.DataSource = booking;
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
       
        private void Service_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            CustomerComplaint complaint = new CustomerComplaint
            {
                CustomerName = customerNameTextBox.Text,
                ComplaintDate = DateTime.Now,
                ComplaintText = complaintTextBox.Text,
                Status = "Pending"
            };

            dataAccess.AddComplaint(complaint);
            MessageBox.Show("Complaint submitted successfully!");
        }
    }
}
