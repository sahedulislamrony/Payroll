using System;
using System.Windows.Forms;
using JUSTPayroll.Models;
using JUSTPayroll.DB;

namespace JUSTPayroll.Forms
{
    public partial class ShowSalariesForm : Form
    {
        private string selectedMonth;

        public ShowSalariesForm(string month)
        {
            selectedMonth = month;
            InitializeComponent();
            
            // Add months
            string[] months = { "January", "February", "March", "April", "May", "June",
                               "July", "August", "September", "October", "November", "December" };
            cmbMonth.Items.AddRange(months);
            
            // Set selected month
            for (int i = 0; i < months.Length; i++)
            {
                if (months[i].Equals(selectedMonth, StringComparison.OrdinalIgnoreCase))
                {
                    cmbMonth.SelectedIndex = i;
                    break;
                }
            }
            
            // Add columns
            listViewSalaries.Columns.Add("Employee ID", 100);
            listViewSalaries.Columns.Add("Name", 150);
            listViewSalaries.Columns.Add("Base Salary", 100);
            listViewSalaries.Columns.Add("Increment", 100);
            listViewSalaries.Columns.Add("Decrement", 100);
            listViewSalaries.Columns.Add("Bonus", 100);
            listViewSalaries.Columns.Add("Total Salary", 120);
            listViewSalaries.Columns.Add("Month", 100);
            listViewSalaries.Columns.Add("Processed Date", 150);
            
            LoadSalaries();
        }

        private void LoadSalaries()
        {
            try
            {
                listViewSalaries.Items.Clear();
                var salaries = SalaryRepository.GetSalariesByMonth(selectedMonth);

                decimal totalAmount = 0;

                foreach (var salary in salaries)
                {
                    ListViewItem item = new ListViewItem(salary.EmployeeId);
                    item.SubItems.Add(salary.EmployeeName);
                    item.SubItems.Add(salary.BaseSalary.ToString("F2"));
                    item.SubItems.Add(salary.Increment.ToString("F2"));
                    item.SubItems.Add(salary.Decrement.ToString("F2"));
                    item.SubItems.Add(salary.Bonus.ToString("F2"));
                    item.SubItems.Add(salary.TotalSalary.ToString("F2"));
                    item.SubItems.Add(salary.Month);
                    item.SubItems.Add(salary.ProcessedDate.ToString("dd/MM/yyyy HH:mm"));

                    totalAmount += salary.TotalSalary;
                    listViewSalaries.Items.Add(item);
                }

                lblTotalCount.Text = $"Total Records: {salaries.Count}";
                lblTotalAmount.Text = $"Total Amount: {totalAmount:F2}";

                if (salaries.Count == 0)
                {
                    MessageBox.Show($"No salary records found for {selectedMonth}.", "Information", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading salary records: {ex.Message}", "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbMonth_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbMonth.SelectedItem != null)
            {
                selectedMonth = cmbMonth.SelectedItem.ToString() ?? "";
            }
        }

        private void BtnChangeMonth_Click(object? sender, EventArgs e)
        {
            if (cmbMonth.SelectedItem != null)
            {
                selectedMonth = cmbMonth.SelectedItem.ToString() ?? "";
                LoadSalaries();
            }
            else
            {
                MessageBox.Show("Please select a month.", "Validation Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            LoadSalaries();
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
