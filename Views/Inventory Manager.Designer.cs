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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.Tools = new System.Windows.Forms.TabPage();
            this.Products = new System.Windows.Forms.TabPage();
            this.Request = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Home);
            this.materialTabControl1.Controls.Add(this.Tools);
            this.materialTabControl1.Controls.Add(this.Products);
            this.materialTabControl1.Controls.Add(this.Request);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.Home.Location = new System.Drawing.Point(4, 25);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1910, 878);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Tools
            // 
            this.Tools.Location = new System.Drawing.Point(4, 25);
            this.Tools.Name = "Tools";
            this.Tools.Padding = new System.Windows.Forms.Padding(3);
            this.Tools.Size = new System.Drawing.Size(1910, 878);
            this.Tools.TabIndex = 1;
            this.Tools.Text = " Tools";
            this.Tools.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            this.Products.Location = new System.Drawing.Point(4, 25);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(1910, 878);
            this.Products.TabIndex = 2;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = true;
            // 
            // Request
            // 
            this.Request.Location = new System.Drawing.Point(4, 25);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(1910, 878);
            this.Request.TabIndex = 3;
            this.Request.Text = "Requests";
            this.Request.UseVisualStyleBackColor = true;
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
    }
}