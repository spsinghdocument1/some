namespace client_details
{
    partial class VisibleColumns
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnModfy = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 611);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnModfy);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnLog);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Location = new System.Drawing.Point(15, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 111);
            this.panel2.TabIndex = 2;
            // 
            // btnModfy
            // 
            this.btnModfy.Location = new System.Drawing.Point(422, 28);
            this.btnModfy.Name = "btnModfy";
            this.btnModfy.Size = new System.Drawing.Size(77, 40);
            this.btnModfy.TabIndex = 4;
            this.btnModfy.Text = "Modfy";
            this.btnModfy.UseVisualStyleBackColor = true;
            this.btnModfy.Click += new System.EventHandler(this.btnModfy_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(315, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(217, 28);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(77, 40);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(114, 28);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(77, 40);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 28);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(77, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 369);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // VisibleColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 635);
            this.Controls.Add(this.panel1);
            this.Name = "VisibleColumns";
            this.Text = "VisibleColumns";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModfy;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
    }
}