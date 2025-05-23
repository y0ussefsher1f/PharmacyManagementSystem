using PharmacyManagementSystem.Models;
using PharmacyManagementSystem.Services;
using System;
using System.Windows.Forms;

namespace PharmacyManagementSystem.Forms
{
    public partial class ReportsForm : Form
    {
        private readonly DataManager dataManager;

        public ReportsForm()
        {
            InitializeComponent();
            dataManager = new DataManager();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            try
            {
                var orders = dataManager.LoadOrders();
                var reportGenerator = new SalesReportGenerator(orders, dtpStartDate.Value, dtpEndDate.Value);
                txtReport.Text = reportGenerator.GenerateReport();
            }
            catch (Exception ex)
            {
                Metrics.IncrementException(ex);
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnStockReport_Click(object sender, EventArgs e)
        {
            try
            {
                var medicines = dataManager.LoadMedicines();
                var reportGenerator = new StockReportGenerator(medicines);
                txtReport.Text = reportGenerator.GenerateReport();
            }
            catch (Exception ex)
            {
                Metrics.IncrementException(ex);
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}