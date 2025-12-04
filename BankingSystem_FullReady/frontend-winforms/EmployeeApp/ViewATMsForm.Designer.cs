namespace EmployeeApp
{
    partial class ViewATMsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvATMs;
        private System.Windows.Forms.TextBox txtATMID;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Label lblATMID;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvATMs = new System.Windows.Forms.DataGridView();
            txtATMID = new System.Windows.Forms.TextBox();
            comboStatus = new System.Windows.Forms.ComboBox();
            btnUpdateStatus = new System.Windows.Forms.Button();
            lblATMID = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvATMs).BeginInit();
            SuspendLayout();
            // 
            // dgvATMs
            // 
            dgvATMs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvATMs.Location = new System.Drawing.Point(12, 12);
            dgvATMs.Name = "dgvATMs";
            dgvATMs.RowHeadersWidth = 51;
            dgvATMs.Size = new System.Drawing.Size(650, 250);
            dgvATMs.TabIndex = 0;
            // 
            // txtATMID
            // 
            txtATMID.Location = new System.Drawing.Point(80, 277);
            txtATMID.Name = "txtATMID";
            txtATMID.Size = new System.Drawing.Size(120, 27);
            txtATMID.TabIndex = 2;
            // 
            // comboStatus
            // 
            comboStatus.Items.AddRange(new object[] { "Active", "Maintenance" });
            comboStatus.Location = new System.Drawing.Point(280, 277);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new System.Drawing.Size(120, 28);
            comboStatus.TabIndex = 4;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new System.Drawing.Point(420, 275);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new System.Drawing.Size(120, 35);
            btnUpdateStatus.TabIndex = 5;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // lblATMID
            // 
            lblATMID.Location = new System.Drawing.Point(12, 280);
            lblATMID.Name = "lblATMID";
            lblATMID.Size = new System.Drawing.Size(100, 23);
            lblATMID.TabIndex = 1;
            lblATMID.Text = "ATM ID:";
            // 
            // lblStatus
            // 
            lblStatus.Location = new System.Drawing.Point(220, 280);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(100, 23);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status:";
            // 
            // ViewATMsForm
            // 
            ClientSize = new System.Drawing.Size(694, 359);
            Controls.Add(dgvATMs);
            Controls.Add(lblATMID);
            Controls.Add(txtATMID);
            Controls.Add(lblStatus);
            Controls.Add(comboStatus);
            Controls.Add(btnUpdateStatus);
            Name = "ViewATMsForm";
            Text = "ATM Viewer";
            Load += ViewATMsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvATMs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
