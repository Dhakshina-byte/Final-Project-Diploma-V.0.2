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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.SpareParts = new System.Windows.Forms.TabPage();
            this.Tools = new System.Windows.Forms.TabPage();
            this.Products = new System.Windows.Forms.TabPage();
            this.Request = new System.Windows.Forms.TabPage();
            this.OrderingNewStock = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sparePartDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemNametxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SerialNumbertxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PricePerItemtxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Quantitytxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.Submitbtn = new MaterialSkin.Controls.MaterialButton();
            this.Cancelbtn = new MaterialSkin.Controls.MaterialButton();
            this.ToolsDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ToolNametxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Descriptiontxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.StatusComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.ToolsSubmitbtn = new MaterialSkin.Controls.MaterialButton();
            this.ToolCancelbtn = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.SpareParts.SuspendLayout();
            this.Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolsDataGridView)).BeginInit();
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
            // SpareParts
            // 
            this.SpareParts.Controls.Add(this.Cancelbtn);
            this.SpareParts.Controls.Add(this.Submitbtn);
            this.SpareParts.Controls.Add(this.Quantitytxtbox);
            this.SpareParts.Controls.Add(this.label5);
            this.SpareParts.Controls.Add(this.PricePerItemtxtbox);
            this.SpareParts.Controls.Add(this.label4);
            this.SpareParts.Controls.Add(this.SerialNumbertxtbox);
            this.SpareParts.Controls.Add(this.label3);
            this.SpareParts.Controls.Add(this.ItemNametxtbox);
            this.SpareParts.Controls.Add(this.label2);
            this.SpareParts.Controls.Add(this.label1);
            this.SpareParts.Controls.Add(this.sparePartDataGridView);
            this.SpareParts.ImageKey = "icons8-rotating-parts-hazard-32.png";
            this.SpareParts.Location = new System.Drawing.Point(4, 39);
            this.SpareParts.Name = "SpareParts";
            this.SpareParts.Size = new System.Drawing.Size(1910, 864);
            this.SpareParts.TabIndex = 4;
            this.SpareParts.Text = "Spare Parts";
            this.SpareParts.UseVisualStyleBackColor = true;
            // 
            // Tools
            // 
            this.Tools.Controls.Add(this.ToolCancelbtn);
            this.Tools.Controls.Add(this.ToolsSubmitbtn);
            this.Tools.Controls.Add(this.StatusComboBox);
            this.Tools.Controls.Add(this.label9);
            this.Tools.Controls.Add(this.Descriptiontxtbox);
            this.Tools.Controls.Add(this.label8);
            this.Tools.Controls.Add(this.ToolNametxtbox);
            this.Tools.Controls.Add(this.label7);
            this.Tools.Controls.Add(this.label6);
            this.Tools.Controls.Add(this.ToolsDataGridView);
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
            // sparePartDataGridView
            // 
            this.sparePartDataGridView.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.sparePartDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sparePartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sparePartDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sparePartDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sparePartDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sparePartDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sparePartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sparePartDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.sparePartDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.sparePartDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.sparePartDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sparePartDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.sparePartDataGridView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.sparePartDataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.sparePartDataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.sparePartDataGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.sparePartDataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.sparePartDataGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.sparePartDataGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.sparePartDataGridView.CurrentTheme.Name = null;
            this.sparePartDataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.sparePartDataGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.sparePartDataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.sparePartDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sparePartDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sparePartDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.sparePartDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.sparePartDataGridView.EnableHeadersVisualStyles = false;
            this.sparePartDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.sparePartDataGridView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.sparePartDataGridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.sparePartDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.sparePartDataGridView.Location = new System.Drawing.Point(0, 0);
            this.sparePartDataGridView.Name = "sparePartDataGridView";
            this.sparePartDataGridView.RowHeadersVisible = false;
            this.sparePartDataGridView.RowHeadersWidth = 51;
            this.sparePartDataGridView.RowTemplate.Height = 40;
            this.sparePartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sparePartDataGridView.Size = new System.Drawing.Size(1307, 864);
            this.sparePartDataGridView.TabIndex = 0;
            this.sparePartDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.sparePartDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sparePartDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1598, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Register";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1388, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name";
            // 
            // ItemNametxtbox
            // 
            this.ItemNametxtbox.AnimateReadOnly = false;
            this.ItemNametxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemNametxtbox.Depth = 0;
            this.ItemNametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ItemNametxtbox.LeadingIcon = null;
            this.ItemNametxtbox.Location = new System.Drawing.Point(1391, 86);
            this.ItemNametxtbox.MaxLength = 50;
            this.ItemNametxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.ItemNametxtbox.Multiline = false;
            this.ItemNametxtbox.Name = "ItemNametxtbox";
            this.ItemNametxtbox.Size = new System.Drawing.Size(412, 50);
            this.ItemNametxtbox.TabIndex = 3;
            this.ItemNametxtbox.Text = "";
            this.ItemNametxtbox.TrailingIcon = null;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1388, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Serial Number";
            // 
            // SerialNumbertxtbox
            // 
            this.SerialNumbertxtbox.AnimateReadOnly = false;
            this.SerialNumbertxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SerialNumbertxtbox.Depth = 0;
            this.SerialNumbertxtbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SerialNumbertxtbox.LeadingIcon = null;
            this.SerialNumbertxtbox.Location = new System.Drawing.Point(1391, 194);
            this.SerialNumbertxtbox.MaxLength = 50;
            this.SerialNumbertxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.SerialNumbertxtbox.Multiline = false;
            this.SerialNumbertxtbox.Name = "SerialNumbertxtbox";
            this.SerialNumbertxtbox.Size = new System.Drawing.Size(412, 50);
            this.SerialNumbertxtbox.TabIndex = 5;
            this.SerialNumbertxtbox.Text = "";
            this.SerialNumbertxtbox.TrailingIcon = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1391, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price Per Item";
            // 
            // PricePerItemtxtbox
            // 
            this.PricePerItemtxtbox.AnimateReadOnly = false;
            this.PricePerItemtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PricePerItemtxtbox.Depth = 0;
            this.PricePerItemtxtbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PricePerItemtxtbox.LeadingIcon = null;
            this.PricePerItemtxtbox.Location = new System.Drawing.Point(1391, 303);
            this.PricePerItemtxtbox.MaxLength = 50;
            this.PricePerItemtxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.PricePerItemtxtbox.Multiline = false;
            this.PricePerItemtxtbox.Name = "PricePerItemtxtbox";
            this.PricePerItemtxtbox.Size = new System.Drawing.Size(412, 50);
            this.PricePerItemtxtbox.TabIndex = 7;
            this.PricePerItemtxtbox.Text = "";
            this.PricePerItemtxtbox.TrailingIcon = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1391, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // Quantitytxtbox
            // 
            this.Quantitytxtbox.AnimateReadOnly = false;
            this.Quantitytxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Quantitytxtbox.Depth = 0;
            this.Quantitytxtbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Quantitytxtbox.LeadingIcon = null;
            this.Quantitytxtbox.Location = new System.Drawing.Point(1394, 413);
            this.Quantitytxtbox.MaxLength = 50;
            this.Quantitytxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.Quantitytxtbox.Multiline = false;
            this.Quantitytxtbox.Name = "Quantitytxtbox";
            this.Quantitytxtbox.Size = new System.Drawing.Size(412, 50);
            this.Quantitytxtbox.TabIndex = 9;
            this.Quantitytxtbox.Text = "";
            this.Quantitytxtbox.TrailingIcon = null;
            // 
            // Submitbtn
            // 
            this.Submitbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Submitbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Submitbtn.Depth = 0;
            this.Submitbtn.HighEmphasis = true;
            this.Submitbtn.Icon = null;
            this.Submitbtn.Location = new System.Drawing.Point(1728, 618);
            this.Submitbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Submitbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Submitbtn.Size = new System.Drawing.Size(75, 36);
            this.Submitbtn.TabIndex = 10;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Submitbtn.UseAccentColor = false;
            this.Submitbtn.UseVisualStyleBackColor = true;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancelbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Cancelbtn.Depth = 0;
            this.Cancelbtn.HighEmphasis = true;
            this.Cancelbtn.Icon = null;
            this.Cancelbtn.Location = new System.Drawing.Point(1394, 618);
            this.Cancelbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Cancelbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Cancelbtn.Size = new System.Drawing.Size(77, 36);
            this.Cancelbtn.TabIndex = 11;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Cancelbtn.UseAccentColor = false;
            this.Cancelbtn.UseVisualStyleBackColor = true;
            // 
            // ToolsDataGridView
            // 
            this.ToolsDataGridView.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.ToolsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ToolsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ToolsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToolsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ToolsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ToolsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ToolsDataGridView.ColumnHeadersHeight = 40;
            this.ToolsDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.ToolsDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ToolsDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ToolsDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ToolsDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ToolsDataGridView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.ToolsDataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ToolsDataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.ToolsDataGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.ToolsDataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ToolsDataGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.ToolsDataGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ToolsDataGridView.CurrentTheme.Name = null;
            this.ToolsDataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ToolsDataGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ToolsDataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ToolsDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ToolsDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ToolsDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.ToolsDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolsDataGridView.EnableHeadersVisualStyles = false;
            this.ToolsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ToolsDataGridView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.ToolsDataGridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.ToolsDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.ToolsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ToolsDataGridView.Name = "ToolsDataGridView";
            this.ToolsDataGridView.RowHeadersVisible = false;
            this.ToolsDataGridView.RowHeadersWidth = 51;
            this.ToolsDataGridView.RowTemplate.Height = 40;
            this.ToolsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ToolsDataGridView.Size = new System.Drawing.Size(1307, 858);
            this.ToolsDataGridView.TabIndex = 0;
            this.ToolsDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.ToolsDataGridView.VirtualMode = true;
            this.ToolsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1594, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Register";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1380, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tool Name";
            // 
            // ToolNametxtbox
            // 
            this.ToolNametxtbox.AnimateReadOnly = false;
            this.ToolNametxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToolNametxtbox.Depth = 0;
            this.ToolNametxtbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ToolNametxtbox.LeadingIcon = null;
            this.ToolNametxtbox.Location = new System.Drawing.Point(1383, 85);
            this.ToolNametxtbox.MaxLength = 50;
            this.ToolNametxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.ToolNametxtbox.Multiline = false;
            this.ToolNametxtbox.Name = "ToolNametxtbox";
            this.ToolNametxtbox.Size = new System.Drawing.Size(471, 50);
            this.ToolNametxtbox.TabIndex = 3;
            this.ToolNametxtbox.Text = "";
            this.ToolNametxtbox.TrailingIcon = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1380, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Description";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Descriptiontxtbox
            // 
            this.Descriptiontxtbox.AnimateReadOnly = false;
            this.Descriptiontxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Descriptiontxtbox.Depth = 0;
            this.Descriptiontxtbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Descriptiontxtbox.LeadingIcon = null;
            this.Descriptiontxtbox.Location = new System.Drawing.Point(1383, 198);
            this.Descriptiontxtbox.MaxLength = 50;
            this.Descriptiontxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.Descriptiontxtbox.Multiline = false;
            this.Descriptiontxtbox.Name = "Descriptiontxtbox";
            this.Descriptiontxtbox.Size = new System.Drawing.Size(471, 50);
            this.Descriptiontxtbox.TabIndex = 5;
            this.Descriptiontxtbox.Text = "";
            this.Descriptiontxtbox.TrailingIcon = null;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1380, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Status";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.AutoResize = false;
            this.StatusComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StatusComboBox.Depth = 0;
            this.StatusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.StatusComboBox.DropDownHeight = 174;
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.DropDownWidth = 121;
            this.StatusComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.StatusComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.IntegralHeight = false;
            this.StatusComboBox.ItemHeight = 43;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Available",
            "Unavailable",
            "Broken"});
            this.StatusComboBox.Location = new System.Drawing.Point(1383, 313);
            this.StatusComboBox.MaxDropDownItems = 4;
            this.StatusComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(471, 49);
            this.StatusComboBox.StartIndex = 0;
            this.StatusComboBox.TabIndex = 7;
            // 
            // ToolsSubmitbtn
            // 
            this.ToolsSubmitbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToolsSubmitbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ToolsSubmitbtn.Depth = 0;
            this.ToolsSubmitbtn.HighEmphasis = true;
            this.ToolsSubmitbtn.Icon = null;
            this.ToolsSubmitbtn.Location = new System.Drawing.Point(1779, 543);
            this.ToolsSubmitbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ToolsSubmitbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ToolsSubmitbtn.Name = "ToolsSubmitbtn";
            this.ToolsSubmitbtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ToolsSubmitbtn.Size = new System.Drawing.Size(75, 36);
            this.ToolsSubmitbtn.TabIndex = 8;
            this.ToolsSubmitbtn.Text = "Submit";
            this.ToolsSubmitbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ToolsSubmitbtn.UseAccentColor = false;
            this.ToolsSubmitbtn.UseVisualStyleBackColor = true;
            this.ToolsSubmitbtn.Click += new System.EventHandler(this.ToolsSubmitbtn_Click);
            // 
            // ToolCancelbtn
            // 
            this.ToolCancelbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToolCancelbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ToolCancelbtn.Depth = 0;
            this.ToolCancelbtn.HighEmphasis = true;
            this.ToolCancelbtn.Icon = null;
            this.ToolCancelbtn.Location = new System.Drawing.Point(1383, 543);
            this.ToolCancelbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ToolCancelbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ToolCancelbtn.Name = "ToolCancelbtn";
            this.ToolCancelbtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ToolCancelbtn.Size = new System.Drawing.Size(158, 36);
            this.ToolCancelbtn.TabIndex = 9;
            this.ToolCancelbtn.Text = "Cancel";
            this.ToolCancelbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ToolCancelbtn.UseAccentColor = false;
            this.ToolCancelbtn.UseVisualStyleBackColor = true;
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
            this.SpareParts.ResumeLayout(false);
            this.SpareParts.PerformLayout();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolsDataGridView)).EndInit();
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
        private Bunifu.UI.WinForms.BunifuDataGridView sparePartDataGridView;
        private MaterialSkin.Controls.MaterialTextBox ItemNametxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialTextBox SerialNumbertxtbox;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox Quantitytxtbox;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox PricePerItemtxtbox;
        private MaterialSkin.Controls.MaterialButton Submitbtn;
        private MaterialSkin.Controls.MaterialButton Cancelbtn;
        private Bunifu.UI.WinForms.BunifuDataGridView ToolsDataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox ToolNametxtbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialTextBox Descriptiontxtbox;
        private MaterialSkin.Controls.MaterialComboBox StatusComboBox;
        private MaterialSkin.Controls.MaterialButton ToolsSubmitbtn;
        private MaterialSkin.Controls.MaterialButton ToolCancelbtn;
    }
}