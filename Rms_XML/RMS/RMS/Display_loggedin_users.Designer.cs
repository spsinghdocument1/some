namespace RMS
{
    partial class Display_loggedin_users
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.User_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Privilege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local_IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_Id,
            this.Privilege,
            this.Branch,
            this.Local_IP,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(25, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // User_Id
            // 
            this.User_Id.HeaderText = "User_Id";
            this.User_Id.Name = "User_Id";
            // 
            // Privilege
            // 
            this.Privilege.HeaderText = "Privilege";
            this.Privilege.Name = "Privilege";
            // 
            // Branch
            // 
            this.Branch.HeaderText = "Branch";
            this.Branch.Name = "Branch";
            // 
            // Local_IP
            // 
            this.Local_IP.HeaderText = "Local_IP";
            this.Local_IP.Name = "Local_IP";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Display_loggedin_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 359);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Display_loggedin_users";
            this.Text = "Display_loggedin_users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Privilege;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local_IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}