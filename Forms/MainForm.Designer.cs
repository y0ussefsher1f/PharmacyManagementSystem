namespace PharmacyManagementSystem.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnManageMedicines;
        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnProcessSales;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnManageMedicines = new System.Windows.Forms.Button();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnProcessSales = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageMedicines
            // 
            this.btnManageMedicines.Location = new System.Drawing.Point(67, 62);
            this.btnManageMedicines.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageMedicines.Name = "btnManageMedicines";
            this.btnManageMedicines.Size = new System.Drawing.Size(200, 37);
            this.btnManageMedicines.TabIndex = 0;
            this.btnManageMedicines.Text = "Manage Medicines";
            this.btnManageMedicines.UseVisualStyleBackColor = true;
            this.btnManageMedicines.Click += new System.EventHandler(this.btnManageMedicines_Click);
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.Location = new System.Drawing.Point(67, 123);
            this.btnManageCustomers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(200, 37);
            this.btnManageCustomers.TabIndex = 1;
            this.btnManageCustomers.Text = "Manage Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = true;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnProcessSales
            // 
            this.btnProcessSales.Location = new System.Drawing.Point(67, 185);
            this.btnProcessSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProcessSales.Name = "btnProcessSales";
            this.btnProcessSales.Size = new System.Drawing.Size(200, 37);
            this.btnProcessSales.TabIndex = 2;
            this.btnProcessSales.Text = "Process Sales";
            this.btnProcessSales.UseVisualStyleBackColor = true;
            this.btnProcessSales.Click += new System.EventHandler(this.btnProcessSales_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(67, 246);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(200, 37);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "View Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(67, 307);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 37);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(67, 367);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit and Show Metrics";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnProcessSales);
            this.Controls.Add(this.btnManageCustomers);
            this.Controls.Add(this.btnManageMedicines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy Management System - Dashboard";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnExit;
    }
}