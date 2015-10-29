namespace client_details
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visibleColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.tokenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visibleColumnToolStripMenuItem,
            this.aDDToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "master";
            // 
            // visibleColumnToolStripMenuItem
            // 
            this.visibleColumnToolStripMenuItem.Name = "visibleColumnToolStripMenuItem";
            this.visibleColumnToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.visibleColumnToolStripMenuItem.Text = "VisibleColumn";
            this.visibleColumnToolStripMenuItem.Click += new System.EventHandler(this.visibleColumnToolStripMenuItem_Click);
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.aDDToolStripMenuItem.Text = "Add Column";
            this.aDDToolStripMenuItem.Click += new System.EventHandler(this.aDDToolStripMenuItem_Click);
            // 
            // tokenToolStripMenuItem
            // 
            this.tokenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInputToolStripMenuItem});
            this.tokenToolStripMenuItem.Name = "tokenToolStripMenuItem";
            this.tokenToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.tokenToolStripMenuItem.Text = "User Input";
            // 
            // userInputToolStripMenuItem
            // 
            this.userInputToolStripMenuItem.Name = "userInputToolStripMenuItem";
            this.userInputToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.userInputToolStripMenuItem.Text = "User Input";
            this.userInputToolStripMenuItem.Click += new System.EventHandler(this.userInputToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 653);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visibleColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInputToolStripMenuItem;
    }
}

