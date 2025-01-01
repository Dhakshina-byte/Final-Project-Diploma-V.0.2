using Finalproject.Controllers;
using System.Windows.Forms;
using Finalproject.Models;

namespace Finalproject.Views
{
    public partial class Service
    {


        private EmployeeController _employeeController;


        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            //_employeeController = new EmployeeController();
            //var employee = new Employee
            //{
            //    Email = txtEmail.Text,
            //    Mobile = txtMobile.Text,
            //    City = txtCity.Text,
            //    Address = txtAddress.Text,
            //    Role_ID = 1,
            //    Department_ID = 1
            //};
            //if (_employeeController.RegisterEmployee(employee))
            //{
            //    MessageBox.Show("Employee registered successfully");
            //}
            //else
            //{
            //    MessageBox.Show("Employee registration failed");
            //}
        }
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.Employee = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SalesBudget = new System.Windows.Forms.TabPage();
            this.SalesRecords = new System.Windows.Forms.TabPage();
            this.Report = new System.Windows.Forms.TabPage();
            this.NetProfit = new System.Windows.Forms.TabPage();
            this.Pricing = new System.Windows.Forms.TabPage();
            this.StockLevels = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Home);
            this.materialTabControl1.Controls.Add(this.Employee);
            this.materialTabControl1.Controls.Add(this.SalesBudget);
            this.materialTabControl1.Controls.Add(this.SalesRecords);
            this.materialTabControl1.Controls.Add(this.Report);
            this.materialTabControl1.Controls.Add(this.NetProfit);
            this.materialTabControl1.Controls.Add(this.Pricing);
            this.materialTabControl1.Controls.Add(this.StockLevels);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1274, 653);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.ImageKey = "icons8-home-32.png";
            this.Home.Location = new System.Drawing.Point(4, 39);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1266, 610);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            this.Employee.ImageKey = "icons8-employee-32.png";
            this.Employee.Location = new System.Drawing.Point(4, 39);
            this.Employee.Name = "Employee";
            this.Employee.Padding = new System.Windows.Forms.Padding(3);
            this.Employee.Size = new System.Drawing.Size(1266, 610);
            this.Employee.TabIndex = 1;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-reports-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-budget-35.png");
            this.imageList1.Images.SetKeyName(2, "icons8-price-32.png");
            this.imageList1.Images.SetKeyName(3, "icons8-home-32.png");
            this.imageList1.Images.SetKeyName(4, "icons8-employee-32.png");
            this.imageList1.Images.SetKeyName(5, "icons8-profit-32.png");
            this.imageList1.Images.SetKeyName(6, "icons8-stocks-32.png");
            this.imageList1.Images.SetKeyName(7, "icons8-total-sales-32.png");
            this.imageList1.Images.SetKeyName(8, "icons8-records-32 (1).png");
            // 
            // SalesBudget
            // 
            this.SalesBudget.ImageKey = "icons8-budget-35.png";
            this.SalesBudget.Location = new System.Drawing.Point(4, 39);
            this.SalesBudget.Name = "SalesBudget";
            this.SalesBudget.Size = new System.Drawing.Size(1266, 610);
            this.SalesBudget.TabIndex = 2;
            this.SalesBudget.Text = " Sales Budget";
            this.SalesBudget.UseVisualStyleBackColor = true;
            // 
            // SalesRecords
            // 
            this.SalesRecords.ImageKey = "icons8-total-sales-32.png";
            this.SalesRecords.Location = new System.Drawing.Point(4, 39);
            this.SalesRecords.Name = "SalesRecords";
            this.SalesRecords.Size = new System.Drawing.Size(1266, 610);
            this.SalesRecords.TabIndex = 3;
            this.SalesRecords.Text = "Sales Records";
            this.SalesRecords.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            this.Report.ImageKey = "icons8-reports-32.png";
            this.Report.Location = new System.Drawing.Point(4, 39);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(1266, 610);
            this.Report.TabIndex = 4;
            this.Report.Text = " Reports";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // NetProfit
            // 
            this.NetProfit.ImageKey = "icons8-profit-32.png";
            this.NetProfit.Location = new System.Drawing.Point(4, 39);
            this.NetProfit.Name = "NetProfit";
            this.NetProfit.Size = new System.Drawing.Size(1266, 610);
            this.NetProfit.TabIndex = 5;
            this.NetProfit.Text = "Net Profit";
            this.NetProfit.UseVisualStyleBackColor = true;
            // 
            // Pricing
            // 
            this.Pricing.ImageKey = "icons8-price-32.png";
            this.Pricing.Location = new System.Drawing.Point(4, 39);
            this.Pricing.Name = "Pricing";
            this.Pricing.Size = new System.Drawing.Size(1266, 610);
            this.Pricing.TabIndex = 6;
            this.Pricing.Text = "Pricing";
            this.Pricing.UseVisualStyleBackColor = true;
            // 
            // StockLevels
            // 
            this.StockLevels.ImageKey = "icons8-stocks-32.png";
            this.StockLevels.Location = new System.Drawing.Point(4, 39);
            this.StockLevels.Name = "StockLevels";
            this.StockLevels.Size = new System.Drawing.Size(1266, 610);
            this.StockLevels.TabIndex = 7;
            this.StockLevels.Text = "Stock Levels";
            this.StockLevels.UseVisualStyleBackColor = true;
            // 
            // CEOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "CEOForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CEOForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage Home;
        private TabPage Employee;
        private ImageList imageList1;
        private TabPage SalesBudget;
        private TabPage SalesRecords;
        private TabPage Report;
        private TabPage NetProfit;
        private TabPage Pricing;
        private TabPage StockLevels;
    }
}