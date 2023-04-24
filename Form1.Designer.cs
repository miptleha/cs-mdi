namespace cs_mdi
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parentMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parentMenuItem1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.parentContextMenuItem1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parentContextMenuItem2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parentMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // parentMenuToolStripMenuItem
            // 
            this.parentMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parentMenuItem1ToolStripMenuItem});
            this.parentMenuToolStripMenuItem.Name = "parentMenuToolStripMenuItem";
            this.parentMenuToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.parentMenuToolStripMenuItem.Text = "ParentMenu";
            // 
            // parentMenuItem1ToolStripMenuItem
            // 
            this.parentMenuItem1ToolStripMenuItem.Name = "parentMenuItem1ToolStripMenuItem";
            this.parentMenuItem1ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.parentMenuItem1ToolStripMenuItem.Text = "ParentMenuItem1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parentContextMenuItem1ToolStripMenuItem,
            this.parentContextMenuItem2ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 48);
            // 
            // parentContextMenuItem1ToolStripMenuItem
            // 
            this.parentContextMenuItem1ToolStripMenuItem.Name = "parentContextMenuItem1ToolStripMenuItem";
            this.parentContextMenuItem1ToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.parentContextMenuItem1ToolStripMenuItem.Text = "ParentContextMenuItem1";
            // 
            // parentContextMenuItem2ToolStripMenuItem
            // 
            this.parentContextMenuItem2ToolStripMenuItem.Name = "parentContextMenuItem2ToolStripMenuItem";
            this.parentContextMenuItem2ToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.parentContextMenuItem2ToolStripMenuItem.Text = "ParentContextMenuItem2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 533);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parentMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parentMenuItem1ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parentContextMenuItem1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parentContextMenuItem2ToolStripMenuItem;
    }
}

