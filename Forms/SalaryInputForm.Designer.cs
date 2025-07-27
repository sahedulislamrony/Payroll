namespace JUSTPayroll.Forms
{
    partial class SalaryInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryInputForm));
            titleLabel = new Label();
            lblTeacherInfo = new Label();
            btnCalculate = new Button();
            btnConfirm = new Button();
            btnCancel = new Button();
            lblTotalSalary = new Label();
            lblTotalLabel = new Label();
            txtBonus = new TextBox();
            lblBonus = new Label();
            txtDecrement = new TextBox();
            lblDecrement = new Label();
            txtIncrement = new TextBox();
            lblIncrement = new Label();
            txtBaseSalary = new TextBox();
            lblBaseSalary = new Label();
            cmbMonth = new ComboBox();
            lblMonth = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            titleLabel.ForeColor = Color.Maroon;
            titleLabel.Location = new Point(106, 31);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(394, 28);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Salary Information Input";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTeacherInfo
            // 
            lblTeacherInfo.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeacherInfo.ForeColor = Color.DarkGreen;
            lblTeacherInfo.Location = new Point(92, 73);
            lblTeacherInfo.Name = "lblTeacherInfo";
            lblTeacherInfo.Padding = new Padding(0, 10, 0, 0);
            lblTeacherInfo.Size = new Size(432, 99);
            lblTeacherInfo.TabIndex = 1;
            lblTeacherInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.LightYellow;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnCalculate.Location = new Point(44, 554);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(149, 33);
            btnCalculate.TabIndex = 14;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += BtnCalculate_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.LightGreen;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnConfirm.Location = new Point(219, 554);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(149, 33);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += BtnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(398, 554);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(149, 33);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // lblTotalSalary
            // 
            lblTotalSalary.BorderStyle = BorderStyle.FixedSingle;
            lblTotalSalary.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblTotalSalary.ForeColor = Color.DarkGreen;
            lblTotalSalary.Location = new Point(271, 445);
            lblTotalSalary.Name = "lblTotalSalary";
            lblTotalSalary.Size = new Size(175, 24);
            lblTotalSalary.TabIndex = 29;
            lblTotalSalary.Text = "0.00";
            lblTotalSalary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalLabel
            // 
            lblTotalLabel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalLabel.Location = new Point(134, 450);
            lblTotalLabel.Name = "lblTotalLabel";
            lblTotalLabel.Size = new Size(131, 19);
            lblTotalLabel.TabIndex = 28;
            lblTotalLabel.Text = "Total Salary:";
            // 
            // txtBonus
            // 
            txtBonus.BorderStyle = BorderStyle.FixedSingle;
            txtBonus.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBonus.Location = new Point(271, 389);
            txtBonus.Name = "txtBonus";
            txtBonus.Size = new Size(176, 25);
            txtBonus.TabIndex = 27;
            txtBonus.Text = "0";
            // 
            // lblBonus
            // 
            lblBonus.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBonus.Location = new Point(134, 393);
            lblBonus.Name = "lblBonus";
            lblBonus.Size = new Size(131, 19);
            lblBonus.TabIndex = 26;
            lblBonus.Text = "Bonus:";
            // 
            // txtDecrement
            // 
            txtDecrement.BorderStyle = BorderStyle.FixedSingle;
            txtDecrement.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDecrement.Location = new Point(271, 340);
            txtDecrement.Name = "txtDecrement";
            txtDecrement.Size = new Size(176, 25);
            txtDecrement.TabIndex = 25;
            txtDecrement.Text = "0";
            // 
            // lblDecrement
            // 
            lblDecrement.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblDecrement.Location = new Point(134, 344);
            lblDecrement.Name = "lblDecrement";
            lblDecrement.Size = new Size(131, 19);
            lblDecrement.TabIndex = 24;
            lblDecrement.Text = "Decrement:";
            // 
            // txtIncrement
            // 
            txtIncrement.BorderStyle = BorderStyle.FixedSingle;
            txtIncrement.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIncrement.Location = new Point(271, 292);
            txtIncrement.Name = "txtIncrement";
            txtIncrement.Size = new Size(176, 25);
            txtIncrement.TabIndex = 23;
            txtIncrement.Text = "0";
            // 
            // lblIncrement
            // 
            lblIncrement.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIncrement.Location = new Point(134, 296);
            lblIncrement.Name = "lblIncrement";
            lblIncrement.Size = new Size(131, 19);
            lblIncrement.TabIndex = 22;
            lblIncrement.Text = "Increment:";
            // 
            // txtBaseSalary
            // 
            txtBaseSalary.BorderStyle = BorderStyle.FixedSingle;
            txtBaseSalary.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBaseSalary.Location = new Point(271, 243);
            txtBaseSalary.Name = "txtBaseSalary";
            txtBaseSalary.Size = new Size(176, 25);
            txtBaseSalary.TabIndex = 21;
            // 
            // lblBaseSalary
            // 
            lblBaseSalary.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaseSalary.Location = new Point(134, 243);
            lblBaseSalary.Name = "lblBaseSalary";
            lblBaseSalary.Size = new Size(131, 19);
            lblBaseSalary.TabIndex = 20;
            lblBaseSalary.Text = "Base Salary:";
            // 
            // cmbMonth
            // 
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMonth.Location = new Point(271, 192);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(176, 25);
            cmbMonth.TabIndex = 19;
            // 
            // lblMonth
            // 
            lblMonth.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonth.Location = new Point(134, 195);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(131, 19);
            lblMonth.TabIndex = 18;
            lblMonth.Text = "Select Month:";
            // 
            // SalaryInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(581, 661);
            Controls.Add(lblTotalSalary);
            Controls.Add(lblTotalLabel);
            Controls.Add(txtBonus);
            Controls.Add(lblBonus);
            Controls.Add(txtDecrement);
            Controls.Add(lblDecrement);
            Controls.Add(txtIncrement);
            Controls.Add(lblIncrement);
            Controls.Add(txtBaseSalary);
            Controls.Add(lblBaseSalary);
            Controls.Add(cmbMonth);
            Controls.Add(lblMonth);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(btnCalculate);
            Controls.Add(lblTeacherInfo);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SalaryInputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary Input - JUST Payroll System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label lblTeacherInfo;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private Label lblTotalSalary;
        private Label lblTotalLabel;
        private TextBox txtBonus;
        private Label lblBonus;
        private TextBox txtDecrement;
        private Label lblDecrement;
        private TextBox txtIncrement;
        private Label lblIncrement;
        private TextBox txtBaseSalary;
        private Label lblBaseSalary;
        private ComboBox cmbMonth;
        private Label lblMonth;
    }
}
