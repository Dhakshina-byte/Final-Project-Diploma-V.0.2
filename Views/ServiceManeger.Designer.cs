namespace Finalproject.Views
{
    partial class ServiceManeger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceManeger));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.ServiceProgress = new System.Windows.Forms.TabPage();
            this.ServiceBooking = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.Statuscombo = new MaterialSkin.Controls.MaterialComboBox();
            this.washCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.RepairsCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.InstallationCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.maintanceCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.Inspectioncheck = new MaterialSkin.Controls.MaterialCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.ServiceBookingGridview = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.VehicleID = new MaterialSkin.Controls.MaterialLabel();
            this.Vehiclesearchbox1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Vehiclesearchbox = new MaterialSkin.Controls.MaterialTextBox2();
            this.SpareParts = new System.Windows.Forms.TabPage();
            this.Tools = new System.Windows.Forms.TabPage();
            this.Request = new System.Windows.Forms.TabPage();
            this.VehicleInspection = new System.Windows.Forms.TabPage();
            this.Maintenance = new System.Windows.Forms.TabPage();
            this.InstallationSetup = new System.Windows.Forms.TabPage();
            this.Repairs = new System.Windows.Forms.TabPage();
            this.VehicleWash = new System.Windows.Forms.TabPage();
            this.VehicleOwners = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.ServiceBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBookingGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vehiclesearchbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Home);
            this.materialTabControl1.Controls.Add(this.ServiceProgress);
            this.materialTabControl1.Controls.Add(this.ServiceBooking);
            this.materialTabControl1.Controls.Add(this.SpareParts);
            this.materialTabControl1.Controls.Add(this.Tools);
            this.materialTabControl1.Controls.Add(this.Request);
            this.materialTabControl1.Controls.Add(this.VehicleInspection);
            this.materialTabControl1.Controls.Add(this.Maintenance);
            this.materialTabControl1.Controls.Add(this.InstallationSetup);
            this.materialTabControl1.Controls.Add(this.Repairs);
            this.materialTabControl1.Controls.Add(this.VehicleWash);
            this.materialTabControl1.Controls.Add(this.VehicleOwners);
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
            // ServiceProgress
            // 
            this.ServiceProgress.ImageKey = "icons8-progress-bar-32.png";
            this.ServiceProgress.Location = new System.Drawing.Point(4, 39);
            this.ServiceProgress.Name = "ServiceProgress";
            this.ServiceProgress.Padding = new System.Windows.Forms.Padding(3);
            this.ServiceProgress.Size = new System.Drawing.Size(1910, 864);
            this.ServiceProgress.TabIndex = 1;
            this.ServiceProgress.Text = "Service Progress";
            this.ServiceProgress.UseVisualStyleBackColor = true;
            // 
            // ServiceBooking
            // 
            this.ServiceBooking.Controls.Add(this.materialButton1);
            this.ServiceBooking.Controls.Add(this.Statuscombo);
            this.ServiceBooking.Controls.Add(this.washCheckbox);
            this.ServiceBooking.Controls.Add(this.RepairsCheckbox);
            this.ServiceBooking.Controls.Add(this.InstallationCheckbox);
            this.ServiceBooking.Controls.Add(this.maintanceCheckbox);
            this.ServiceBooking.Controls.Add(this.Inspectioncheck);
            this.ServiceBooking.Controls.Add(this.label1);
            this.ServiceBooking.Controls.Add(this.bunifuDatePicker1);
            this.ServiceBooking.Controls.Add(this.ServiceBookingGridview);
            this.ServiceBooking.Controls.Add(this.VehicleID);
            this.ServiceBooking.Controls.Add(this.Vehiclesearchbox1);
            this.ServiceBooking.Controls.Add(this.Vehiclesearchbox);
            this.ServiceBooking.ImageKey = "icons8-service-32.png";
            this.ServiceBooking.Location = new System.Drawing.Point(4, 39);
            this.ServiceBooking.Name = "ServiceBooking";
            this.ServiceBooking.Size = new System.Drawing.Size(1910, 864);
            this.ServiceBooking.TabIndex = 5;
            this.ServiceBooking.Text = "Service Booking";
            this.ServiceBooking.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1706, 170);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(75, 36);
            this.materialButton1.TabIndex = 12;
            this.materialButton1.Text = "Submit";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Statuscombo
            // 
            this.Statuscombo.AutoResize = false;
            this.Statuscombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Statuscombo.Depth = 0;
            this.Statuscombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Statuscombo.DropDownHeight = 174;
            this.Statuscombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Statuscombo.DropDownWidth = 121;
            this.Statuscombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Statuscombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Statuscombo.FormattingEnabled = true;
            this.Statuscombo.IntegralHeight = false;
            this.Statuscombo.ItemHeight = 43;
            this.Statuscombo.Items.AddRange(new object[] {
            "Reservation",
            "Booking"});
            this.Statuscombo.Location = new System.Drawing.Point(40, 157);
            this.Statuscombo.MaxDropDownItems = 4;
            this.Statuscombo.MouseState = MaterialSkin.MouseState.OUT;
            this.Statuscombo.Name = "Statuscombo";
            this.Statuscombo.Size = new System.Drawing.Size(572, 49);
            this.Statuscombo.StartIndex = 0;
            this.Statuscombo.TabIndex = 11;
            // 
            // washCheckbox
            // 
            this.washCheckbox.AutoSize = true;
            this.washCheckbox.Depth = 0;
            this.washCheckbox.Location = new System.Drawing.Point(1809, 41);
            this.washCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.washCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.washCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.washCheckbox.Name = "washCheckbox";
            this.washCheckbox.ReadOnly = false;
            this.washCheckbox.Ripple = true;
            this.washCheckbox.Size = new System.Drawing.Size(75, 37);
            this.washCheckbox.TabIndex = 10;
            this.washCheckbox.Text = "Wash";
            this.washCheckbox.UseVisualStyleBackColor = true;
            // 
            // RepairsCheckbox
            // 
            this.RepairsCheckbox.AutoSize = true;
            this.RepairsCheckbox.Depth = 0;
            this.RepairsCheckbox.Location = new System.Drawing.Point(1659, 41);
            this.RepairsCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.RepairsCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RepairsCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.RepairsCheckbox.Name = "RepairsCheckbox";
            this.RepairsCheckbox.ReadOnly = false;
            this.RepairsCheckbox.Ripple = true;
            this.RepairsCheckbox.Size = new System.Drawing.Size(88, 37);
            this.RepairsCheckbox.TabIndex = 9;
            this.RepairsCheckbox.Text = "Repairs";
            this.RepairsCheckbox.UseVisualStyleBackColor = true;
            // 
            // InstallationCheckbox
            // 
            this.InstallationCheckbox.AutoSize = true;
            this.InstallationCheckbox.Depth = 0;
            this.InstallationCheckbox.Location = new System.Drawing.Point(1500, 41);
            this.InstallationCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.InstallationCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.InstallationCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.InstallationCheckbox.Name = "InstallationCheckbox";
            this.InstallationCheckbox.ReadOnly = false;
            this.InstallationCheckbox.Ripple = true;
            this.InstallationCheckbox.Size = new System.Drawing.Size(114, 37);
            this.InstallationCheckbox.TabIndex = 8;
            this.InstallationCheckbox.Text = "Installation";
            this.InstallationCheckbox.UseVisualStyleBackColor = true;
            // 
            // maintanceCheckbox
            // 
            this.maintanceCheckbox.AutoSize = true;
            this.maintanceCheckbox.Depth = 0;
            this.maintanceCheckbox.Location = new System.Drawing.Point(1349, 41);
            this.maintanceCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.maintanceCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.maintanceCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.maintanceCheckbox.Name = "maintanceCheckbox";
            this.maintanceCheckbox.ReadOnly = false;
            this.maintanceCheckbox.Ripple = true;
            this.maintanceCheckbox.Size = new System.Drawing.Size(110, 37);
            this.maintanceCheckbox.TabIndex = 7;
            this.maintanceCheckbox.Text = "Maintance";
            this.maintanceCheckbox.UseVisualStyleBackColor = true;
            // 
            // Inspectioncheck
            // 
            this.Inspectioncheck.AutoSize = true;
            this.Inspectioncheck.Depth = 0;
            this.Inspectioncheck.Location = new System.Drawing.Point(1169, 41);
            this.Inspectioncheck.Margin = new System.Windows.Forms.Padding(0);
            this.Inspectioncheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Inspectioncheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.Inspectioncheck.Name = "Inspectioncheck";
            this.Inspectioncheck.ReadOnly = false;
            this.Inspectioncheck.Ripple = true;
            this.Inspectioncheck.Size = new System.Drawing.Size(108, 37);
            this.Inspectioncheck.TabIndex = 6;
            this.Inspectioncheck.Text = "Inspection";
            this.Inspectioncheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vehicle Number";
            // 
            // bunifuDatePicker1
            // 
            this.bunifuDatePicker1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDatePicker1.BorderRadius = 1;
            this.bunifuDatePicker1.Color = System.Drawing.Color.Silver;
            this.bunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.DisplayWeekNumbers = false;
            this.bunifuDatePicker1.DPHeight = 0;
            this.bunifuDatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker1.FillDatePicker = false;
            this.bunifuDatePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuDatePicker1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker1.Icon")));
            this.bunifuDatePicker1.IconColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker1.LeftTextMargin = 5;
            this.bunifuDatePicker1.Location = new System.Drawing.Point(903, 46);
            this.bunifuDatePicker1.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDatePicker1.Name = "bunifuDatePicker1";
            this.bunifuDatePicker1.Size = new System.Drawing.Size(220, 32);
            this.bunifuDatePicker1.TabIndex = 4;
            // 
            // ServiceBookingGridview
            // 
            this.ServiceBookingGridview.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.ServiceBookingGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ServiceBookingGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServiceBookingGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServiceBookingGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ServiceBookingGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceBookingGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ServiceBookingGridview.ColumnHeadersHeight = 40;
            this.ServiceBookingGridview.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.ServiceBookingGridview.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ServiceBookingGridview.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ServiceBookingGridview.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ServiceBookingGridview.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ServiceBookingGridview.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.ServiceBookingGridview.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ServiceBookingGridview.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.ServiceBookingGridview.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.ServiceBookingGridview.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ServiceBookingGridview.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.ServiceBookingGridview.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ServiceBookingGridview.CurrentTheme.Name = null;
            this.ServiceBookingGridview.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ServiceBookingGridview.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ServiceBookingGridview.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ServiceBookingGridview.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ServiceBookingGridview.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ServiceBookingGridview.DefaultCellStyle = dataGridViewCellStyle9;
            this.ServiceBookingGridview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ServiceBookingGridview.EnableHeadersVisualStyles = false;
            this.ServiceBookingGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ServiceBookingGridview.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.ServiceBookingGridview.HeaderBgColor = System.Drawing.Color.Empty;
            this.ServiceBookingGridview.HeaderForeColor = System.Drawing.Color.White;
            this.ServiceBookingGridview.Location = new System.Drawing.Point(0, 341);
            this.ServiceBookingGridview.Name = "ServiceBookingGridview";
            this.ServiceBookingGridview.RowHeadersVisible = false;
            this.ServiceBookingGridview.RowHeadersWidth = 51;
            this.ServiceBookingGridview.RowTemplate.Height = 40;
            this.ServiceBookingGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceBookingGridview.Size = new System.Drawing.Size(1910, 523);
            this.ServiceBookingGridview.TabIndex = 3;
            this.ServiceBookingGridview.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // VehicleID
            // 
            this.VehicleID.AutoSize = true;
            this.VehicleID.Depth = 0;
            this.VehicleID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VehicleID.Location = new System.Drawing.Point(620, 59);
            this.VehicleID.MouseState = MaterialSkin.MouseState.HOVER;
            this.VehicleID.Name = "VehicleID";
            this.VehicleID.Size = new System.Drawing.Size(107, 19);
            this.VehicleID.TabIndex = 2;
            this.VehicleID.Text = "materialLabel1";
            // 
            // Vehiclesearchbox1
            // 
            this.Vehiclesearchbox1.AllowCustomTheming = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.Vehiclesearchbox1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.Vehiclesearchbox1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Vehiclesearchbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Vehiclesearchbox1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Vehiclesearchbox1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Vehiclesearchbox1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.Vehiclesearchbox1.ColumnHeadersHeight = 40;
            this.Vehiclesearchbox1.ColumnHeadersVisible = false;
            this.Vehiclesearchbox1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.Vehiclesearchbox1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Vehiclesearchbox1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Vehiclesearchbox1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Vehiclesearchbox1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Vehiclesearchbox1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.Vehiclesearchbox1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Vehiclesearchbox1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.Vehiclesearchbox1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.Vehiclesearchbox1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Vehiclesearchbox1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.Vehiclesearchbox1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Vehiclesearchbox1.CurrentTheme.Name = null;
            this.Vehiclesearchbox1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Vehiclesearchbox1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Vehiclesearchbox1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Vehiclesearchbox1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Vehiclesearchbox1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Vehiclesearchbox1.DefaultCellStyle = dataGridViewCellStyle12;
            this.Vehiclesearchbox1.EnableHeadersVisualStyles = false;
            this.Vehiclesearchbox1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Vehiclesearchbox1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.Vehiclesearchbox1.HeaderBgColor = System.Drawing.Color.Empty;
            this.Vehiclesearchbox1.HeaderForeColor = System.Drawing.Color.White;
            this.Vehiclesearchbox1.Location = new System.Drawing.Point(40, 99);
            this.Vehiclesearchbox1.Name = "Vehiclesearchbox1";
            this.Vehiclesearchbox1.ReadOnly = true;
            this.Vehiclesearchbox1.RowHeadersVisible = false;
            this.Vehiclesearchbox1.RowHeadersWidth = 51;
            this.Vehiclesearchbox1.RowTemplate.Height = 40;
            this.Vehiclesearchbox1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Vehiclesearchbox1.Size = new System.Drawing.Size(435, 10);
            this.Vehiclesearchbox1.TabIndex = 1;
            this.Vehiclesearchbox1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.Vehiclesearchbox1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Vehiclesearchbox1_CellContentClick);
            // 
            // Vehiclesearchbox
            // 
            this.Vehiclesearchbox.AnimateReadOnly = false;
            this.Vehiclesearchbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Vehiclesearchbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Vehiclesearchbox.Depth = 0;
            this.Vehiclesearchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Vehiclesearchbox.HideSelection = true;
            this.Vehiclesearchbox.LeadingIcon = null;
            this.Vehiclesearchbox.Location = new System.Drawing.Point(40, 45);
            this.Vehiclesearchbox.MaxLength = 32767;
            this.Vehiclesearchbox.MouseState = MaterialSkin.MouseState.OUT;
            this.Vehiclesearchbox.Name = "Vehiclesearchbox";
            this.Vehiclesearchbox.PasswordChar = '\0';
            this.Vehiclesearchbox.PrefixSuffixText = null;
            this.Vehiclesearchbox.ReadOnly = false;
            this.Vehiclesearchbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Vehiclesearchbox.SelectedText = "";
            this.Vehiclesearchbox.SelectionLength = 0;
            this.Vehiclesearchbox.SelectionStart = 0;
            this.Vehiclesearchbox.ShortcutsEnabled = true;
            this.Vehiclesearchbox.Size = new System.Drawing.Size(435, 48);
            this.Vehiclesearchbox.TabIndex = 0;
            this.Vehiclesearchbox.TabStop = false;
            this.Vehiclesearchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Vehiclesearchbox.TrailingIcon = null;
            this.Vehiclesearchbox.UseSystemPasswordChar = false;
            this.Vehiclesearchbox.TextChanged += new System.EventHandler(this.Vehiclesearchbox_TextChanged);
            // 
            // SpareParts
            // 
            this.SpareParts.ImageKey = "icons8-rotating-parts-hazard-32.png";
            this.SpareParts.Location = new System.Drawing.Point(4, 39);
            this.SpareParts.Name = "SpareParts";
            this.SpareParts.Size = new System.Drawing.Size(1910, 864);
            this.SpareParts.TabIndex = 6;
            this.SpareParts.Text = "Spare Parts";
            this.SpareParts.UseVisualStyleBackColor = true;
            // 
            // Tools
            // 
            this.Tools.ImageKey = "icons8-tools-32.png";
            this.Tools.Location = new System.Drawing.Point(4, 39);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(1910, 864);
            this.Tools.TabIndex = 7;
            this.Tools.Text = "Tools";
            this.Tools.UseVisualStyleBackColor = true;
            // 
            // Request
            // 
            this.Request.ImageKey = "icons8-request-32.png";
            this.Request.Location = new System.Drawing.Point(4, 39);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(1910, 864);
            this.Request.TabIndex = 8;
            this.Request.Text = "Request ";
            this.Request.UseVisualStyleBackColor = true;
            // 
            // VehicleInspection
            // 
            this.VehicleInspection.ImageKey = "icons8-inspection-32.png";
            this.VehicleInspection.Location = new System.Drawing.Point(4, 39);
            this.VehicleInspection.Name = "VehicleInspection";
            this.VehicleInspection.Size = new System.Drawing.Size(1910, 864);
            this.VehicleInspection.TabIndex = 2;
            this.VehicleInspection.Text = " Vehicle Inspection";
            this.VehicleInspection.UseVisualStyleBackColor = true;
            // 
            // Maintenance
            // 
            this.Maintenance.ImageKey = "icons8-maintenance-32.png";
            this.Maintenance.Location = new System.Drawing.Point(4, 39);
            this.Maintenance.Name = "Maintenance";
            this.Maintenance.Size = new System.Drawing.Size(1910, 864);
            this.Maintenance.TabIndex = 3;
            this.Maintenance.Text = "Maintenance ";
            this.Maintenance.UseVisualStyleBackColor = true;
            // 
            // InstallationSetup
            // 
            this.InstallationSetup.ImageKey = "icons8-setup-32.png";
            this.InstallationSetup.Location = new System.Drawing.Point(4, 39);
            this.InstallationSetup.Name = "InstallationSetup";
            this.InstallationSetup.Size = new System.Drawing.Size(1910, 864);
            this.InstallationSetup.TabIndex = 9;
            this.InstallationSetup.Text = "Installation & Setup";
            this.InstallationSetup.UseVisualStyleBackColor = true;
            // 
            // Repairs
            // 
            this.Repairs.ImageKey = "icons8-repairs-32.png";
            this.Repairs.Location = new System.Drawing.Point(4, 39);
            this.Repairs.Name = "Repairs";
            this.Repairs.Size = new System.Drawing.Size(1910, 864);
            this.Repairs.TabIndex = 4;
            this.Repairs.Text = "Repairs";
            this.Repairs.UseVisualStyleBackColor = true;
            // 
            // VehicleWash
            // 
            this.VehicleWash.ImageKey = "icons8-car-wash-32.png";
            this.VehicleWash.Location = new System.Drawing.Point(4, 39);
            this.VehicleWash.Name = "VehicleWash";
            this.VehicleWash.Size = new System.Drawing.Size(1910, 864);
            this.VehicleWash.TabIndex = 10;
            this.VehicleWash.Text = "Vehicle Wash";
            this.VehicleWash.UseVisualStyleBackColor = true;
            // 
            // VehicleOwners
            // 
            this.VehicleOwners.ImageKey = "icons8-vehicle-insurance-32.png";
            this.VehicleOwners.Location = new System.Drawing.Point(4, 39);
            this.VehicleOwners.Name = "VehicleOwners";
            this.VehicleOwners.Size = new System.Drawing.Size(1910, 864);
            this.VehicleOwners.TabIndex = 11;
            this.VehicleOwners.Text = "Vehicle Owners";
            this.VehicleOwners.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-booking-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-progress-bar-32.png");
            this.imageList1.Images.SetKeyName(2, "icons8-vehicle-insurance-32.png");
            this.imageList1.Images.SetKeyName(3, "icons8-car-wash-32.png");
            this.imageList1.Images.SetKeyName(4, "icons8-repairs-32.png");
            this.imageList1.Images.SetKeyName(5, "icons8-setup-32.png");
            this.imageList1.Images.SetKeyName(6, "icons8-maintenance-32.png");
            this.imageList1.Images.SetKeyName(7, "icons8-inspection-32.png");
            this.imageList1.Images.SetKeyName(8, "icons8-request-32.png");
            this.imageList1.Images.SetKeyName(9, "icons8-service-32.png");
            this.imageList1.Images.SetKeyName(10, "icons8-home-32.png");
            this.imageList1.Images.SetKeyName(11, "icons8-rotating-parts-hazard-32.png");
            this.imageList1.Images.SetKeyName(12, "icons8-tools-32.png");
            // 
            // ServiceManeger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 974);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "ServiceManeger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ServiceManeger_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.ServiceBooking.ResumeLayout(false);
            this.ServiceBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBookingGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vehiclesearchbox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage ServiceProgress;
        private System.Windows.Forms.TabPage ServiceBooking;
        private System.Windows.Forms.TabPage SpareParts;
        private System.Windows.Forms.TabPage Tools;
        private System.Windows.Forms.TabPage Request;
        private System.Windows.Forms.TabPage VehicleInspection;
        private System.Windows.Forms.TabPage Maintenance;
        private System.Windows.Forms.TabPage InstallationSetup;
        private System.Windows.Forms.TabPage Repairs;
        private System.Windows.Forms.TabPage VehicleWash;
        private System.Windows.Forms.TabPage VehicleOwners;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTextBox2 Vehiclesearchbox;
        private Bunifu.UI.WinForms.BunifuDataGridView Vehiclesearchbox1;
        private MaterialSkin.Controls.MaterialLabel VehicleID;
        private Bunifu.UI.WinForms.BunifuDataGridView ServiceBookingGridview;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
        private MaterialSkin.Controls.MaterialCheckbox InstallationCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox maintanceCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox Inspectioncheck;
        private MaterialSkin.Controls.MaterialCheckbox washCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox RepairsCheckbox;
        private MaterialSkin.Controls.MaterialComboBox Statuscombo;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}