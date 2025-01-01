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
            this.Home = new System.Windows.Forms.TabPage();
            this.Employees = new System.Windows.Forms.TabPage();
            this.SalesBudget = new System.Windows.Forms.TabPage();
            this.Records = new System.Windows.Forms.TabPage();
            this.NetProfit = new System.Windows.Forms.TabPage();
            this.Pricing = new System.Windows.Forms.TabPage();
            this.StockLevels = new System.Windows.Forms.TabPage();
            this.Report = new System.Windows.Forms.TabPage();
            this.Sales = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.EmpSearchtxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.EmpSearchbtn = new System.Windows.Forms.Button();
            this.EmpRoleCombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.EmpNametxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpEmailtxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpMobiletxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpCitytxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.EmpRolebox = new MaterialSkin.Controls.MaterialComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Addressmultilinebox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.Dobdate = new System.Windows.Forms.DateTimePicker();
            this.ll = new System.Windows.Forms.Label();
            this.Empcancelbtn = new MaterialSkin.Controls.MaterialButton();
            this.Empsavebtn = new MaterialSkin.Controls.MaterialButton();
            this.RecodsDataGridView = new System.Windows.Forms.DataGridView();
            this.materialTabControl1.SuspendLayout();
            this.Employees.SuspendLayout();
            this.Records.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecodsDataGridView)).BeginInit();
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
            this.materialTabControl1.Size = new System.Drawing.Size(1936, 954);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.ImageKey = "icons8-home-32.png";
            this.Home.Location = new System.Drawing.Point(4, 39);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1928, 911);
            this.Home.TabIndex = 7;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Employees
            // 
            this.Employees.Controls.Add(this.Empsavebtn);
            this.Employees.Controls.Add(this.Empcancelbtn);
            this.Employees.Controls.Add(this.ll);
            this.Employees.Controls.Add(this.Dobdate);
            this.Employees.Controls.Add(this.Addressmultilinebox);
            this.Employees.Controls.Add(this.Address);
            this.Employees.Controls.Add(this.label5);
            this.Employees.Controls.Add(this.EmpRolebox);
            this.Employees.Controls.Add(this.EmpCitytxtbox);
            this.Employees.Controls.Add(this.label4);
            this.Employees.Controls.Add(this.label3);
            this.Employees.Controls.Add(this.EmpMobiletxtbox);
            this.Employees.Controls.Add(this.label2);
            this.Employees.Controls.Add(this.EmpEmailtxtbox);
            this.Employees.Controls.Add(this.label1);
            this.Employees.Controls.Add(this.EmpNametxtbox);
            this.Employees.Controls.Add(this.EmpRoleCombobox);
            this.Employees.Controls.Add(this.EmpSearchbtn);
            this.Employees.Controls.Add(this.EmpSearchtxtbox);
            this.Employees.Controls.Add(this.EmployeeDataGridView);
            this.Employees.ImageKey = "icons8-employee-32.png";
            this.Employees.Location = new System.Drawing.Point(4, 39);
            this.Employees.Name = "Employees";
            this.Employees.Padding = new System.Windows.Forms.Padding(3);
            this.Employees.Size = new System.Drawing.Size(1928, 911);
            this.Employees.TabIndex = 1;
            this.Employees.Text = "Employees";
            this.Employees.UseVisualStyleBackColor = true;
            this.Employees.Click += new System.EventHandler(this.Employees_Click);
            // 
            // SalesBudget
            // 
            this.SalesBudget.ImageKey = "icons8-budget-35.png";
            this.SalesBudget.Location = new System.Drawing.Point(4, 39);
            this.SalesBudget.Name = "SalesBudget";
            this.SalesBudget.Padding = new System.Windows.Forms.Padding(3);
            this.SalesBudget.Size = new System.Drawing.Size(1928, 911);
            this.SalesBudget.TabIndex = 0;
            this.SalesBudget.Text = "Sales Budget";
            this.SalesBudget.UseVisualStyleBackColor = true;
            // 
            // Records
            // 
            this.Records.Controls.Add(this.RecodsDataGridView);
            this.Records.ImageKey = "icons8-records-32 (1).png";
            this.Records.Location = new System.Drawing.Point(4, 39);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(1928, 911);
            this.Records.TabIndex = 2;
            this.Records.Text = "Records";
            this.Records.UseVisualStyleBackColor = true;
            // 
            // NetProfit
            // 
            this.NetProfit.ImageKey = "icons8-profit-32.png";
            this.NetProfit.Location = new System.Drawing.Point(4, 39);
            this.NetProfit.Name = "NetProfit";
            this.NetProfit.Size = new System.Drawing.Size(1928, 911);
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
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(0, 87);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.RowHeadersWidth = 51;
            this.EmployeeDataGridView.RowTemplate.Height = 24;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(1386, 818);
            this.EmployeeDataGridView.TabIndex = 0;
            // 
            // EmpSearchtxtbox
            // 
            this.EmpSearchtxtbox.AnimateReadOnly = false;
            this.EmpSearchtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpSearchtxtbox.Depth = 0;
            this.EmpSearchtxtbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmpSearchtxtbox.LeadingIcon = null;
            this.EmpSearchtxtbox.Location = new System.Drawing.Point(775, 17);
            this.EmpSearchtxtbox.MaxLength = 50;
            this.EmpSearchtxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmpSearchtxtbox.Multiline = false;
            this.EmpSearchtxtbox.Name = "EmpSearchtxtbox";
            this.EmpSearchtxtbox.Size = new System.Drawing.Size(525, 50);
            this.EmpSearchtxtbox.TabIndex = 1;
            this.EmpSearchtxtbox.Text = "";
            this.EmpSearchtxtbox.TrailingIcon = null;
            // 
            // EmpSearchbtn
            // 
            this.EmpSearchbtn.Image = global::Finalproject.Properties.Resources.icons8_search_32;
            this.EmpSearchbtn.Location = new System.Drawing.Point(1325, 20);
            this.EmpSearchbtn.Name = "EmpSearchbtn";
            this.EmpSearchbtn.Size = new System.Drawing.Size(60, 48);
            this.EmpSearchbtn.TabIndex = 2;
            this.EmpSearchbtn.UseVisualStyleBackColor = true;
            // 
            // EmpRoleCombobox
            // 
            this.EmpRoleCombobox.AutoResize = false;
            this.EmpRoleCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EmpRoleCombobox.Depth = 0;
            this.EmpRoleCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.EmpRoleCombobox.DropDownHeight = 174;
            this.EmpRoleCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpRoleCombobox.DropDownWidth = 121;
            this.EmpRoleCombobox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.EmpRoleCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EmpRoleCombobox.FormattingEnabled = true;
            this.EmpRoleCombobox.IntegralHeight = false;
            this.EmpRoleCombobox.ItemHeight = 43;
            this.EmpRoleCombobox.Items.AddRange(new object[] {
            "ALL",
            "Accountant",
            "Sales Director",
            "Inventory Manager",
            "Service Head"});
            this.EmpRoleCombobox.Location = new System.Drawing.Point(29, 20);
            this.EmpRoleCombobox.MaxDropDownItems = 4;
            this.EmpRoleCombobox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmpRoleCombobox.Name = "EmpRoleCombobox";
            this.EmpRoleCombobox.Size = new System.Drawing.Size(295, 49);
            this.EmpRoleCombobox.StartIndex = 0;
            this.EmpRoleCombobox.TabIndex = 3;
            // 
            // EmpNametxtbox
            // 
            this.EmpNametxtbox.AnimateReadOnly = false;
            this.EmpNametxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpNametxtbox.Depth = 0;
            this.EmpNametxtbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmpNametxtbox.LeadingIcon = null;
            this.EmpNametxtbox.Location = new System.Drawing.Point(1508, 59);
            this.EmpNametxtbox.MaxLength = 50;
            this.EmpNametxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmpNametxtbox.Multiline = false;
            this.EmpNametxtbox.Name = "EmpNametxtbox";
            this.EmpNametxtbox.Size = new System.Drawing.Size(398, 50);
            this.EmpNametxtbox.TabIndex = 4;
            this.EmpNametxtbox.Text = "";
            this.EmpNametxtbox.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1505, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // EmpEmailtxtbox
            // 
            this.EmpEmailtxtbox.AnimateReadOnly = false;
            this.EmpEmailtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpEmailtxtbox.Depth = 0;
            this.EmpEmailtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmpEmailtxtbox.LeadingIcon = null;
            this.EmpEmailtxtbox.Location = new System.Drawing.Point(1508, 156);
            this.EmpEmailtxtbox.MaxLength = 50;
            this.EmpEmailtxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmpEmailtxtbox.Multiline = false;
            this.EmpEmailtxtbox.Name = "EmpEmailtxtbox";
            this.EmpEmailtxtbox.Size = new System.Drawing.Size(398, 50);
            this.EmpEmailtxtbox.TabIndex = 6;
            this.EmpEmailtxtbox.Text = "";
            this.EmpEmailtxtbox.TrailingIcon = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1505, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // EmpMobiletxtbox
            // 
            this.EmpMobiletxtbox.AnimateReadOnly = false;
            this.EmpMobiletxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpMobiletxtbox.Depth = 0;
            this.EmpMobiletxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmpMobiletxtbox.LeadingIcon = null;
            this.EmpMobiletxtbox.Location = new System.Drawing.Point(1508, 256);
            this.EmpMobiletxtbox.MaxLength = 50;
            this.EmpMobiletxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmpMobiletxtbox.Multiline = false;
            this.EmpMobiletxtbox.Name = "EmpMobiletxtbox";
            this.EmpMobiletxtbox.Size = new System.Drawing.Size(398, 50);
            this.EmpMobiletxtbox.TabIndex = 8;
            this.EmpMobiletxtbox.Text = "";
            this.EmpMobiletxtbox.TrailingIcon = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1505, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mobile Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1505, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "City";
            // 
            // EmpCitytxtbox
            // 
            this.EmpCitytxtbox.AnimateReadOnly = false;
            this.EmpCitytxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpCitytxtbox.Depth = 0;
            this.EmpCitytxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmpCitytxtbox.LeadingIcon = null;
            this.EmpCitytxtbox.Location = new System.Drawing.Point(1508, 454);
            this.EmpCitytxtbox.MaxLength = 50;
            this.EmpCitytxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmpCitytxtbox.Multiline = false;
            this.EmpCitytxtbox.Name = "EmpCitytxtbox";
            this.EmpCitytxtbox.Size = new System.Drawing.Size(398, 50);
            this.EmpCitytxtbox.TabIndex = 11;
            this.EmpCitytxtbox.Text = "";
            this.EmpCitytxtbox.TrailingIcon = null;
            // 
            // EmpRolebox
            // 
            this.EmpRolebox.AutoResize = false;
            this.EmpRolebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EmpRolebox.Depth = 0;
            this.EmpRolebox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.EmpRolebox.DropDownHeight = 174;
            this.EmpRolebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpRolebox.DropDownWidth = 121;
            this.EmpRolebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.EmpRolebox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EmpRolebox.FormattingEnabled = true;
            this.EmpRolebox.IntegralHeight = false;
            this.EmpRolebox.ItemHeight = 43;
            this.EmpRolebox.Items.AddRange(new object[] {
            "ALL",
            "Accountant",
            "Sales Director",
            "Inventory Manager",
            "Service Head"});
            this.EmpRolebox.Location = new System.Drawing.Point(1508, 356);
            this.EmpRolebox.MaxDropDownItems = 4;
            this.EmpRolebox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmpRolebox.Name = "EmpRolebox";
            this.EmpRolebox.Size = new System.Drawing.Size(398, 49);
            this.EmpRolebox.StartIndex = 0;
            this.EmpRolebox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1505, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Role";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(1508, 527);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(58, 16);
            this.Address.TabIndex = 14;
            this.Address.Text = "Address";
            // 
            // Addressmultilinebox
            // 
            this.Addressmultilinebox.AnimateReadOnly = false;
            this.Addressmultilinebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Addressmultilinebox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Addressmultilinebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Addressmultilinebox.Depth = 0;
            this.Addressmultilinebox.HideSelection = true;
            this.Addressmultilinebox.Location = new System.Drawing.Point(1508, 560);
            this.Addressmultilinebox.MaxLength = 32767;
            this.Addressmultilinebox.MouseState = MaterialSkin.MouseState.OUT;
            this.Addressmultilinebox.Name = "Addressmultilinebox";
            this.Addressmultilinebox.PasswordChar = '\0';
            this.Addressmultilinebox.ReadOnly = false;
            this.Addressmultilinebox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Addressmultilinebox.SelectedText = "";
            this.Addressmultilinebox.SelectionLength = 0;
            this.Addressmultilinebox.SelectionStart = 0;
            this.Addressmultilinebox.ShortcutsEnabled = true;
            this.Addressmultilinebox.Size = new System.Drawing.Size(398, 125);
            this.Addressmultilinebox.TabIndex = 15;
            this.Addressmultilinebox.TabStop = false;
            this.Addressmultilinebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Addressmultilinebox.UseSystemPasswordChar = false;
            // 
            // Dobdate
            // 
            this.Dobdate.Location = new System.Drawing.Point(1508, 749);
            this.Dobdate.Name = "Dobdate";
            this.Dobdate.Size = new System.Drawing.Size(398, 22);
            this.Dobdate.TabIndex = 16;
            // 
            // ll
            // 
            this.ll.AutoSize = true;
            this.ll.Location = new System.Drawing.Point(1505, 713);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(79, 16);
            this.ll.TabIndex = 17;
            this.ll.Text = "Date of Birth";
            // 
            // Empcancelbtn
            // 
            this.Empcancelbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Empcancelbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Empcancelbtn.Depth = 0;
            this.Empcancelbtn.HighEmphasis = true;
            this.Empcancelbtn.Icon = null;
            this.Empcancelbtn.Location = new System.Drawing.Point(1508, 849);
            this.Empcancelbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Empcancelbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Empcancelbtn.Name = "Empcancelbtn";
            this.Empcancelbtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Empcancelbtn.Size = new System.Drawing.Size(77, 36);
            this.Empcancelbtn.TabIndex = 18;
            this.Empcancelbtn.Text = "Cancel";
            this.Empcancelbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Empcancelbtn.UseAccentColor = false;
            this.Empcancelbtn.UseVisualStyleBackColor = true;
            // 
            // Empsavebtn
            // 
            this.Empsavebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Empsavebtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Empsavebtn.Depth = 0;
            this.Empsavebtn.HighEmphasis = true;
            this.Empsavebtn.Icon = null;
            this.Empsavebtn.Location = new System.Drawing.Point(1829, 849);
            this.Empsavebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Empsavebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Empsavebtn.Name = "Empsavebtn";
            this.Empsavebtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Empsavebtn.Size = new System.Drawing.Size(64, 36);
            this.Empsavebtn.TabIndex = 19;
            this.Empsavebtn.Text = "Save";
            this.Empsavebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Empsavebtn.UseAccentColor = false;
            this.Empsavebtn.UseVisualStyleBackColor = true;
            // 
            // RecodsDataGridView
            // 
            this.RecodsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecodsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecodsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.RecodsDataGridView.Name = "RecodsDataGridView";
            this.RecodsDataGridView.RowHeadersWidth = 51;
            this.RecodsDataGridView.RowTemplate.Height = 24;
            this.RecodsDataGridView.Size = new System.Drawing.Size(1928, 911);
            this.RecodsDataGridView.TabIndex = 0;
            // 
            // CEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1021);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MaximizeBox = false;
            this.Name = "CEO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CEO_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.Employees.ResumeLayout(false);
            this.Employees.PerformLayout();
            this.Records.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecodsDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private MaterialSkin.Controls.MaterialTextBox EmpSearchtxtbox;
        private System.Windows.Forms.Button EmpSearchbtn;
        private MaterialSkin.Controls.MaterialComboBox EmpRoleCombobox;
        private MaterialSkin.Controls.MaterialTextBox EmpNametxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox EmpEmailtxtbox;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox EmpMobiletxtbox;
        private MaterialSkin.Controls.MaterialTextBox EmpCitytxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialComboBox EmpRolebox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 Addressmultilinebox;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label ll;
        private System.Windows.Forms.DateTimePicker Dobdate;
        private MaterialSkin.Controls.MaterialButton Empsavebtn;
        private MaterialSkin.Controls.MaterialButton Empcancelbtn;
        private System.Windows.Forms.DataGridView RecodsDataGridView;
    }
}