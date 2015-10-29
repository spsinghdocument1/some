namespace client_details
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PARAMETER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PORTFOLIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOKEN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOKEN2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToken2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PARAMETER,
            this.PORTFOLIO,
            this.TOKEN1,
            this.TOKEN2});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(14, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 466);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridToolStripMenuItem,
            this.dToolStripMenuItem,
            this.addToken2ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.gridToolStripMenuItem.Text = "GridLines";
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.gridToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.dToolStripMenuItem.Text = "Add Token-1";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // addToken2ToolStripMenuItem
            // 
            this.addToken2ToolStripMenuItem.Name = "addToken2ToolStripMenuItem";
            this.addToken2ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addToken2ToolStripMenuItem.Text = "Add Token-2";
            this.addToken2ToolStripMenuItem.Click += new System.EventHandler(this.addToken2ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 556);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(43, 512);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 607);
            this.Controls.Add(this.panel1);
            this.Name = "Select";
            this.Text = "Select";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARAMETER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PORTFOLIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOKEN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOKEN2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToken2ToolStripMenuItem;
    }
}