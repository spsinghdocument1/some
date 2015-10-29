namespace RMS
{
    partial class Select
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PARAMETER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PORTFOLIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOKEN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOKEN2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 556);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PARAMETER,
            this.PORTFOLIO,
            this.TOKEN1,
            this.TOKEN2});
            this.dataGridView1.Location = new System.Drawing.Point(18, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 518);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PARAMETER
            // 
            this.PARAMETER.HeaderText = "PARAMETER";
            this.PARAMETER.Name = "PARAMETER";
            this.PARAMETER.Width = 150;
            // 
            // PORTFOLIO
            // 
            this.PORTFOLIO.HeaderText = "PORTFOLIO";
            this.PORTFOLIO.Name = "PORTFOLIO";
            this.PORTFOLIO.Width = 150;
            // 
            // TOKEN1
            // 
            this.TOKEN1.HeaderText = "TOKEN-1";
            this.TOKEN1.Name = "TOKEN1";
            // 
            // TOKEN2
            // 
            this.TOKEN2.HeaderText = "TOKEN-2";
            this.TOKEN2.Name = "TOKEN2";
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 592);
            this.Controls.Add(this.panel1);
            this.Name = "Select";
            this.Text = "Select";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARAMETER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PORTFOLIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOKEN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOKEN2;
    }
}