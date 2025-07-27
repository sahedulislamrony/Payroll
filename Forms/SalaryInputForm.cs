using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using JUSTPayroll.Models;
using JUSTPayroll.DB;

namespace JUSTPayroll.Forms
{
    public partial class SalaryInputForm : Form
    {
        private Teacher? singleTeacher;
        private List<Teacher>? allTeachers;
        private bool isForAllTeachers;

        public SalaryInputForm(Teacher teacher)
        {
            singleTeacher = teacher;
            isForAllTeachers = false;
            InitializeComponent();
            
            // Add months to combo box
            string[] months = { "January", "February", "March", "April", "May", "June",
                               "July", "August", "September", "October", "November", "December" };
            cmbMonth.Items.AddRange(months);
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
            
            SetupForSingleTeacher();
        }

        public SalaryInputForm(List<Teacher> teachers)
        {
            allTeachers = teachers;
            isForAllTeachers = true;
            InitializeComponent();
            
            // Add months to combo box
            string[] months = { "January", "February", "March", "April", "May", "June",
                               "July", "August", "September", "October", "November", "December" };
            cmbMonth.Items.AddRange(months);
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
            
            SetupForAllTeachers();
        }

        private void SetupForSingleTeacher()
        {
            if (singleTeacher != null)
            {
                lblTeacherInfo.Text = $"Teacher: {singleTeacher.Name}\nEmployee ID: {singleTeacher.EmployeeId}\nDepartment: {singleTeacher.Department}";
            }
        }

        private void SetupForAllTeachers()
        {
            if (allTeachers != null)
            {
                lblTeacherInfo.Text = $"Processing salary for ALL teachers\nTotal Teachers: {allTeachers.Count}";
            }
        }

        private void SalaryTextBox_TextChanged(object? sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void BtnCalculate_Click(object? sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            try
            {
                decimal baseSalary = string.IsNullOrWhiteSpace(txtBaseSalary.Text) ? 0 : decimal.Parse(txtBaseSalary.Text);
                decimal increment = string.IsNullOrWhiteSpace(txtIncrement.Text) ? 0 : decimal.Parse(txtIncrement.Text);
                decimal decrement = string.IsNullOrWhiteSpace(txtDecrement.Text) ? 0 : decimal.Parse(txtDecrement.Text);
                decimal bonus = string.IsNullOrWhiteSpace(txtBonus.Text) ? 0 : decimal.Parse(txtBonus.Text);

                decimal total = baseSalary + increment + bonus - decrement;
                lblTotalSalary.Text = total.ToString("F2");
            }
            catch (Exception)
            {
                lblTotalSalary.Text = "Invalid Input";
            }
        }

        private void BtnConfirm_Click(object? sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (cmbMonth.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a month.", "Validation Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtBaseSalary.Text) || !decimal.TryParse(txtBaseSalary.Text, out decimal baseSalary))
                {
                    MessageBox.Show("Please enter a valid base salary.", "Validation Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBaseSalary.Focus();
                    return;
                }

                decimal increment = decimal.TryParse(txtIncrement.Text, out decimal inc) ? inc : 0;
                decimal decrement = decimal.TryParse(txtDecrement.Text, out decimal dec) ? dec : 0;
                decimal bonus = decimal.TryParse(txtBonus.Text, out decimal bon) ? bon : 0;

                string selectedMonth = cmbMonth.SelectedItem?.ToString() ?? "";

                if (isForAllTeachers && allTeachers != null)
                {
                    // Process salary for all teachers
                    var salaries = new List<Salary>();
                    foreach (var teacher in allTeachers)
                    {
                        var salary = new Salary(teacher.EmployeeId, teacher.Name, baseSalary, increment, decrement, bonus, selectedMonth);
                        salaries.Add(salary);
                    }

                    SalaryRepository.AddSalaries(salaries);
                    MessageBox.Show($"Salary processed successfully for {allTeachers.Count} teachers for {selectedMonth}!", 
                                  "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (singleTeacher != null)
                {
                    // Process salary for single teacher
                    var salary = new Salary(singleTeacher.EmployeeId, singleTeacher.Name, baseSalary, increment, decrement, bonus, selectedMonth);
                    SalaryRepository.AddSalary(salary);
                    MessageBox.Show($"Salary processed successfully for {singleTeacher.Name} for {selectedMonth}!\nTotal Amount: {salary.TotalSalary:F2}", 
                                  "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing salary: {ex.Message}", "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void BtnShowSalaries_Click(object? sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cmbMonth.SelectedIndex == -1)
        //        {
        //            MessageBox.Show("Please select a month to view salaries.", "Validation Error", 
        //                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        string selectedMonth = cmbMonth.SelectedItem?.ToString() ?? "";
        //        ShowSalariesForm showSalariesForm = new ShowSalariesForm(selectedMonth);
        //        showSalariesForm.ShowDialog();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error showing salaries: {ex.Message}", "Error", 
        //                      MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
