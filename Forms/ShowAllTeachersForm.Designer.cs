namespace JUSTPayroll.Forms
{
    partial class ShowAllTeachersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAllTeachersForm));
            titleLabel = new Label();
            listViewTeachers = new ListView();
            lblTotalCount = new Label();
            btnRefresh = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            titleLabel.ForeColor = Color.Brown;
            titleLabel.Location = new Point(108, 25);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(831, 28);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "All Teachers Information";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listViewTeachers
            // 
            listViewTeachers.Font = new Font("Arial", 9F);
            listViewTeachers.FullRowSelect = true;
            listViewTeachers.GridLines = true;
            listViewTeachers.Location = new Point(22, 56);
            listViewTeachers.Name = "listViewTeachers";
            listViewTeachers.Size = new Size(997, 561);
            listViewTeachers.TabIndex = 1;
            listViewTeachers.UseCompatibleStateImageBehavior = false;
            listViewTeachers.View = View.Details;
            // 
            // lblTotalCount
            // 
            lblTotalCount.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.Crimson;
            lblTotalCount.Location = new Point(12, 646);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(175, 19);
            lblTotalCount.TabIndex = 2;
            lblTotalCount.Text = "Total Teachers: 0";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightGreen;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnRefresh.Location = new Point(816, 632);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(88, 33);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightCoral;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnClose.Location = new Point(931, 632);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(88, 33);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose_Click;
            // 
            // ShowAllTeachersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1040, 684);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(lblTotalCount);
            Controls.Add(listViewTeachers);
            Controls.Add(titleLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShowAllTeachersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All Teachers - JUST Payroll System";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
    }
}
