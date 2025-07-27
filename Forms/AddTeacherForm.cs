using JUSTPayroll.DB;
using JUSTPayroll.Models;
using System;
using System.Text;
using System.Windows.Forms;

namespace JUSTPayroll.Forms
{
    public partial class AddTeacherForm : Form
    {
        public AddTeacherForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Please enter teacher's name.", "Validation Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDepartment.Text))
                {
                    MessageBox.Show("Please enter department.", "Validation Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDepartment.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDesignation.Text))
                {
                    MessageBox.Show("Please enter designation.", "Validation Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDesignation.Focus();
                    return;
                }

                // Create new teacher
                Teacher newTeacher = new Teacher(
                    txtName.Text.Trim(),
                    txtDepartment.Text.Trim(),
                    txtDesignation.Text.Trim(),
                    txtCurrentAddress.Text.Trim(),
                    txtPermanentAddress.Text.Trim(),
                    dtpJoiningDate.Value,
                    dtpDateOfBirth.Value
                );

                // Save to file
                EmployeeRepository.AddEmployee(newTeacher);

                var successMessage = new StringBuilder()
                                             .AppendLine("Teacher added successfully!")
                                             .AppendLine()
                                             .AppendLine($"Employee ID: {newTeacher.EmployeeId}")
                                             .ToString();

                MessageBox.Show(
                    successMessage,
                    "Operation Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Clear form
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding teacher: {ex.Message}", "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtDepartment.Clear();
            txtDesignation.Clear();
            txtCurrentAddress.Clear();
            txtPermanentAddress.Clear();
            dtpJoiningDate.Value = DateTime.Now;
            dtpDateOfBirth.Value = DateTime.Now.AddYears(-25);
            txtName.Focus();
        }
    }
}
