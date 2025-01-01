namespace Finalproject.Views
{
    partial class CEO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CEO));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.SalesBudget = new System.Windows.Forms.TabPage();
            this.Employees = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Records = new System.Windows.Forms.TabPage();
            this.NetProfit = new System.Windows.Forms.TabPage();
            this.Pricing = new System.Windows.Forms.TabPage();
            this.StockLevels = new System.Windows.Forms.TabPage();
            this.Report = new System.Windows.Forms.TabPage();
            this.Home = new System.Windows.Forms.TabPage();
            this.Sales = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Home);
            this.materialTabControl1.Controls.Add(this.Employees);
            this.materialTabControl1.Controls.Add(this.SalesBudget);
            this.materialTabControl1.Controls.Add(this.Records);
            this.materialTabControl1.Controls.Add(this.NetProfit);
            this.materialTabControl1.Controls.Add(this.Pricing);
            this.materialTabControl1.Controls.Add(this.StockLevels);
            this.materialTabControl1.Controls.Add(this.Report);
            this.materialTabControl1.Controls.Add(this.Sales);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1896, 606);
            this.materialTabControl1.TabIndex = 0;
            // 
            // SalesBudget
            // 
            this.SalesBudget.ImageKey = "icons8-budget-35.png";
            this.SalesBudget.Location = new System.Drawing.Point(4, 39);
            this.SalesBudget.Name = "SalesBudget";
            this.SalesBudget.Padding = new System.Windows.Forms.Padding(3);
            this.SalesBudget.Size = new System.Drawing.Size(1888, 563);
            this.SalesBudget.TabIndex = 0;
            this.SalesBudget.Text = "Sales Budget";
            this.SalesBudget.UseVisualStyleBackColor = true;
            // 
            // Employees
            // 
            this.Employees.ImageKey = "icons8-employee-32.png";
            this.Employees.Location = new System.Drawing.Point(4, 39);
            this.Employees.Name = "Employees";
            this.Employees.Padding = new System.Windows.Forms.Padding(3);
            this.Employees.Size = new System.Drawing.Size(1888, 563);
            this.Employees.TabIndex = 1;
            this.Employees.Text = "Employees";
            this.Employees.UseVisualStyleBackColor = true;
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
            // Records
            // 
            this.Records.ImageKey = "icons8-records-32 (1).png";
            this.Records.Location = new System.Drawing.Point(4, 39);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(1888, 563);
            this.Records.TabIndex = 2;
            this.Records.Text = "Records";
            this.Records.UseVisualStyleBackColor = true;
            // 
            // NetProfit
            // 
            this.NetProfit.ImageKey = "icons8-profit-32.png";
            this.NetProfit.Location = new System.Drawing.Point(4, 39);
            this.NetProfit.Name = "NetProfit";
            this.NetProfit.Size = new System.Drawing.Size(1888, 563);
            this.NetProfit.TabIndex = 3;
            this.NetProfit.Text = "Net Profit";
            this.NetProfit.UseVisualStyleBackColor = true;
            // 
            // Pricing
            // 
            this.Pricing.ImageKey = "icons8-price-32.png";
            this.Pricing.Location = new System.Drawing.Point(4, 39);
            this.Pricing.Name = "Pricing";
            this.Pricing.Size = new System.Drawing.Size(1888, 563);
            this.Pricing.TabIndex = 4;
            this.Pricing.Text = "Pricing";
            this.Pricing.UseVisualStyleBackColor = true;
            // 
            // StockLevels
            // 
            this.StockLevels.ImageKey = "icons8-stocks-32.png";
            this.StockLevels.Location = new System.Drawing.Point(4, 39);
            this.StockLevels.Name = "StockLevels";
            this.StockLevels.Size = new System.Drawing.Size(1888, 563);
            this.StockLevels.TabIndex = 5;
            this.StockLevels.Text = "Stock Levels";
            this.StockLevels.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            this.Report.ImageKey = "icons8-reports-32.png";
            this.Report.Location = new System.Drawing.Point(4, 39);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(1888, 563);
            this.Report.TabIndex = 6;
            this.Report.Text = " Report";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.Home.ImageKey = "icons8-home-32.png";
            this.Home.Location = new System.Drawing.Point(4, 39);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1888, 563);
            this.Home.TabIndex = 7;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Sales
            // 
            this.Sales.ImageKey = "icons8-total-sales-32.png";
            this.Sales.Location = new System.Drawing.Point(4, 39);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(1888, 563);
            this.Sales.TabIndex = 8;
            this.Sales.Text = "Sales";
            this.Sales.UseVisualStyleBackColor = true;
            // 
            // CEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 673);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MaximizeBox = false;
            this.Name = "CEO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CEO_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage SalesBudget;
        private System.Windows.Forms.TabPage Employees;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Records;
        private System.Windows.Forms.TabPage NetProfit;
        private System.Windows.Forms.TabPage Pricing;
        private System.Windows.Forms.TabPage StockLevels;
        private System.Windows.Forms.TabPage Report;
        private System.Windows.Forms.TabPage Sales;
    }
}