using System;
using System.Windows.Forms;

namespace JUSTPayroll.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnAddTeacher_Click(object? sender, EventArgs e)
        {
            try
            {
                AddTeacherForm addTeacherForm = new AddTeacherForm();
                addTeacherForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Add Teacher form: {ex.Message}", "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnShowAllTeachers_Click(object? sender, EventArgs e)
        {
            try
            {
                ShowAllTeachersForm showAllForm = new ShowAllTeachersForm();
                showAllForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Show All Teachers form: {ex.Message}", "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGiveSalary_Click(object? sender, EventArgs e)
        {
            try
            {
                GiveSalaryForm giveSalaryForm = new GiveSalaryForm();
                giveSalaryForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Give Salary form: {ex.Message}", "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
