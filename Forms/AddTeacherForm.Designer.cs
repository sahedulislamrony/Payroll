namespace JUSTPayroll.Forms
{
    partial class AddTeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeacherForm));
            titleLabel = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblDepartment = new Label();
            txtDepartment = new TextBox();
            lblDesignation = new Label();
            txtDesignation = new TextBox();
            lblCurrentAddress = new Label();
            txtCurrentAddress = new TextBox();
            lblPermanentAddress = new Label();
            txtPermanentAddress = new TextBox();
            lblJoiningDate = new Label();
            dtpJoiningDate = new DateTimePicker();
            lblDateOfBirth = new Label();
            dtpDateOfBirth = new DateTimePicker();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(107, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(394, 28);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Add New Teacher Information";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(110, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(131, 19);
            lblName.TabIndex = 1;
            lblName.Text = "Full Name:";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(258, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 25);
            txtName.TabIndex = 2;
            // 
            // lblDepartment
            // 
            lblDepartment.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDepartment.Location = new Point(110, 118);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(131, 19);
            lblDepartment.TabIndex = 3;
            lblDepartment.Text = "Department:";
            // 
            // txtDepartment
            // 
            txtDepartment.BorderStyle = BorderStyle.FixedSingle;
            txtDepartment.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartment.Location = new Point(258, 118);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(219, 25);
            txtDepartment.TabIndex = 4;
            // 
            // lblDesignation
            // 
            lblDesignation.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesignation.Location = new Point(110, 165);
            lblDesignation.Name = "lblDesignation";
            lblDesignation.Size = new Size(131, 19);
            lblDesignation.TabIndex = 5;
            lblDesignation.Text = "Designation:";
            // 
            // txtDesignation
            // 
            txtDesignation.BorderStyle = BorderStyle.FixedSingle;
            txtDesignation.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDesignation.Location = new Point(258, 163);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new Size(219, 25);
            txtDesignation.TabIndex = 6;
            // 
            // lblCurrentAddress
            // 
            lblCurrentAddress.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentAddress.Location = new Point(110, 220);
            lblCurrentAddress.Name = "lblCurrentAddress";
            lblCurrentAddress.Size = new Size(131, 19);
            lblCurrentAddress.TabIndex = 7;
            lblCurrentAddress.Text = "Current Address:";
            // 
            // txtCurrentAddress
            // 
            txtCurrentAddress.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentAddress.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentAddress.Location = new Point(258, 218);
            txtCurrentAddress.Multiline = true;
            txtCurrentAddress.Name = "txtCurrentAddress";
            txtCurrentAddress.Size = new Size(219, 47);
            txtCurrentAddress.TabIndex = 8;
            // 
            // lblPermanentAddress
            // 
            lblPermanentAddress.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPermanentAddress.Location = new Point(107, 295);
            lblPermanentAddress.Name = "lblPermanentAddress";
            lblPermanentAddress.Size = new Size(157, 30);
            lblPermanentAddress.TabIndex = 9;
            lblPermanentAddress.Text = "Permanent Address:";
            // 
            // txtPermanentAddress
            // 
            txtPermanentAddress.BorderStyle = BorderStyle.FixedSingle;
            txtPermanentAddress.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPermanentAddress.Location = new Point(258, 293);
            txtPermanentAddress.Multiline = true;
            txtPermanentAddress.Name = "txtPermanentAddress";
            txtPermanentAddress.Size = new Size(219, 47);
            txtPermanentAddress.TabIndex = 10;
            // 
            // lblJoiningDate
            // 
            lblJoiningDate.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJoiningDate.Location = new Point(107, 362);
            lblJoiningDate.Name = "lblJoiningDate";
            lblJoiningDate.Size = new Size(131, 19);
            lblJoiningDate.TabIndex = 11;
            lblJoiningDate.Text = "Joining Date:";
            // 
            // dtpJoiningDate
            // 
            dtpJoiningDate.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpJoiningDate.Format = DateTimePickerFormat.Short;
            dtpJoiningDate.Location = new Point(258, 362);
            dtpJoiningDate.Name = "dtpJoiningDate";
            dtpJoiningDate.Size = new Size(219, 25);
            dtpJoiningDate.TabIndex = 12;
            dtpJoiningDate.Value = new DateTime(2025, 7, 27, 12, 47, 50, 0);
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateOfBirth.Location = new Point(107, 415);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(131, 19);
            lblDateOfBirth.TabIndex = 13;
            lblDateOfBirth.Text = "Date of Birth:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(258, 409);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(219, 25);
            dtpDateOfBirth.TabIndex = 14;
            dtpDateOfBirth.Value = new DateTime(2001, 10, 10, 0, 0, 0, 0);
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(64, 520);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(216, 61);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add Teacher";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(326, 520);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(216, 61);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // AddTeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(593, 645);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(lblDateOfBirth);
            Controls.Add(dtpJoiningDate);
            Controls.Add(lblJoiningDate);
            Controls.Add(txtPermanentAddress);
            Controls.Add(lblPermanentAddress);
            Controls.Add(txtCurrentAddress);
            Controls.Add(lblCurrentAddress);
            Controls.Add(txtDesignation);
            Controls.Add(lblDesignation);
            Controls.Add(txtDepartment);
            Controls.Add(lblDepartment);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddTeacherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Teacher - JUST Payroll System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label lblCurrentAddress;
        private System.Windows.Forms.TextBox txtCurrentAddress;
        private System.Windows.Forms.Label lblPermanentAddress;
        private System.Windows.Forms.TextBox txtPermanentAddress;
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}
