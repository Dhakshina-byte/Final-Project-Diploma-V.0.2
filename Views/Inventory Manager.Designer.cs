namespace Finalproject.Views
{
    partial class Inventory_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Manager));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.Tools = new System.Windows.Forms.TabPage();
            this.Products = new System.Windows.Forms.TabPage();
            this.Request = new System.Windows.Forms.TabPage();
            this.SpareParts = new System.Windows.Forms.TabPage();
            this.OrderingNewStock = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Home);
            this.materialTabControl1.Controls.Add(this.SpareParts);
            this.materialTabControl1.Controls.Add(this.Tools);
            this.materialTabControl1.Controls.Add(this.Products);
            this.materialTabControl1.Controls.Add(this.Request);
            this.materialTabControl1.Controls.Add(this.OrderingNewStock);
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
            // Home
            // 
            this.Home.ImageKey = "icons8-home-32.png";
            this.Home.Location = new System.Drawing.Point(4, 39);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1910, 864);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Tools
            // 
            this.Tools.ImageKey = "icons8-tools-32.png";
            this.Tools.Location = new System.Drawing.Point(4, 39);
            this.Tools.Name = "Tools";
            this.Tools.Padding = new System.Windows.Forms.Padding(3);
            this.Tools.Size = new System.Drawing.Size(1910, 864);
            this.Tools.TabIndex = 1;
            this.Tools.Text = " Tools";
            this.Tools.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            this.Products.ImageKey = "icons8-products-32.png";
            this.Products.Location = new System.Drawing.Point(4, 39);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(1910, 864);
            this.Products.TabIndex = 2;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = true;
            // 
            // Request
            // 
            this.Request.ImageKey = "icons8-request-32.png";
            this.Request.Location = new System.Drawing.Point(4, 39);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(1910, 864);
            this.Request.TabIndex = 3;
            this.Request.Text = "Requests";
            this.Request.UseVisualStyleBackColor = true;
            // 
            // SpareParts
            // 
            this.SpareParts.ImageKey = "icons8-rotating-parts-hazard-32.png";
            this.SpareParts.Location = new System.Drawing.Point(4, 39);
            this.SpareParts.Name = "SpareParts";
            this.SpareParts.Size = new System.Drawing.Size(1910, 864);
            this.SpareParts.TabIndex = 4;
            this.SpareParts.Text = "Spare Parts";
            this.SpareParts.UseVisualStyleBackColor = true;
            // 
            // OrderingNewStock
            // 
            this.OrderingNewStock.ImageKey = "icons8-order-32.png";
            this.OrderingNewStock.Location = new System.Drawing.Point(4, 39);
            this.OrderingNewStock.Name = "OrderingNewStock";
            this.OrderingNewStock.Size = new System.Drawing.Size(1910, 864);
            this.OrderingNewStock.TabIndex = 5;
            this.OrderingNewStock.Text = "Ordering New Stock";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-rotating-parts-hazard-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-products-32.png");
            this.imageList1.Images.SetKeyName(2, "icons8-tools-32.png");
            this.imageList1.Images.SetKeyName(3, "icons8-home-32.png");
            this.imageList1.Images.SetKeyName(4, "icons8-order-32.png");
            this.imageList1.Images.SetKeyName(5, "icons8-request-32.png");
            // 
            // Inventory_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 974);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Inventory_Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inventory_Manager_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Tools;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.TabPage Request;
        private System.Windows.Forms.TabPage SpareParts;
        private System.Windows.Forms.TabPage OrderingNewStock;
        private System.Windows.Forms.ImageList imageList1;
    }
}