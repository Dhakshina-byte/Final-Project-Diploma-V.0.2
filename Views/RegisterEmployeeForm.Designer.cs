using Finalproject.Controllers;
using System.Windows.Forms;
using Finalproject.Models;

namespace Finalproject.Views
{
    public partial class RegisterEmployeeForm
    {


        private EmployeeController _employeeController;


        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            //_employeeController = new EmployeeController();
            //var employee = new Employee
            //{
            //    Email = txtEmail.Text,
            //    Mobile = txtMobile.Text,
            //    City = txtCity.Text,
            //    Address = txtAddress.Text,
            //    Role_ID = 1,
            //    Department_ID = 1
            //};
            //if (_employeeController.RegisterEmployee(employee))
            //{
            //    MessageBox.Show("Employee registered successfully");
            //}
            //else
            //{
            //    MessageBox.Show("Employee registration failed");
            //}
        }
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
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
            this.SuspendLayout();
            // 
            // RegisterEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "RegisterEmployeeForm";
            this.Text = "RegisterEmployeeForm";
            this.ResumeLayout(false);

        }

        #endregion
    }
}