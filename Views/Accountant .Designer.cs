namespace Finalproject.Views
{
    partial class Accountant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accountant));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.InventoryCostCalculate = new System.Windows.Forms.TabPage();
            this.Reports = new System.Windows.Forms.TabPage();
            this.NetProfitCalulator = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Home);
            this.materialTabControl1.Controls.Add(this.InventoryCostCalculate);
            this.materialTabControl1.Controls.Add(this.Reports);
            this.materialTabControl1.Controls.Add(this.NetProfitCalulator);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1936, 954);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.ImageKey = "icons8-home-32.png";
            this.Home.Location = new System.Drawing.Point(4, 39);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1928, 911);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // InventoryCostCalculate
            // 
            this.InventoryCostCalculate.ImageKey = "icons8-cost-32.png";
            this.InventoryCostCalculate.Location = new System.Drawing.Point(4, 39);
            this.InventoryCostCalculate.Name = "InventoryCostCalculate";
            this.InventoryCostCalculate.Padding = new System.Windows.Forms.Padding(3);
            this.InventoryCostCalculate.Size = new System.Drawing.Size(1910, 864);
            this.InventoryCostCalculate.TabIndex = 1;
            this.InventoryCostCalculate.Text = "Inventory Cost Calculate";
            this.InventoryCostCalculate.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.Reports.ImageKey = "icons8-reports-32.png";
            this.Reports.Location = new System.Drawing.Point(4, 39);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(1910, 864);
            this.Reports.TabIndex = 2;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // NetProfitCalulator
            // 
            this.NetProfitCalulator.ImageKey = "icons8-profit-32.png";
            this.NetProfitCalulator.Location = new System.Drawing.Point(4, 39);
            this.NetProfitCalulator.Name = "NetProfitCalulator";
            this.NetProfitCalulator.Size = new System.Drawing.Size(1910, 864);
            this.NetProfitCalulator.TabIndex = 3;
            this.NetProfitCalulator.Text = "Net Profit Calulator";
            this.NetProfitCalulator.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-cost-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-reports-32.png");
            this.imageList1.Images.SetKeyName(2, "icons8-home-32.png");
            this.imageList1.Images.SetKeyName(3, "icons8-profit-32.png");
            // 
            // Accountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1021);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Accountant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage InventoryCostCalculate;
        private System.Windows.Forms.TabPage Reports;
        private System.Windows.Forms.TabPage NetProfitCalulator;
        private System.Windows.Forms.ImageList imageList1;
    }
}