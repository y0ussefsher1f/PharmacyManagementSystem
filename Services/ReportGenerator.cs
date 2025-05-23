using System;
using System.Collections.Generic;
using PharmacyManagementSystem.Models;

namespace PharmacyManagementSystem.Services
{
    // Abstract base class
    public abstract class ReportGenerator
    {
        public abstract string GenerateReport();
    }

    // Sales report generator
    public class SalesReportGenerator : ReportGenerator
    {
        private readonly List<Order> orders;
        private readonly DateTime start;
        private readonly DateTime end;

        public SalesReportGenerator(List<Order> orders, DateTime start, DateTime end)
        {
            this.orders = orders;
            this.start = start;
            this.end = end;
        }

        public override string GenerateReport()
        {
            List<Order> filteredOrders = new List<Order>();
            foreach (var order in orders)
            {
                if (order.OrderDate >= start && order.OrderDate <= end)
                {
                    filteredOrders.Add(order);
                }
            }
            decimal totalSales = 0;
            foreach (var order in filteredOrders)
            {
                totalSales += order.TotalAmount;
            }
            string report = $"Sales Report ({start:MM/dd/yyyy} to {end:MM/dd/yyyy}){Environment.NewLine}";
            report += $"Total Orders: {filteredOrders.Count}{Environment.NewLine}Total Sales: {totalSales:C}{Environment.NewLine}{Environment.NewLine}Details:{Environment.NewLine}";
            foreach (var order in filteredOrders)
            {
                report += $"Order ID: {order.OrderID}, Customer: {order.Customer.Name}, Amount: {order.TotalAmount:C}, Date: {order.OrderDate:MM/dd/yyyy}{Environment.NewLine}";
            }
            return report;
        }
    }

    // Stock report generator
    public class StockReportGenerator : ReportGenerator
    {
        private readonly List<Medicine> medicines;

        public StockReportGenerator(List<Medicine> medicines)
        {
            this.medicines = medicines;
        }

        public override string GenerateReport()
        {
            string report = $"Stock Report{Environment.NewLine}";
            foreach (var medicine in medicines)
            {
                report += $"{medicine.ToString()}{Environment.NewLine}";
            }
            return report;
        }
    }
}