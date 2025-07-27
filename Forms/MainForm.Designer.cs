namespace JUSTPayroll.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            titleLabel = new Label();
            btnAddTeacher = new Button();
            btnShowAllTeachers = new Button();
            btnGiveSalary = new Button();
            btnShowSalaryRecord = new Button();
            footerLabel = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Arial", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(58, 34);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(810, 75);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Jashore University of Science and Technology\r\nPayroll Management System";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.BackColor = Color.LightGreen;
            btnAddTeacher.FlatStyle = FlatStyle.Flat;
            btnAddTeacher.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAddTeacher.Location = new Point(335, 171);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(269, 65);
            btnAddTeacher.TabIndex = 1;
            btnAddTeacher.Text = "Add New Teacher";
            btnAddTeacher.UseVisualStyleBackColor = false;
            btnAddTeacher.Click += BtnAddTeacher_Click;
            // 
            // btnShowAllTeachers
            // 
            btnShowAllTeachers.BackColor = Color.LightYellow;
            btnShowAllTeachers.FlatStyle = FlatStyle.Flat;
            btnShowAllTeachers.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnShowAllTeachers.Location = new Point(335, 295);
            btnShowAllTeachers.Name = "btnShowAllTeachers";
            btnShowAllTeachers.Size = new Size(269, 61);
            btnShowAllTeachers.TabIndex = 2;
            btnShowAllTeachers.Text = "Show All Teachers";
            btnShowAllTeachers.UseVisualStyleBackColor = false;
            btnShowAllTeachers.Click += BtnShowAllTeachers_Click;
            // 
            // btnGiveSalary
            // 
            btnGiveSalary.BackColor = Color.LightCoral;
            btnGiveSalary.FlatStyle = FlatStyle.Flat;
            btnGiveSalary.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnGiveSalary.Location = new Point(335, 406);
            btnGiveSalary.Name = "btnGiveSalary";
            btnGiveSalary.Size = new Size(269, 65);
            btnGiveSalary.TabIndex = 3;
            btnGiveSalary.Text = "Give Salary";
            btnGiveSalary.UseVisualStyleBackColor = false;
            btnGiveSalary.Click += BtnGiveSalary_Click;
            // 
            // btnShowSalaryRecord
            // 
            btnShowSalaryRecord.BackColor = Color.LightBlue;
            btnShowSalaryRecord.FlatStyle = FlatStyle.Flat;
            btnShowSalaryRecord.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnShowSalaryRecord.Location = new Point(335, 517);
            btnShowSalaryRecord.Name = "btnShowSalaryRecord";
            btnShowSalaryRecord.Size = new Size(269, 65);
            btnShowSalaryRecord.TabIndex = 4;
            btnShowSalaryRecord.Text = "Show Salary Record";
            btnShowSalaryRecord.UseVisualStyleBackColor = false;
            btnShowSalaryRecord.Click += BtnShowSalaryRecord_Click;
            // 
            // footerLabel
            // 
            footerLabel.Font = new Font("Arial", 10F, FontStyle.Italic);
            footerLabel.ForeColor = Color.Gray;
            footerLabel.Location = new Point(234, 703);
            footerLabel.Name = "footerLabel";
            footerLabel.Size = new Size(481, 19);
            footerLabel.TabIndex = 5;
            footerLabel.Text = "© 2025 JUST Payroll System | All Rights Resereved.";
            footerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(966, 731);
            Controls.Add(footerLabel);
            Controls.Add(btnShowSalaryRecord);
            Controls.Add(btnGiveSalary);
            Controls.Add(btnShowAllTeachers);
            Controls.Add(btnAddTeacher);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JUST Payroll System";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnShowAllTeachers;
        private System.Windows.Forms.Button btnGiveSalary;
        private System.Windows.Forms.Button btnShowSalaryRecord;
        private System.Windows.Forms.Label footerLabel;
    }
}
