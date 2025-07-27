using System;
using System.Linq;
using System.Windows.Forms;
using JUSTPayroll.Models;
using JUSTPayroll.DB;

namespace JUSTPayroll.Forms
{
    public partial class ShowSalaryRecordForm : Form
    {
        private string selectedMonth = string.Empty;

        public ShowSalaryRecordForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            try
            {
                // Get current month as default
                selectedMonth = DateTime.Now.ToString("MMMM");

                // Populate month dropdown with available months
                var availableMonths = SalaryRepository.GetAvailableMonths();
                cmbMonth.Items.Clear();
                
                if (availableMonths.Any())
                {
                    cmbMonth.Items.AddRange(availableMonths.ToArray());
                    
                    // Try to select current month, otherwise select first available
                    var currentMonthIndex = availableMonths.FindIndex(m => 
                        m.Equals(selectedMonth, StringComparison.OrdinalIgnoreCase));
                    
                    if (currentMonthIndex >= 0)
                    {
                        cmbMonth.SelectedIndex = currentMonthIndex;
                    }
                    else
                    {
                        cmbMonth.SelectedIndex = 0;
                        selectedMonth = availableMonths[0];
                    }
                }
                else
                {
                    // If no salary files exist, add standard months
                    string[] standardMonths = { "January", "February", "March", "April", "May", "June",
                                               "July", "August", "September", "October", "November", "December" };
                    cmbMonth.Items.AddRange(standardMonths);
                    
                    var currentMonthIndex = Array.FindIndex(standardMonths, m => 
                        m.Equals(selectedMonth, StringComparison.OrdinalIgnoreCase));
                    
                    if (currentMonthIndex >= 0)
                    {
                        cmbMonth.SelectedIndex = currentMonthIndex;
                    }
                    else
                    {
                        cmbMonth.SelectedIndex = 0;
                        selectedMonth = standardMonths[0];
                    }
                }

                // Setup ListView columns
                SetupListView();
                
                // Load initial data
                LoadSalaryRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}", "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupListView()
        {
            listViewSalaries.View = View.Details;
            listViewSalaries.FullRowSelect = true;
            listViewSalaries.GridLines = true;
            
            listViewSalaries.Columns.Clear();
            listViewSalaries.Columns.Add("Employee ID", 100);
            listViewSalaries.Columns.Add("Name", 150);
            listViewSalaries.Columns.Add("Base Salary", 100);
            listViewSalaries.Columns.Add("Increment", 100);
            listViewSalaries.Columns.Add("Decrement", 100);
            listViewSalaries.Columns.Add("Bonus", 100);
            listViewSalaries.Columns.Add("Total Salary", 120);
            listViewSalaries.Columns.Add("Processed Date", 150);
        }

        private void LoadSalaryRecords()
        {
            try
            {
                listViewSalaries.Items.Clear();
                
                if (string.IsNullOrEmpty(selectedMonth))
                {
                    lblTotalCount.Text = "Total Records: 0";
                    lblTotalAmount.Text = "Total Amount: 0.00";
                    return;
                }

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
                
                lblTotalCount.Text = "Total Records: 0";
                lblTotalAmount.Text = "Total Amount: 0.00";
            }
        }

        private void CmbMonth_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbMonth.SelectedItem != null)
            {
                selectedMonth = cmbMonth.SelectedItem.ToString() ?? "";
                LoadSalaryRecords();
            }
        }

        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            LoadSalaryRecords();
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
