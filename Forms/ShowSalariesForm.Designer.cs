namespace JUSTPayroll.Forms
{
    partial class ShowSalariesForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnChangeMonth = new System.Windows.Forms.Button();
            this.listViewSalaries = new System.Windows.Forms.ListView();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.titleLabel.Location = new System.Drawing.Point(25, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1050, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Salary Records";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonth
            // 
            this.lblMonth.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblMonth.Location = new System.Drawing.Point(25, 60);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(100, 20);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Select Month:";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbMonth.Location = new System.Drawing.Point(130, 60);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(150, 24);
            this.cmbMonth.TabIndex = 2;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.CmbMonth_SelectedIndexChanged);
            // 
            // btnChangeMonth
            // 
            this.btnChangeMonth.BackColor = System.Drawing.Color.LightYellow;
            this.btnChangeMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeMonth.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnChangeMonth.Location = new System.Drawing.Point(290, 55);
            this.btnChangeMonth.Name = "btnChangeMonth";
            this.btnChangeMonth.Size = new System.Drawing.Size(100, 35);
            this.btnChangeMonth.TabIndex = 3;
            this.btnChangeMonth.Text = "Load Month";
            this.btnChangeMonth.UseVisualStyleBackColor = false;
            this.btnChangeMonth.Click += new System.EventHandler(this.BtnChangeMonth_Click);
            // 
            // listViewSalaries
            // 
            this.listViewSalaries.Font = new System.Drawing.Font("Arial", 9F);
            this.listViewSalaries.FullRowSelect = true;
            this.listViewSalaries.GridLines = true;
            this.listViewSalaries.Location = new System.Drawing.Point(25, 100);
            this.listViewSalaries.Name = "listViewSalaries";
            this.listViewSalaries.Size = new System.Drawing.Size(1050, 400);
            this.listViewSalaries.TabIndex = 4;
            this.listViewSalaries.UseCompatibleStateImageBehavior = false;
            this.listViewSalaries.View = System.Windows.Forms.View.Details;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalCount.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalCount.Location = new System.Drawing.Point(25, 510);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(200, 20);
            this.lblTotalCount.TabIndex = 5;
            this.lblTotalCount.Text = "Total Records: 0";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalAmount.Location = new System.Drawing.Point(250, 510);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(200, 20);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = "Total Amount: 0.00";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightGreen;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(880, 510);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(990, 510);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ShowSalariesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.listViewSalaries);
            this.Controls.Add(this.btnChangeMonth);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "ShowSalariesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Records - JUST Payroll System";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Button btnChangeMonth;
        private System.Windows.Forms.ListView listViewSalaries;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
    }
}
