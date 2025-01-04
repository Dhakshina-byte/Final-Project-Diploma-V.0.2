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
    public partial class SalesDirector : MaterialForm
    {
        private readonly SalesController controller;
        private SalesTarget salesTarget;
        public SalesDirector()
        {
            InitializeComponent();
            controller = new SalesController();
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


        private void SalesDirector_Load(object sender, EventArgs e)
        {

        }

        private void Employees_Click(object sender, EventArgs e)
        {
           
        }

        private void Calculatebtn_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(ActualSalestxtbox.Text, out decimal actualSales) &&
               decimal.TryParse(SalesTargettxtbox.Text, out decimal salesTarget))
            {
                try
                {
                    decimal targetPercentage = controller.CalculateTargetPercentage(actualSales, salesTarget);
                    lblResult.Text = $"Target Percentage: {targetPercentage:F2}%";
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for Actual Sales and Sales Target.");
            }
        }

        private void Savebin_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(ActualSalestxtbox.Text, out decimal actualSales) &&
                decimal.TryParse(SalesTargettxtbox.Text, out decimal salesTarget))
            {
                try
                {
                    decimal targetPercentage = controller.CalculateTargetPercentage(actualSales, salesTarget);
                    SalesTarget salesTargetModel = new SalesTarget
                    {
                        ActualSales = actualSales,
                        salesTarget = salesTarget,
                        TargetPercentage = targetPercentage
                    };

                    controller.SaveSalesTarget(salesTargetModel);
                    MessageBox.Show("Data saved successfully.");
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for Actual Sales and Sales Target.");
            }
        }
    }
}
