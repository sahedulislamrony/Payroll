namespace JUSTPayroll.Forms
{
    partial class GiveSalaryForm
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
            groupOptions = new GroupBox();
            rbAll = new RadioButton();
            lblSearchResult = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            rbSpecific = new RadioButton();
            btnProceed = new Button();
            btnCancel = new Button();
            groupOptions.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            titleLabel.ForeColor = Color.Crimson;
            titleLabel.Location = new Point(195, 35);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(394, 28);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Salary Distribution Options";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupOptions
            // 
            groupOptions.Controls.Add(rbAll);
            groupOptions.Controls.Add(lblSearchResult);
            groupOptions.Controls.Add(btnSearch);
            groupOptions.Controls.Add(txtSearch);
            groupOptions.Controls.Add(lblSearch);
            groupOptions.Controls.Add(rbSpecific);
            groupOptions.Font = new Font("Arial", 10F, FontStyle.Bold);
            groupOptions.Location = new Point(123, 109);
            groupOptions.Name = "groupOptions";
            groupOptions.Size = new Size(571, 315);
            groupOptions.TabIndex = 1;
            groupOptions.TabStop = false;
            groupOptions.Text = "Select Option";
            // 
            // rbAll
            // 
            rbAll.Font = new Font("Arial", 10F);
            rbAll.Location = new Point(18, 263);
            rbAll.Name = "rbAll";
            rbAll.Size = new Size(262, 23);
            rbAll.TabIndex = 5;
            rbAll.Text = "Give salary to all teachers";
            rbAll.UseVisualStyleBackColor = true;
            rbAll.CheckedChanged += RbAll_CheckedChanged;
            // 
            // lblSearchResult
            // 
            lblSearchResult.Font = new Font("Arial", 9F);
            lblSearchResult.ForeColor = Color.Lime;
            lblSearchResult.Location = new Point(35, 108);
            lblSearchResult.Name = "lblSearchResult";
            lblSearchResult.Size = new Size(517, 135);
            lblSearchResult.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightYellow;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnSearch.Location = new Point(468, 51);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(84, 32);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += BtnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(237, 56);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(212, 25);
            txtSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.Font = new Font("Arial", 9F);
            lblSearch.Location = new Point(36, 60);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(195, 19);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search by Name or Employee ID:";
            // 
            // rbSpecific
            // 
            rbSpecific.Checked = true;
            rbSpecific.Font = new Font("Arial", 10F);
            rbSpecific.Location = new Point(18, 32);
            rbSpecific.Name = "rbSpecific";
            rbSpecific.Size = new Size(262, 23);
            rbSpecific.TabIndex = 0;
            rbSpecific.TabStop = true;
            rbSpecific.Text = "Give salary to a specific teacher";
            rbSpecific.UseVisualStyleBackColor = true;
            rbSpecific.CheckedChanged += RbSpecific_CheckedChanged;
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.LightGreen;
            btnProceed.FlatStyle = FlatStyle.Flat;
            btnProceed.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProceed.Location = new Point(173, 478);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(199, 46);
            btnProceed.TabIndex = 2;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += BtnProceed_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(444, 478);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(199, 46);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // GiveSalaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(798, 686);
            Controls.Add(btnCancel);
            Controls.Add(btnProceed);
            Controls.Add(groupOptions);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GiveSalaryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Give Salary - JUST Payroll System";
            groupOptions.ResumeLayout(false);
            groupOptions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox groupOptions;
        private System.Windows.Forms.RadioButton rbSpecific;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchResult;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnCancel;
    }
}
