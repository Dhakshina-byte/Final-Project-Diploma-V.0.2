namespace Finalproject.Views
{
    partial class SalesDirector
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesDirector));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.Employees = new System.Windows.Forms.TabPage();
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
            this.Target = new System.Windows.Forms.TabPage();
            this.lblResult = new MaterialSkin.Controls.MaterialLabel();
            this.Savebin = new MaterialSkin.Controls.MaterialButton();
            this.Calculatebtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SalesTargettxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.ActualSalestxtbox = new MaterialSkin.Controls.MaterialTextBox();
            this.Reports = new System.Windows.Forms.TabPage();
            this.CustomerPurchase = new System.Windows.Forms.TabPage();
            this.CustomerPurchaseHistoryGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.EmpRolebox = new MaterialSkin.Controls.MaterialComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpRoleCombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTabControl1.SuspendLayout();
            this.Employees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.Target.SuspendLayout();
            this.CustomerPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPurchaseHistoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Home);
            this.materialTabControl1.Controls.Add(this.Employees);
            this.materialTabControl1.Controls.Add(this.Target);
            this.materialTabControl1.Controls.Add(this.Reports);
            this.materialTabControl1.Controls.Add(this.CustomerPurchase);
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
            this.Employees.Controls.Add(this.EmpSearchtxtbox);
            this.Employees.Controls.Add(this.EmployeeDataGridView);
            this.Employees.Controls.Add(this.EmpSearchbtn);
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
            this.Empsavebtn.TabIndex = 39;
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
            this.Empcancelbtn.TabIndex = 38;
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
            this.ll.TabIndex = 37;
            this.ll.Text = "Date of Birth";
            // 
            // Dobdate
            // 
            this.Dobdate.Location = new System.Drawing.Point(1519, 743);
            this.Dobdate.Name = "Dobdate";
            this.Dobdate.Size = new System.Drawing.Size(398, 22);
            this.Dobdate.TabIndex = 36;
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
            this.Addressmultilinebox.TabIndex = 35;
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
            this.Address.TabIndex = 34;
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
            this.EmpCitytxtbox.TabIndex = 31;
            this.EmpCitytxtbox.Text = "";
            this.EmpCitytxtbox.TrailingIcon = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1516, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1516, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 29;
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
            this.EmpMobiletxtbox.TabIndex = 28;
            this.EmpMobiletxtbox.Text = "";
            this.EmpMobiletxtbox.TrailingIcon = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1516, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 27;
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
            this.EmpEmailtxtbox.TabIndex = 26;
            this.EmpEmailtxtbox.Text = "";
            this.EmpEmailtxtbox.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1516, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 25;
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
            this.EmpNametxtbox.TabIndex = 24;
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
            this.EmpSearchtxtbox.TabIndex = 21;
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
            this.EmployeeDataGridView.TabIndex = 20;
            // 
            // EmpSearchbtn
            // 
            this.EmpSearchbtn.Image = global::Finalproject.Properties.Resources.icons8_search_32;
            this.EmpSearchbtn.Location = new System.Drawing.Point(1336, 14);
            this.EmpSearchbtn.Name = "EmpSearchbtn";
            this.EmpSearchbtn.Size = new System.Drawing.Size(60, 48);
            this.EmpSearchbtn.TabIndex = 22;
            this.EmpSearchbtn.UseVisualStyleBackColor = true;
            // 
            // Target
            // 
            this.Target.Controls.Add(this.lblResult);
            this.Target.Controls.Add(this.Savebin);
            this.Target.Controls.Add(this.Calculatebtn);
            this.Target.Controls.Add(this.materialLabel2);
            this.Target.Controls.Add(this.materialLabel1);
            this.Target.Controls.Add(this.SalesTargettxtbox);
            this.Target.Controls.Add(this.ActualSalestxtbox);
            this.Target.ImageKey = "icons8-target-35.png";
            this.Target.Location = new System.Drawing.Point(4, 39);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(1928, 911);
            this.Target.TabIndex = 2;
            this.Target.Text = "Target";
            this.Target.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Depth = 0;
            this.lblResult.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblResult.Location = new System.Drawing.Point(1594, 592);
            this.lblResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(283, 19);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "please press Calculate to dispaly results";
            // 
            // Savebin
            // 
            this.Savebin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Savebin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Savebin.Depth = 0;
            this.Savebin.HighEmphasis = true;
            this.Savebin.Icon = null;
            this.Savebin.Location = new System.Drawing.Point(1686, 744);
            this.Savebin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Savebin.MouseState = MaterialSkin.MouseState.HOVER;
            this.Savebin.Name = "Savebin";
            this.Savebin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Savebin.Size = new System.Drawing.Size(64, 36);
            this.Savebin.TabIndex = 7;
            this.Savebin.Text = "Save";
            this.Savebin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Savebin.UseAccentColor = false;
            this.Savebin.UseVisualStyleBackColor = true;
            this.Savebin.Click += new System.EventHandler(this.Savebin_Click);
            // 
            // Calculatebtn
            // 
            this.Calculatebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Calculatebtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Calculatebtn.Depth = 0;
            this.Calculatebtn.HighEmphasis = true;
            this.Calculatebtn.Icon = null;
            this.Calculatebtn.Location = new System.Drawing.Point(1665, 404);
            this.Calculatebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Calculatebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Calculatebtn.Name = "Calculatebtn";
            this.Calculatebtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Calculatebtn.Size = new System.Drawing.Size(103, 36);
            this.Calculatebtn.TabIndex = 4;
            this.Calculatebtn.Text = "Calculate";
            this.Calculatebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Calculatebtn.UseAccentColor = false;
            this.Calculatebtn.UseVisualStyleBackColor = true;
            this.Calculatebtn.Click += new System.EventHandler(this.Calculatebtn_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(1383, 322);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(90, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Sales Target";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(1384, 209);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Actual Sales";
            // 
            // SalesTargettxtbox
            // 
            this.SalesTargettxtbox.AnimateReadOnly = false;
            this.SalesTargettxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalesTargettxtbox.Depth = 0;
            this.SalesTargettxtbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SalesTargettxtbox.LeadingIcon = null;
            this.SalesTargettxtbox.Location = new System.Drawing.Point(1575, 305);
            this.SalesTargettxtbox.MaxLength = 50;
            this.SalesTargettxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.SalesTargettxtbox.Multiline = false;
            this.SalesTargettxtbox.Name = "SalesTargettxtbox";
            this.SalesTargettxtbox.Size = new System.Drawing.Size(326, 50);
            this.SalesTargettxtbox.TabIndex = 1;
            this.SalesTargettxtbox.Text = "";
            this.SalesTargettxtbox.TrailingIcon = null;
            // 
            // ActualSalestxtbox
            // 
            this.ActualSalestxtbox.AnimateReadOnly = false;
            this.ActualSalestxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ActualSalestxtbox.Depth = 0;
            this.ActualSalestxtbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ActualSalestxtbox.LeadingIcon = null;
            this.ActualSalestxtbox.Location = new System.Drawing.Point(1575, 192);
            this.ActualSalestxtbox.MaxLength = 50;
            this.ActualSalestxtbox.MouseState = MaterialSkin.MouseState.OUT;
            this.ActualSalestxtbox.Multiline = false;
            this.ActualSalestxtbox.Name = "ActualSalestxtbox";
            this.ActualSalestxtbox.Size = new System.Drawing.Size(326, 50);
            this.ActualSalestxtbox.TabIndex = 0;
            this.ActualSalestxtbox.Text = "";
            this.ActualSalestxtbox.TrailingIcon = null;
            // 
            // Reports
            // 
            this.Reports.ImageKey = "icons8-reports-32.png";
            this.Reports.Location = new System.Drawing.Point(4, 39);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(1928, 911);
            this.Reports.TabIndex = 3;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // CustomerPurchase
            // 
            this.CustomerPurchase.Controls.Add(this.CustomerPurchaseHistoryGrid);
            this.CustomerPurchase.ImageKey = "icons8-activity-history-32.png";
            this.CustomerPurchase.Location = new System.Drawing.Point(4, 39);
            this.CustomerPurchase.Name = "CustomerPurchase";
            this.CustomerPurchase.Size = new System.Drawing.Size(1928, 911);
            this.CustomerPurchase.TabIndex = 4;
            this.CustomerPurchase.Text = "Customer Purchase History";
            this.CustomerPurchase.UseVisualStyleBackColor = true;
            // 
            // CustomerPurchaseHistoryGrid
            // 
            this.CustomerPurchaseHistoryGrid.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.CustomerPurchaseHistoryGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CustomerPurchaseHistoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerPurchaseHistoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerPurchaseHistoryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerPurchaseHistoryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerPurchaseHistoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CustomerPurchaseHistoryGrid.ColumnHeadersHeight = 40;
            this.CustomerPurchaseHistoryGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.CustomerPurchaseHistoryGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.CustomerPurchaseHistoryGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.CustomerPurchaseHistoryGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.CustomerPurchaseHistoryGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerPurchaseHistoryGrid.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.CustomerPurchaseHistoryGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.CustomerPurchaseHistoryGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.CustomerPurchaseHistoryGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.CustomerPurchaseHistoryGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerPurchaseHistoryGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.CustomerPurchaseHistoryGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CustomerPurchaseHistoryGrid.CurrentTheme.Name = null;
            this.CustomerPurchaseHistoryGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerPurchaseHistoryGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.CustomerPurchaseHistoryGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.CustomerPurchaseHistoryGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.CustomerPurchaseHistoryGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerPurchaseHistoryGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.CustomerPurchaseHistoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerPurchaseHistoryGrid.EnableHeadersVisualStyles = false;
            this.CustomerPurchaseHistoryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.CustomerPurchaseHistoryGrid.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.CustomerPurchaseHistoryGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.CustomerPurchaseHistoryGrid.HeaderForeColor = System.Drawing.Color.White;
            this.CustomerPurchaseHistoryGrid.Location = new System.Drawing.Point(0, 0);
            this.CustomerPurchaseHistoryGrid.Name = "CustomerPurchaseHistoryGrid";
            this.CustomerPurchaseHistoryGrid.RowHeadersVisible = false;
            this.CustomerPurchaseHistoryGrid.RowHeadersWidth = 51;
            this.CustomerPurchaseHistoryGrid.RowTemplate.Height = 40;
            this.CustomerPurchaseHistoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerPurchaseHistoryGrid.Size = new System.Drawing.Size(1928, 911);
            this.CustomerPurchaseHistoryGrid.TabIndex = 0;
            this.CustomerPurchaseHistoryGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-reports-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-budget-35.png");
            this.imageList1.Images.SetKeyName(2, "icons8-home-32.png");
            this.imageList1.Images.SetKeyName(3, "icons8-employee-32.png");
            this.imageList1.Images.SetKeyName(4, "icons8-target-35.png");
            this.imageList1.Images.SetKeyName(5, "icons8-activity-history-32.png");
            this.imageList1.Images.SetKeyName(6, "icons8-reports-32.png");
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
            "Sales General Manager"});
            this.EmpRolebox.Location = new System.Drawing.Point(1519, 350);
            this.EmpRolebox.MaxDropDownItems = 4;
            this.EmpRolebox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmpRolebox.Name = "EmpRolebox";
            this.EmpRolebox.Size = new System.Drawing.Size(398, 49);
            this.EmpRolebox.StartIndex = 0;
            this.EmpRolebox.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1516, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Role";
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
            this.EmpRoleCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.EmpRoleCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EmpRoleCombobox.FormattingEnabled = true;
            this.EmpRoleCombobox.IntegralHeight = false;
            this.EmpRoleCombobox.ItemHeight = 43;
            this.EmpRoleCombobox.Items.AddRange(new object[] {
            "Sales Manager",
            "Sales General Manager"});
            this.EmpRoleCombobox.Location = new System.Drawing.Point(40, 14);
            this.EmpRoleCombobox.MaxDropDownItems = 4;
            this.EmpRoleCombobox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmpRoleCombobox.Name = "EmpRoleCombobox";
            this.EmpRoleCombobox.Size = new System.Drawing.Size(295, 49);
            this.EmpRoleCombobox.StartIndex = 0;
            this.EmpRoleCombobox.TabIndex = 23;
            // 
            // SalesDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1021);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "SalesDirector";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SalesDirector_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.Employees.ResumeLayout(false);
            this.Employees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.Target.ResumeLayout(false);
            this.Target.PerformLayout();
            this.CustomerPurchase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPurchaseHistoryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Employees;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage Target;
        private System.Windows.Forms.TabPage Reports;
        private System.Windows.Forms.TabPage CustomerPurchase;
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
        private Bunifu.UI.WinForms.BunifuDataGridView CustomerPurchaseHistoryGrid;
        private MaterialSkin.Controls.MaterialButton Calculatebtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox SalesTargettxtbox;
        private MaterialSkin.Controls.MaterialTextBox ActualSalestxtbox;
        private MaterialSkin.Controls.MaterialButton Savebin;
        private MaterialSkin.Controls.MaterialLabel lblResult;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialComboBox EmpRolebox;
        private MaterialSkin.Controls.MaterialComboBox EmpRoleCombobox;
    }
}