using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PharmacyManagementSystem.Models;

namespace PharmacyManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        private Staff staff;


        public LoginForm()
        {
            InitializeComponent();
            staff = new Staff("", "");



            // Hardcoded staff for demo (in practice, load from file or database)
            //staff = new List<Staff>
            //{
            //    new Staff(1, "Admin", "Admin", "admin", "password123")

            //};
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();


            if (staff.Username == username && staff.Password == password)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid username or password.";
                lblError.Visible = true;
            }
        }
    }
}