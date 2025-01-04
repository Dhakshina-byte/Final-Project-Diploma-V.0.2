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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.Employee = new System.Windows.Forms.TabPage();
            this.ServiceBooking = new System.Windows.Forms.TabPage();
            this.CustomerComplain = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.materialTabControl1.SuspendLayout();
            this.Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
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
            this.Home.Size = new System.Drawing.Size(1910, 864);
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
            // ServiceBooking
            // 
            this.ServiceBooking.ImageKey = "icons8-service-32.png";
            this.ServiceBooking.Location = new System.Drawing.Point(4, 39);
            this.ServiceBooking.Name = "ServiceBooking";
            this.ServiceBooking.Size = new System.Drawing.Size(1910, 864);
            this.ServiceBooking.TabIndex = 2;
            this.ServiceBooking.Text = "Service Booking";
            this.ServiceBooking.UseVisualStyleBackColor = true;
            // 
            // CustomerComplain
            // 
            this.CustomerComplain.ImageKey = "icons8-complaint-32.png";
            this.CustomerComplain.Location = new System.Drawing.Point(4, 39);
            this.CustomerComplain.Name = "CustomerComplain";
            this.CustomerComplain.Size = new System.Drawing.Size(1910, 864);
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
            this.EmpCitytxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.EmpMobiletxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.EmpEmailtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.EmpNametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.EmpSearchtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
    }
}