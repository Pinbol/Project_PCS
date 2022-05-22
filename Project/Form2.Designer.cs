
namespace Project
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterOccupationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelStaff = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterStaffToolStripMenuItem,
            this.masterMembershipToolStripMenuItem,
            this.masterOccupationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterStaffToolStripMenuItem
            // 
            this.masterStaffToolStripMenuItem.Name = "masterStaffToolStripMenuItem";
            this.masterStaffToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.masterStaffToolStripMenuItem.Text = "Master Staff";
            this.masterStaffToolStripMenuItem.Click += new System.EventHandler(this.masterStaffToolStripMenuItem_Click);
            // 
            // masterMembershipToolStripMenuItem
            // 
            this.masterMembershipToolStripMenuItem.Name = "masterMembershipToolStripMenuItem";
            this.masterMembershipToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.masterMembershipToolStripMenuItem.Text = "Master Membership";
            // 
            // masterOccupationToolStripMenuItem
            // 
            this.masterOccupationToolStripMenuItem.Name = "masterOccupationToolStripMenuItem";
            this.masterOccupationToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.masterOccupationToolStripMenuItem.Text = "Master Occupation";
            // 
            // panelStaff
            // 
            this.panelStaff.Location = new System.Drawing.Point(0, 43);
            this.panelStaff.Name = "panelStaff";
            this.panelStaff.Size = new System.Drawing.Size(1073, 460);
            this.panelStaff.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 506);
            this.Controls.Add(this.panelStaff);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterMembershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterOccupationToolStripMenuItem;
        private System.Windows.Forms.Panel panelStaff;
    }
}