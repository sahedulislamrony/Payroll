using System;
using System.Windows.Forms;
using JUSTPayroll.Models;
using JUSTPayroll.DB;

namespace JUSTPayroll.Forms
{
    public partial class ShowAllTeachersForm : Form
    {
        public ShowAllTeachersForm()
        {
            InitializeComponent();

            // Add columns
            listViewTeachers.Columns.Add("Employee ID", 100);
            listViewTeachers.Columns.Add("Name", 150);
            listViewTeachers.Columns.Add("Department", 120);
            listViewTeachers.Columns.Add("Designation", 120);
            listViewTeachers.Columns.Add("Current Address", 150);
            listViewTeachers.Columns.Add("Permanent Address", 150);
            listViewTeachers.Columns.Add("Joining Date", 100);
            listViewTeachers.Columns.Add("Date of Birth", 100);

            LoadTeachers();
        }

        private void LoadTeachers()
        {
            try
            {
                listViewTeachers.Items.Clear();
                var teachers = EmployeeRepository.GetAllEmployees();

                foreach (var teacher in teachers)
                {
                    ListViewItem item = new ListViewItem(teacher.EmployeeId);
                    item.SubItems.Add(teacher.Name);
                    item.SubItems.Add(teacher.Department);
                    item.SubItems.Add(teacher.Designation);
                    item.SubItems.Add(teacher.CurrentAddress);
                    item.SubItems.Add(teacher.PermanentAddress);
                    item.SubItems.Add(teacher.JoiningDate.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(teacher.DateOfBirth.ToString("dd/MM/yyyy"));

                    listViewTeachers.Items.Add(item);
                }

                lblTotalCount.Text = $"Total Teachers: {teachers.Count}";

                if (teachers.Count == 0)
                {
                    MessageBox.Show("No teachers found in the database.", "Information",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading teachers: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
