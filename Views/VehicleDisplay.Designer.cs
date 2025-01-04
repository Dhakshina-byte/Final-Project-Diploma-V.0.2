namespace Finalproject.Views
{
    partial class VehicleDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Vehiclepic = new System.Windows.Forms.PictureBox();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.Sub = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vehiclepic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Vehiclepic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 150);
            this.panel1.TabIndex = 0;
            // 
            // Vehiclepic
            // 
            this.Vehiclepic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vehiclepic.Location = new System.Drawing.Point(0, 0);
            this.Vehiclepic.Name = "Vehiclepic";
            this.Vehiclepic.Size = new System.Drawing.Size(250, 150);
            this.Vehiclepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Vehiclepic.TabIndex = 0;
            this.Vehiclepic.TabStop = false;
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.Location = new System.Drawing.Point(281, 23);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(41, 20);
            this.Titlelbl.TabIndex = 1;
            this.Titlelbl.Text = "Title";
            // 
            // Sub
            // 
            this.Sub.AutoSize = true;
            this.Sub.Location = new System.Drawing.Point(282, 63);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(31, 16);
            this.Sub.TabIndex = 2;
            this.Sub.Text = "Sub";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(250, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 10);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // VehicleDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Titlelbl);
            this.Controls.Add(this.panel1);
            this.Name = "VehicleDisplay";
            this.Size = new System.Drawing.Size(1092, 150);
            this.Load += new System.EventHandler(this.VehicleDisplay_Load);
            this.Click += new System.EventHandler(this.VehicleDisplay_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Vehiclepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Vehiclepic;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Label Sub;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
