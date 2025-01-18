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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Manager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.SpareParts = new System.Windows.Forms.TabPage();
            this.sparePartDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Tools = new System.Windows.Forms.TabPage();
            this.Products = new System.Windows.Forms.TabPage();
            this.Request = new System.Windows.Forms.TabPage();
            this.OrderingNewStock = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.ItemNametxtbox = new MaterialSkin.Controls.MaterialTextBox2();
            this.Quantitytxtbox = new MaterialSkin.Controls.MaterialTextBox2();
            this.PricePerItemtxtbox = new MaterialSkin.Controls.MaterialTextBox2();
            this.SerialNumbertxtbox = new MaterialSkin.Controls.MaterialTextBox2();
            this.bunifuDataGridView2 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.Descriptiontxtbox = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.ToolNametxtbox = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTabControl1.SuspendLayout();
            this.SpareParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartDataGridView)).BeginInit();
            this.Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView2)).BeginInit();
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
            this.SpareParts.Controls.Add(this.SerialNumbertxtbox);
            this.SpareParts.Controls.Add(this.PricePerItemtxtbox);
            this.SpareParts.Controls.Add(this.Quantitytxtbox);
            this.SpareParts.Controls.Add(this.ItemNametxtbox);
            this.SpareParts.Controls.Add(this.materialButton1);
            this.SpareParts.Controls.Add(this.sparePartDataGridView);
            this.SpareParts.ImageKey = "icons8-rotating-parts-hazard-32.png";
            this.SpareParts.Location = new System.Drawing.Point(4, 39);
            this.SpareParts.Name = "SpareParts";
            this.SpareParts.Size = new System.Drawing.Size(1910, 864);
            this.SpareParts.TabIndex = 4;
            this.SpareParts.Text = "Spare Parts";
            this.SpareParts.UseVisualStyleBackColor = true;
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
            this.sparePartDataGridView.ColumnHeadersHeight = 40;
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
            this.sparePartDataGridView.Size = new System.Drawing.Size(1191, 864);
            this.sparePartDataGridView.TabIndex = 0;
            this.sparePartDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Tools
            // 
            this.Tools.Controls.Add(this.Descriptiontxtbox);
            this.Tools.Controls.Add(this.materialTextBox1);
            this.Tools.Controls.Add(this.ToolNametxtbox);
            this.Tools.Controls.Add(this.materialButton2);
            this.Tools.Controls.Add(this.bunifuDataGridView2);
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
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1711, 785);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // ItemNametxtbox
            // 
            this.ItemNametxtbox.AnimateReadOnly = false;
            this.ItemNametxtbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ItemNametxtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ItemNametxtbox.Depth = 0;
            this.ItemNametxtbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ItemNametxtbox.HideSelection = true;
            this.ItemNametxtbox.LeadingIcon = null;
            this.ItemNametxtbox.Location = new System.Drawing.Point(1525, 86);
            this.ItemNametxtbox.MaxLength = 32767;
            this.ItemNametxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.ItemNametxtbox.Name = "ItemNametxtbox";
            this.ItemNametxtbox.PasswordChar = '\0';
            this.ItemNametxtbox.PrefixSuffixText = null;
            this.ItemNametxtbox.ReadOnly = false;
            this.ItemNametxtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ItemNametxtbox.SelectedText = "";
            this.ItemNametxtbox.SelectionLength = 0;
            this.ItemNametxtbox.SelectionStart = 0;
            this.ItemNametxtbox.ShortcutsEnabled = true;
            this.ItemNametxtbox.Size = new System.Drawing.Size(250, 48);
            this.ItemNametxtbox.TabIndex = 2;
            this.ItemNametxtbox.TabStop = false;
            this.ItemNametxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ItemNametxtbox.TrailingIcon = null;
            this.ItemNametxtbox.UseSystemPasswordChar = false;
            // 
            // Quantitytxtbox
            // 
            this.Quantitytxtbox.AnimateReadOnly = false;
            this.Quantitytxtbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Quantitytxtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Quantitytxtbox.Depth = 0;
            this.Quantitytxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Quantitytxtbox.HideSelection = true;
            this.Quantitytxtbox.LeadingIcon = null;
            this.Quantitytxtbox.Location = new System.Drawing.Point(1525, 196);
            this.Quantitytxtbox.MaxLength = 32767;
            this.Quantitytxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.Quantitytxtbox.Name = "Quantitytxtbox";
            this.Quantitytxtbox.PasswordChar = '\0';
            this.Quantitytxtbox.PrefixSuffixText = null;
            this.Quantitytxtbox.ReadOnly = false;
            this.Quantitytxtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Quantitytxtbox.SelectedText = "";
            this.Quantitytxtbox.SelectionLength = 0;
            this.Quantitytxtbox.SelectionStart = 0;
            this.Quantitytxtbox.ShortcutsEnabled = true;
            this.Quantitytxtbox.Size = new System.Drawing.Size(250, 48);
            this.Quantitytxtbox.TabIndex = 3;
            this.Quantitytxtbox.TabStop = false;
            this.Quantitytxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Quantitytxtbox.TrailingIcon = null;
            this.Quantitytxtbox.UseSystemPasswordChar = false;
            // 
            // PricePerItemtxtbox
            // 
            this.PricePerItemtxtbox.AnimateReadOnly = false;
            this.PricePerItemtxtbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PricePerItemtxtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PricePerItemtxtbox.Depth = 0;
            this.PricePerItemtxtbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PricePerItemtxtbox.HideSelection = true;
            this.PricePerItemtxtbox.LeadingIcon = null;
            this.PricePerItemtxtbox.Location = new System.Drawing.Point(1525, 324);
            this.PricePerItemtxtbox.MaxLength = 32767;
            this.PricePerItemtxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.PricePerItemtxtbox.Name = "PricePerItemtxtbox";
            this.PricePerItemtxtbox.PasswordChar = '\0';
            this.PricePerItemtxtbox.PrefixSuffixText = null;
            this.PricePerItemtxtbox.ReadOnly = false;
            this.PricePerItemtxtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PricePerItemtxtbox.SelectedText = "";
            this.PricePerItemtxtbox.SelectionLength = 0;
            this.PricePerItemtxtbox.SelectionStart = 0;
            this.PricePerItemtxtbox.ShortcutsEnabled = true;
            this.PricePerItemtxtbox.Size = new System.Drawing.Size(250, 48);
            this.PricePerItemtxtbox.TabIndex = 4;
            this.PricePerItemtxtbox.TabStop = false;
            this.PricePerItemtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PricePerItemtxtbox.TrailingIcon = null;
            this.PricePerItemtxtbox.UseSystemPasswordChar = false;
            // 
            // SerialNumbertxtbox
            // 
            this.SerialNumbertxtbox.AnimateReadOnly = false;
            this.SerialNumbertxtbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SerialNumbertxtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SerialNumbertxtbox.Depth = 0;
            this.SerialNumbertxtbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SerialNumbertxtbox.HideSelection = true;
            this.SerialNumbertxtbox.LeadingIcon = null;
            this.SerialNumbertxtbox.Location = new System.Drawing.Point(1525, 437);
            this.SerialNumbertxtbox.MaxLength = 32767;
            this.SerialNumbertxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.SerialNumbertxtbox.Name = "SerialNumbertxtbox";
            this.SerialNumbertxtbox.PasswordChar = '\0';
            this.SerialNumbertxtbox.PrefixSuffixText = null;
            this.SerialNumbertxtbox.ReadOnly = false;
            this.SerialNumbertxtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SerialNumbertxtbox.SelectedText = "";
            this.SerialNumbertxtbox.SelectionLength = 0;
            this.SerialNumbertxtbox.SelectionStart = 0;
            this.SerialNumbertxtbox.ShortcutsEnabled = true;
            this.SerialNumbertxtbox.Size = new System.Drawing.Size(250, 48);
            this.SerialNumbertxtbox.TabIndex = 5;
            this.SerialNumbertxtbox.TabStop = false;
            this.SerialNumbertxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SerialNumbertxtbox.TrailingIcon = null;
            this.SerialNumbertxtbox.UseSystemPasswordChar = false;
            // 
            // bunifuDataGridView2
            // 
            this.bunifuDataGridView2.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.Name = null;
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuDataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuDataGridView2.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView2.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.Location = new System.Drawing.Point(3, 3);
            this.bunifuDataGridView2.Name = "bunifuDataGridView2";
            this.bunifuDataGridView2.RowHeadersVisible = false;
            this.bunifuDataGridView2.RowHeadersWidth = 51;
            this.bunifuDataGridView2.RowTemplate.Height = 40;
            this.bunifuDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView2.Size = new System.Drawing.Size(1217, 858);
            this.bunifuDataGridView2.TabIndex = 0;
            this.bunifuDataGridView2.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(1711, 792);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(158, 36);
            this.materialButton2.TabIndex = 1;
            this.materialButton2.Text = "materialButton2";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // Descriptiontxtbox
            // 
            this.Descriptiontxtbox.AnimateReadOnly = false;
            this.Descriptiontxtbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Descriptiontxtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Descriptiontxtbox.Depth = 0;
            this.Descriptiontxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Descriptiontxtbox.HideSelection = true;
            this.Descriptiontxtbox.LeadingIcon = null;
            this.Descriptiontxtbox.Location = new System.Drawing.Point(1503, 277);
            this.Descriptiontxtbox.MaxLength = 32767;
            this.Descriptiontxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.Descriptiontxtbox.Name = "Descriptiontxtbox";
            this.Descriptiontxtbox.PasswordChar = '\0';
            this.Descriptiontxtbox.PrefixSuffixText = null;
            this.Descriptiontxtbox.ReadOnly = false;
            this.Descriptiontxtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Descriptiontxtbox.SelectedText = "";
            this.Descriptiontxtbox.SelectionLength = 0;
            this.Descriptiontxtbox.SelectionStart = 0;
            this.Descriptiontxtbox.ShortcutsEnabled = true;
            this.Descriptiontxtbox.Size = new System.Drawing.Size(250, 48);
            this.Descriptiontxtbox.TabIndex = 7;
            this.Descriptiontxtbox.TabStop = false;
            this.Descriptiontxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Descriptiontxtbox.TrailingIcon = null;
            this.Descriptiontxtbox.UseSystemPasswordChar = false;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.HideSelection = true;
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(1503, 149);
            this.materialTextBox1.MaxLength = 32767;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.PasswordChar = '\0';
            this.materialTextBox1.PrefixSuffixText = null;
            this.materialTextBox1.ReadOnly = false;
            this.materialTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox1.SelectedText = "";
            this.materialTextBox1.SelectionLength = 0;
            this.materialTextBox1.SelectionStart = 0;
            this.materialTextBox1.ShortcutsEnabled = true;
            this.materialTextBox1.Size = new System.Drawing.Size(250, 48);
            this.materialTextBox1.TabIndex = 6;
            this.materialTextBox1.TabStop = false;
            this.materialTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox1.TrailingIcon = null;
            this.materialTextBox1.UseSystemPasswordChar = false;
            // 
            // ToolNametxtbox
            // 
            this.ToolNametxtbox.AnimateReadOnly = false;
            this.ToolNametxtbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToolNametxtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ToolNametxtbox.Depth = 0;
            this.ToolNametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ToolNametxtbox.HideSelection = true;
            this.ToolNametxtbox.LeadingIcon = null;
            this.ToolNametxtbox.Location = new System.Drawing.Point(1503, 39);
            this.ToolNametxtbox.MaxLength = 32767;
            this.ToolNametxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.ToolNametxtbox.Name = "ToolNametxtbox";
            this.ToolNametxtbox.PasswordChar = '\0';
            this.ToolNametxtbox.PrefixSuffixText = null;
            this.ToolNametxtbox.ReadOnly = false;
            this.ToolNametxtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToolNametxtbox.SelectedText = "";
            this.ToolNametxtbox.SelectionLength = 0;
            this.ToolNametxtbox.SelectionStart = 0;
            this.ToolNametxtbox.ShortcutsEnabled = true;
            this.ToolNametxtbox.Size = new System.Drawing.Size(250, 48);
            this.ToolNametxtbox.TabIndex = 5;
            this.ToolNametxtbox.TabStop = false;
            this.ToolNametxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ToolNametxtbox.TrailingIcon = null;
            this.ToolNametxtbox.UseSystemPasswordChar = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.sparePartDataGridView)).EndInit();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView2)).EndInit();
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
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 Quantitytxtbox;
        private MaterialSkin.Controls.MaterialTextBox2 ItemNametxtbox;
        private MaterialSkin.Controls.MaterialTextBox2 PricePerItemtxtbox;
        private MaterialSkin.Controls.MaterialTextBox2 SerialNumbertxtbox;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView2;
        private MaterialSkin.Controls.MaterialTextBox2 Descriptiontxtbox;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox2 ToolNametxtbox;
    }
}