using PharmacyManagementSystem.Models;
using System;
using System.Windows.Forms;

namespace PharmacyManagementSystem.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnManageMedicines_Click(object sender, EventArgs e)
        {
            MedicineManagementForm medicineForm = new MedicineManagementForm();
            medicineForm.ShowDialog();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            CustomerManagementForm customerForm = new CustomerManagementForm();
            customerForm.ShowDialog();
        }

        private void btnProcessSales_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();
            salesForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Metrics.Stopwatch.Stop();
            Metrics.UpdateMemoryUsage();
            string formattedTime = Metrics.Stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            string exceptionDetails = string.Join(Environment.NewLine, Metrics.ExceptionLog);
            MessageBox.Show(
                $"Exceptions: {Metrics.ExceptionCount}\n" +
                $"Execution Time: {formattedTime}\n" +
                $"Memory Usage: {Metrics.MemoryUsage / 1024} KB\n\n" +
                $"Exception Log:\n{exceptionDetails}",
                "Program Metrics"
            );
            Application.Exit();
        }
    }
}