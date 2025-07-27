namespace JUSTPayroll.Forms
{
    partial class ShowSalaryRecordForm
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
            titleLabel = new Label();
            lblMonth = new Label();
            cmbMonth = new ComboBox();
            listViewSalaries = new ListView();
            lblTotalCount = new Label();
            lblTotalAmount = new Label();
            btnRefresh = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            titleLabel.ForeColor = Color.DarkBlue;
            titleLabel.Location = new Point(25, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1050, 30);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Salary Records";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMonth
            // 
            lblMonth.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblMonth.Location = new Point(25, 60);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(100, 20);
            lblMonth.TabIndex = 1;
            lblMonth.Text = "Select Month:";
            // 
            // cmbMonth
            // 
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.Font = new Font("Arial", 10F);
            cmbMonth.Location = new Point(130, 60);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(150, 24);
            cmbMonth.TabIndex = 2;
            cmbMonth.SelectedIndexChanged += CmbMonth_SelectedIndexChanged;
            // 
            // listViewSalaries
            // 
            listViewSalaries.Font = new Font("Arial", 9F);
            listViewSalaries.FullRowSelect = true;
            listViewSalaries.GridLines = true;
            listViewSalaries.Location = new Point(25, 100);
            listViewSalaries.Name = "listViewSalaries";
            listViewSalaries.Size = new Size(1050, 400);
            listViewSalaries.TabIndex = 3;
            listViewSalaries.UseCompatibleStateImageBehavior = false;
            listViewSalaries.View = View.Details;
            // 
            // lblTotalCount
            // 
            lblTotalCount.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.DarkBlue;
            lblTotalCount.Location = new Point(25, 510);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(200, 20);
            lblTotalCount.TabIndex = 4;
            lblTotalCount.Text = "Total Records: 0";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTotalAmount.ForeColor = Color.DarkGreen;
            lblTotalAmount.Location = new Point(250, 510);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(200, 20);
            lblTotalAmount.TabIndex = 5;
            lblTotalAmount.Text = "Total Amount: 0.00";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightGreen;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnRefresh.Location = new Point(880, 510);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 35);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightCoral;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnClose.Location = new Point(990, 510);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 35);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose_Click;
            // 
            // ShowSalaryRecordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1100, 600);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblTotalCount);
            Controls.Add(listViewSalaries);
            Controls.Add(cmbMonth);
            Controls.Add(lblMonth);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.Sizable;
            Name = "ShowSalaryRecordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary Records - JUST Payroll System";
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private Label lblMonth;
        private ComboBox cmbMonth;
        private ListView listViewSalaries;
        private Label lblTotalCount;
        private Label lblTotalAmount;
        private Button btnRefresh;
        private Button btnClose;
    }
}
