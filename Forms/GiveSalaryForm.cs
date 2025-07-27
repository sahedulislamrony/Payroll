using System;
using System.Windows.Forms;
using JUSTPayroll.Models;
using JUSTPayroll.DB;

namespace JUSTPayroll.Forms
{
    public partial class GiveSalaryForm : Form
    {
        private Teacher? selectedTeacher;

        public GiveSalaryForm()
        {
            InitializeComponent();
        }

        private void RbSpecific_CheckedChanged(object? sender, EventArgs e)
        {
            txtSearch.Enabled = rbSpecific.Checked;
            btnSearch.Enabled = rbSpecific.Checked;
            if (!rbSpecific.Checked)
            {
                lblSearchResult.Text = "";
                selectedTeacher = null;
            }
        }

        private void RbAll_CheckedChanged(object? sender, EventArgs e)
        {
            if (rbAll.Checked)
            {
                lblSearchResult.Text = "";
                selectedTeacher = null;
            }
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("Please enter a name or employee ID to search.", "Validation Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string searchTerm = txtSearch.Text.Trim();

                // Try to find by employee ID first
                selectedTeacher = EmployeeRepository.FindEmployeeById(searchTerm);

                // If not found by ID, try by name
                if (selectedTeacher == null)
                {
                    selectedTeacher = EmployeeRepository.FindEmployeeByName(searchTerm);
                }

                if (selectedTeacher != null)
                {
                    lblSearchResult.Text = $"Found:\nName: {selectedTeacher.Name}\nID: {selectedTeacher.EmployeeId}\nDept: {selectedTeacher.Department}";
                    lblSearchResult.ForeColor = System.Drawing.Color.DarkGreen;
                }
                else
                {
                    lblSearchResult.Text = "No teacher found with the given search criteria.";
                    lblSearchResult.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for teacher: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProceed_Click(object? sender, EventArgs e)
        {
            try
            {
                if (rbSpecific.Checked)
                {
                    if (selectedTeacher == null)
                    {
                        MessageBox.Show("Please search and select a teacher first.", "Validation Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Open salary input form for specific teacher
                    SalaryInputForm salaryForm = new SalaryInputForm(selectedTeacher);
                    salaryForm.ShowDialog();
                }
                else if (rbAll.Checked)
                {
                    var teachers = EmployeeRepository.GetAllEmployees();
                    if (teachers.Count == 0)
                    {
                        MessageBox.Show("No teachers found in the database.", "Information",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Open salary input form for all teachers
                    SalaryInputForm salaryForm = new SalaryInputForm(teachers);
                    salaryForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select an option.", "Validation Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error proceeding with salary: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

    }
}
