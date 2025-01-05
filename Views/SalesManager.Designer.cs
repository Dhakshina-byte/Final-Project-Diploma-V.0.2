namespace Finalproject.Views
{
    partial class SalesManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesManager));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Customer = new System.Windows.Forms.TabPage();
            this.VehicleOwners = new System.Windows.Forms.TabPage();
            this.TestDrive = new System.Windows.Forms.TabPage();
            this.Vehicle = new System.Windows.Forms.TabPage();
            this.SalesContract = new System.Windows.Forms.TabPage();
            this.VehicleCustomization = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Customer);
            this.materialTabControl1.Controls.Add(this.VehicleOwners);
            this.materialTabControl1.Controls.Add(this.TestDrive);
            this.materialTabControl1.Controls.Add(this.Vehicle);
            this.materialTabControl1.Controls.Add(this.SalesContract);
            this.materialTabControl1.Controls.Add(this.VehicleCustomization);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1918, 907);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Customer
            // 
            this.Customer.ImageKey = "icons8-customer-32.png";
            this.Customer.Location = new System.Drawing.Point(4, 39);
            this.Customer.Name = "Customer";
            this.Customer.Padding = new System.Windows.Forms.Padding(3);
            this.Customer.Size = new System.Drawing.Size(1910, 864);
            this.Customer.TabIndex = 0;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = true;
            // 
            // VehicleOwners
            // 
            this.VehicleOwners.ImageKey = "icons8-landlord-32.png";
            this.VehicleOwners.Location = new System.Drawing.Point(4, 39);
            this.VehicleOwners.Name = "VehicleOwners";
            this.VehicleOwners.Padding = new System.Windows.Forms.Padding(3);
            this.VehicleOwners.Size = new System.Drawing.Size(1910, 864);
            this.VehicleOwners.TabIndex = 1;
            this.VehicleOwners.Text = "VehicleOwners";
            this.VehicleOwners.UseVisualStyleBackColor = true;
            // 
            // TestDrive
            // 
            this.TestDrive.ImageKey = "icons8-driver-32.png";
            this.TestDrive.Location = new System.Drawing.Point(4, 39);
            this.TestDrive.Name = "TestDrive";
            this.TestDrive.Size = new System.Drawing.Size(1910, 864);
            this.TestDrive.TabIndex = 2;
            this.TestDrive.Text = "Test Drive";
            this.TestDrive.UseVisualStyleBackColor = true;
            // 
            // Vehicle
            // 
            this.Vehicle.ImageKey = "icons8-vehicle-insurance-32.png";
            this.Vehicle.Location = new System.Drawing.Point(4, 39);
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Size = new System.Drawing.Size(1910, 864);
            this.Vehicle.TabIndex = 3;
            this.Vehicle.Text = "Vehicle";
            this.Vehicle.UseVisualStyleBackColor = true;
            // 
            // SalesContract
            // 
            this.SalesContract.ImageKey = "icons8-contract-32.png";
            this.SalesContract.Location = new System.Drawing.Point(4, 39);
            this.SalesContract.Name = "SalesContract";
            this.SalesContract.Size = new System.Drawing.Size(1910, 864);
            this.SalesContract.TabIndex = 4;
            this.SalesContract.Text = "SalesContract";
            this.SalesContract.UseVisualStyleBackColor = true;
            // 
            // VehicleCustomization
            // 
            this.VehicleCustomization.ImageKey = "icons8-customization-32.png";
            this.VehicleCustomization.Location = new System.Drawing.Point(4, 39);
            this.VehicleCustomization.Name = "VehicleCustomization";
            this.VehicleCustomization.Size = new System.Drawing.Size(1910, 864);
            this.VehicleCustomization.TabIndex = 5;
            this.VehicleCustomization.Text = "Vehicle Customization";
            this.VehicleCustomization.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-customization-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-contract-32.png");
            this.imageList1.Images.SetKeyName(2, "icons8-driver-32.png");
            this.imageList1.Images.SetKeyName(3, "icons8-landlord-32.png");
            this.imageList1.Images.SetKeyName(4, "icons8-customer-32.png");
            this.imageList1.Images.SetKeyName(5, "icons8-vehicle-insurance-32.png");
            // 
            // SalesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 974);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "SalesManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SalesManager_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Customer;
        private System.Windows.Forms.TabPage VehicleOwners;
        private System.Windows.Forms.TabPage TestDrive;
        private System.Windows.Forms.TabPage Vehicle;
        private System.Windows.Forms.TabPage SalesContract;
        private System.Windows.Forms.TabPage VehicleCustomization;
        private System.Windows.Forms.ImageList imageList1;
    }
}