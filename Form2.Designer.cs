namespace cs_mdi
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menutem1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItem1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menutem1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menutem1ToolStripMenuItem
            // 
            this.menutem1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem2ToolStripMenuItem});
            this.menutem1ToolStripMenuItem.Name = "menutem1ToolStripMenuItem";
            this.menutem1ToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.menutem1ToolStripMenuItem.Text = "Menutem1";
            // 
            // menuItem2ToolStripMenuItem
            // 
            this.menuItem2ToolStripMenuItem.Name = "menuItem2ToolStripMenuItem";
            this.menuItem2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.menuItem2ToolStripMenuItem.Text = "MenuItem2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItem1ToolStripMenuItem,
            this.contextMenuItem2ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 48);
            // 
            // contextMenuItem1ToolStripMenuItem
            // 
            this.contextMenuItem1ToolStripMenuItem.Name = "contextMenuItem1ToolStripMenuItem";
            this.contextMenuItem1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contextMenuItem1ToolStripMenuItem.Text = "ContextMenuItem1";
            // 
            // contextMenuItem2ToolStripMenuItem
            // 
            this.contextMenuItem2ToolStripMenuItem.Name = "contextMenuItem2ToolStripMenuItem";
            this.contextMenuItem2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contextMenuItem2ToolStripMenuItem.Text = "ContextMenuItem2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 265);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menutem1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem2ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem2ToolStripMenuItem;
    }
}