namespace Finalproject.Views
{
    partial class ServiceHead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceHead));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.Employee = new System.Windows.Forms.TabPage();
            this.Empsavebtn = new MaterialSkin.Controls.MaterialButton();
            this.Empcancelbtn = new MaterialSkin.Controls.MaterialButton();
            this.ll = new System.Windows.Forms.Label();
            this.Dobdate = new System.Windows.Forms.DateTimePicker();
            this.Addressmultilinebox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.Address = new System.Windows.Forms.Label();
            this.EmpCitytxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpMobiletxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpEmailtxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpNametxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.EmpSearchtxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.EmpSearchbtn = new System.Windows.Forms.Button();
            this.ServiceBooking = new System.Windows.Forms.TabPage();
            this.CustomerComplain = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuDataGridView2 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.submitButton = new MaterialSkin.Controls.MaterialButton();
            this.customerNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.complaintTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTabControl1.SuspendLayout();
            this.Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.ServiceBooking.SuspendLayout();
            this.CustomerComplain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Home);
            this.materialTabControl1.Controls.Add(this.Employee);
            this.materialTabControl1.Controls.Add(this.ServiceBooking);
            this.materialTabControl1.Controls.Add(this.CustomerComplain);
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
            // Employee
            // 
            this.Employee.Controls.Add(this.Empsavebtn);
            this.Employee.Controls.Add(this.Empcancelbtn);
            this.Employee.Controls.Add(this.ll);
            this.Employee.Controls.Add(this.Dobdate);
            this.Employee.Controls.Add(this.Addressmultilinebox);
            this.Employee.Controls.Add(this.Address);
            this.Employee.Controls.Add(this.EmpCitytxtbox);
            this.Employee.Controls.Add(this.label4);
            this.Employee.Controls.Add(this.label3);
            this.Employee.Controls.Add(this.EmpMobiletxtbox);
            this.Employee.Controls.Add(this.label2);
            this.Employee.Controls.Add(this.EmpEmailtxtbox);
            this.Employee.Controls.Add(this.label1);
            this.Employee.Controls.Add(this.EmpNametxtbox);
            this.Employee.Controls.Add(this.EmpSearchtxtbox);
            this.Employee.Controls.Add(this.EmployeeDataGridView);
            this.Employee.Controls.Add(this.EmpSearchbtn);
            this.Employee.ImageKey = "icons8-employee-32.png";
            this.Employee.Location = new System.Drawing.Point(4, 39);
            this.Employee.Name = "Employee";
            this.Employee.Padding = new System.Windows.Forms.Padding(3);
            this.Employee.Size = new System.Drawing.Size(1928, 911);
            this.Employee.TabIndex = 1;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            // 
            // Empsavebtn
            // 
            this.Empsavebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Empsavebtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Empsavebtn.Depth = 0;
            this.Empsavebtn.HighEmphasis = true;
            this.Empsavebtn.Icon = null;
            this.Empsavebtn.Location = new System.Drawing.Point(1840, 843);
            this.Empsavebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Empsavebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Empsavebtn.Name = "Empsavebtn";
            this.Empsavebtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Empsavebtn.Size = new System.Drawing.Size(64, 36);
            this.Empsavebtn.TabIndex = 76;
            this.Empsavebtn.Text = "Save";
            this.Empsavebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Empsavebtn.UseAccentColor = false;
            this.Empsavebtn.UseVisualStyleBackColor = true;
            // 
            // Empcancelbtn
            // 
            this.Empcancelbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Empcancelbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Empcancelbtn.Depth = 0;
            this.Empcancelbtn.HighEmphasis = true;
            this.Empcancelbtn.Icon = null;
            this.Empcancelbtn.Location = new System.Drawing.Point(1519, 843);
            this.Empcancelbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Empcancelbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Empcancelbtn.Name = "Empcancelbtn";
            this.Empcancelbtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Empcancelbtn.Size = new System.Drawing.Size(77, 36);
            this.Empcancelbtn.TabIndex = 75;
            this.Empcancelbtn.Text = "Cancel";
            this.Empcancelbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Empcancelbtn.UseAccentColor = false;
            this.Empcancelbtn.UseVisualStyleBackColor = true;
            // 
            // ll
            // 
            this.ll.AutoSize = true;
            this.ll.Location = new System.Drawing.Point(1516, 707);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(79, 16);
            this.ll.TabIndex = 74;
            this.ll.Text = "Date of Birth";
            // 
            // Dobdate
            // 
            this.Dobdate.Location = new System.Drawing.Point(1519, 743);
            this.Dobdate.Name = "Dobdate";
            this.Dobdate.Size = new System.Drawing.Size(398, 22);
            this.Dobdate.TabIndex = 73;
            // 
            // Addressmultilinebox
            // 
            this.Addressmultilinebox.AnimateReadOnly = false;
            this.Addressmultilinebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Addressmultilinebox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Addressmultilinebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Addressmultilinebox.Depth = 0;
            this.Addressmultilinebox.HideSelection = true;
            this.Addressmultilinebox.Location = new System.Drawing.Point(1519, 554);
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
            this.Addressmultilinebox.TabIndex = 72;
            this.Addressmultilinebox.TabStop = false;
            this.Addressmultilinebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Addressmultilinebox.UseSystemPasswordChar = false;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(1519, 521);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(58, 16);
            this.Address.TabIndex = 71;
            this.Address.Text = "Address";
            // 
            // EmpCitytxtbox
            // 
            this.EmpCitytxtbox.AnimateReadOnly = false;
            this.EmpCitytxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpCitytxtbox.Depth = 0;
            this.EmpCitytxtbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmpCitytxtbox.LeadingIcon = null;
            this.EmpCitytxtbox.Location = new System.Drawing.Point(1519, 448);
            this.EmpCitytxtbox.MaxLength = 50;
            this.EmpCitytxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmpCitytxtbox.Multiline = false;
            this.EmpCitytxtbox.Name = "EmpCitytxtbox";
            this.EmpCitytxtbox.Size = new System.Drawing.Size(398, 50);
            this.EmpCitytxtbox.TabIndex = 70;
            this.EmpCitytxtbox.Text = "";
            this.EmpCitytxtbox.TrailingIcon = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1516, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1516, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Mobile Number";
            // 
            // EmpMobiletxtbox
            // 
            this.EmpMobiletxtbox.AnimateReadOnly = false;
            this.EmpMobiletxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpMobiletxtbox.Depth = 0;
            this.EmpMobiletxtbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmpMobiletxtbox.LeadingIcon = null;
            this.EmpMobiletxtbox.Location = new System.Drawing.Point(1519, 250);
            this.EmpMobiletxtbox.MaxLength = 50;
            this.EmpMobiletxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmpMobiletxtbox.Multiline = false;
            this.EmpMobiletxtbox.Name = "EmpMobiletxtbox";
            this.EmpMobiletxtbox.Size = new System.Drawing.Size(398, 50);
            this.EmpMobiletxtbox.TabIndex = 67;
            this.EmpMobiletxtbox.Text = "";
            this.EmpMobiletxtbox.TrailingIcon = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1516, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "Email";
            // 
            // EmpEmailtxtbox
            // 
            this.EmpEmailtxtbox.AnimateReadOnly = false;
            this.EmpEmailtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpEmailtxtbox.Depth = 0;
            this.EmpEmailtxtbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmpEmailtxtbox.LeadingIcon = null;
            this.EmpEmailtxtbox.Location = new System.Drawing.Point(1519, 150);
            this.EmpEmailtxtbox.MaxLength = 50;
            this.EmpEmailtxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmpEmailtxtbox.Multiline = false;
            this.EmpEmailtxtbox.Name = "EmpEmailtxtbox";
            this.EmpEmailtxtbox.Size = new System.Drawing.Size(398, 50);
            this.EmpEmailtxtbox.TabIndex = 65;
            this.EmpEmailtxtbox.Text = "";
            this.EmpEmailtxtbox.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1516, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Name";
            // 
            // EmpNametxtbox
            // 
            this.EmpNametxtbox.AnimateReadOnly = false;
            this.EmpNametxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpNametxtbox.Depth = 0;
            this.EmpNametxtbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmpNametxtbox.LeadingIcon = null;
            this.EmpNametxtbox.Location = new System.Drawing.Point(1519, 53);
            this.EmpNametxtbox.MaxLength = 50;
            this.EmpNametxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmpNametxtbox.Multiline = false;
            this.EmpNametxtbox.Name = "EmpNametxtbox";
            this.EmpNametxtbox.Size = new System.Drawing.Size(398, 50);
            this.EmpNametxtbox.TabIndex = 63;
            this.EmpNametxtbox.Text = "";
            this.EmpNametxtbox.TrailingIcon = null;
            // 
            // EmpSearchtxtbox
            // 
            this.EmpSearchtxtbox.AnimateReadOnly = false;
            this.EmpSearchtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpSearchtxtbox.Depth = 0;
            this.EmpSearchtxtbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmpSearchtxtbox.LeadingIcon = null;
            this.EmpSearchtxtbox.Location = new System.Drawing.Point(786, 11);
            this.EmpSearchtxtbox.MaxLength = 50;
            this.EmpSearchtxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmpSearchtxtbox.Multiline = false;
            this.EmpSearchtxtbox.Name = "EmpSearchtxtbox";
            this.EmpSearchtxtbox.Size = new System.Drawing.Size(525, 50);
            this.EmpSearchtxtbox.TabIndex = 61;
            this.EmpSearchtxtbox.Text = "";
            this.EmpSearchtxtbox.TrailingIcon = null;
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(11, 81);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.RowHeadersWidth = 51;
            this.EmployeeDataGridView.RowTemplate.Height = 24;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(1386, 818);
            this.EmployeeDataGridView.TabIndex = 60;
            // 
            // EmpSearchbtn
            // 
            this.EmpSearchbtn.Image = global::Finalproject.Properties.Resources.icons8_search_32;
            this.EmpSearchbtn.Location = new System.Drawing.Point(1336, 14);
            this.EmpSearchbtn.Name = "EmpSearchbtn";
            this.EmpSearchbtn.Size = new System.Drawing.Size(60, 48);
            this.EmpSearchbtn.TabIndex = 62;
            this.EmpSearchbtn.UseVisualStyleBackColor = true;
            // 
            // ServiceBooking
            // 
            this.ServiceBooking.Controls.Add(this.bunifuDataGridView1);
            this.ServiceBooking.ImageKey = "icons8-service-32.png";
            this.ServiceBooking.Location = new System.Drawing.Point(4, 39);
            this.ServiceBooking.Name = "ServiceBooking";
            this.ServiceBooking.Size = new System.Drawing.Size(1928, 911);
            this.ServiceBooking.TabIndex = 2;
            this.ServiceBooking.Text = "Service Booking";
            this.ServiceBooking.UseVisualStyleBackColor = true;
            // 
            // CustomerComplain
            // 
            this.CustomerComplain.Controls.Add(this.complaintTextBox);
            this.CustomerComplain.Controls.Add(this.customerNameTextBox);
            this.CustomerComplain.Controls.Add(this.submitButton);
            this.CustomerComplain.Controls.Add(this.bunifuDataGridView2);
            this.CustomerComplain.ImageKey = "icons8-complaint-32.png";
            this.CustomerComplain.Location = new System.Drawing.Point(4, 39);
            this.CustomerComplain.Name = "CustomerComplain";
            this.CustomerComplain.Size = new System.Drawing.Size(1928, 911);
            this.CustomerComplain.TabIndex = 3;
            this.CustomerComplain.Text = "Customer Complain";
            this.CustomerComplain.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-complaint-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-service-32.png");
            this.imageList1.Images.SetKeyName(2, "icons8-home-32.png");
            this.imageList1.Images.SetKeyName(3, "icons8-employee-32.png");
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.bunifuDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.bunifuDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowHeadersWidth = 51;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(1928, 911);
            this.bunifuDataGridView1.TabIndex = 0;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuDataGridView2
            // 
            this.bunifuDataGridView2.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.bunifuDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView2.DefaultCellStyle = dataGridViewCellStyle9;
            this.bunifuDataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuDataGridView2.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView2.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.Location = new System.Drawing.Point(0, 0);
            this.bunifuDataGridView2.Name = "bunifuDataGridView2";
            this.bunifuDataGridView2.RowHeadersVisible = false;
            this.bunifuDataGridView2.RowHeadersWidth = 51;
            this.bunifuDataGridView2.RowTemplate.Height = 40;
            this.bunifuDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView2.Size = new System.Drawing.Size(1265, 911);
            this.bunifuDataGridView2.TabIndex = 0;
            this.bunifuDataGridView2.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // submitButton
            // 
            this.submitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.submitButton.Depth = 0;
            this.submitButton.HighEmphasis = true;
            this.submitButton.Icon = null;
            this.submitButton.Location = new System.Drawing.Point(1709, 810);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitButton.Name = "submitButton";
            this.submitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.submitButton.Size = new System.Drawing.Size(75, 36);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "submit";
            this.submitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitButton.UseAccentColor = false;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click_1);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.AnimateReadOnly = false;
            this.customerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerNameTextBox.Depth = 0;
            this.customerNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customerNameTextBox.LeadingIcon = null;
            this.customerNameTextBox.Location = new System.Drawing.Point(1338, 71);
            this.customerNameTextBox.MaxLength = 50;
            this.customerNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.customerNameTextBox.Multiline = false;
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(551, 50);
            this.customerNameTextBox.TabIndex = 2;
            this.customerNameTextBox.Text = "";
            this.customerNameTextBox.TrailingIcon = null;
            // 
            // complaintTextBox
            // 
            this.complaintTextBox.AnimateReadOnly = false;
            this.complaintTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.complaintTextBox.Depth = 0;
            this.complaintTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.complaintTextBox.LeadingIcon = null;
            this.complaintTextBox.Location = new System.Drawing.Point(1338, 208);
            this.complaintTextBox.MaxLength = 50;
            this.complaintTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.complaintTextBox.Multiline = false;
            this.complaintTextBox.Name = "complaintTextBox";
            this.complaintTextBox.Size = new System.Drawing.Size(551, 50);
            this.complaintTextBox.TabIndex = 3;
            this.complaintTextBox.Text = "";
            this.complaintTextBox.TrailingIcon = null;
            // 
            // ServiceHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1021);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "ServiceHead";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Service_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.Employee.ResumeLayout(false);
            this.Employee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.ServiceBooking.ResumeLayout(false);
            this.CustomerComplain.ResumeLayout(false);
            this.CustomerComplain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Employee;
        private System.Windows.Forms.TabPage ServiceBooking;
        private System.Windows.Forms.TabPage CustomerComplain;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton Empsavebtn;
        private MaterialSkin.Controls.MaterialButton Empcancelbtn;
        private System.Windows.Forms.Label ll;
        private System.Windows.Forms.DateTimePicker Dobdate;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 Addressmultilinebox;
        private System.Windows.Forms.Label Address;
        private MaterialSkin.Controls.MaterialTextBox EmpCitytxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox EmpMobiletxtbox;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox EmpEmailtxtbox;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox EmpNametxtbox;
        private MaterialSkin.Controls.MaterialTextBox EmpSearchtxtbox;
        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private System.Windows.Forms.Button EmpSearchbtn;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView2;
        private MaterialSkin.Controls.MaterialButton submitButton;
        private MaterialSkin.Controls.MaterialTextBox complaintTextBox;
        private MaterialSkin.Controls.MaterialTextBox customerNameTextBox;
    }
}