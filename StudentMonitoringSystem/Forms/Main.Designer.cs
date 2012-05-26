namespace StudentMonitoringSystem
{
    partial class Main
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.sMSToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Image = global::StudentMonitoringSystem.Properties.Resources.student;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // sMSToolStripMenuItem
            // 
            this.sMSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendSMSToolStripMenuItem,
            this.inboxToolStripMenuItem,
            this.sentToolStripMenuItem});
            this.sMSToolStripMenuItem.Image = global::StudentMonitoringSystem.Properties.Resources.mobile_phone;
            this.sMSToolStripMenuItem.Name = "sMSToolStripMenuItem";
            this.sMSToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sMSToolStripMenuItem.Text = "SMS";
            // 
            // sendSMSToolStripMenuItem
            // 
            this.sendSMSToolStripMenuItem.Image = global::StudentMonitoringSystem.Properties.Resources.update;
            this.sendSMSToolStripMenuItem.Name = "sendSMSToolStripMenuItem";
            this.sendSMSToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.sendSMSToolStripMenuItem.Text = "Send SMS";
            this.sendSMSToolStripMenuItem.Click += new System.EventHandler(this.sendSMSToolStripMenuItem_Click);
            // 
            // inboxToolStripMenuItem
            // 
            this.inboxToolStripMenuItem.Image = global::StudentMonitoringSystem.Properties.Resources.sms_call;
            this.inboxToolStripMenuItem.Name = "inboxToolStripMenuItem";
            this.inboxToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.inboxToolStripMenuItem.Text = "Inbox";
            // 
            // sentToolStripMenuItem
            // 
            this.sentToolStripMenuItem.Image = global::StudentMonitoringSystem.Properties.Resources.sms;
            this.sentToolStripMenuItem.Name = "sentToolStripMenuItem";
            this.sentToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.sentToolStripMenuItem.Text = "Sent";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem sMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendSMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
    }
}



