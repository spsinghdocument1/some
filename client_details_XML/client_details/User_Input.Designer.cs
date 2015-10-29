namespace client_details
{
    partial class User_Input
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
            this.label6 = new System.Windows.Forms.Label();
            this.butUpdate = new System.Windows.Forms.Button();
            this.comboBox_Type2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_user_Input2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.textBox_user_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.butUpdate);
            this.panel1.Controls.Add(this.comboBox_Type2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_user_Input2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.comboBox_Type);
            this.panel1.Controls.Add(this.textBox_user_Input);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 218);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Token";
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(490, 164);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(75, 23);
            this.butUpdate.TabIndex = 15;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Visible = false;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // comboBox_Type2
            // 
            this.comboBox_Type2.FormattingEnabled = true;
            this.comboBox_Type2.Items.AddRange(new object[] {
            "string",
            "number"});
            this.comboBox_Type2.Location = new System.Drawing.Point(271, 168);
            this.comboBox_Type2.Name = "comboBox_Type2";
            this.comboBox_Type2.Size = new System.Drawing.Size(140, 21);
            this.comboBox_Type2.TabIndex = 14;
            this.comboBox_Type2.Text = "Select";
            this.comboBox_Type2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Type";
            this.label4.Visible = false;
            // 
            // textBox_user_Input2
            // 
            this.textBox_user_Input2.Location = new System.Drawing.Point(82, 167);
            this.textBox_user_Input2.Name = "textBox_user_Input2";
            this.textBox_user_Input2.Size = new System.Drawing.Size(121, 20);
            this.textBox_user_Input2.TabIndex = 12;
            this.textBox_user_Input2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "User Input";
            this.label3.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(162, 116);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "string",
            "number"});
            this.comboBox_Type.Location = new System.Drawing.Point(148, 65);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(140, 21);
            this.comboBox_Type.TabIndex = 9;
            this.comboBox_Type.Text = "Select";
            // 
            // textBox_user_Input
            // 
            this.textBox_user_Input.Location = new System.Drawing.Point(148, 23);
            this.textBox_user_Input.Name = "textBox_user_Input";
            this.textBox_user_Input.Size = new System.Drawing.Size(140, 20);
            this.textBox_user_Input.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Input";
            // 
            // user_name
            // 
            this.user_name.HeaderText = "user_name";
            this.user_name.Name = "user_name";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_name});
            this.dataGridView2.Location = new System.Drawing.Point(33, 249);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 205);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // type
            // 
            this.type.HeaderText = "type";
            this.type.Name = "type";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // User_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 479);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Name = "User_Input";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "User_Input";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.ComboBox comboBox_Type2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_user_Input2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.TextBox textBox_user_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label5;


    }
}