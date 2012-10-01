namespace StudentMonitoringSystem.Forms.Employee
{
    partial class FormEmployeeInfoList
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
            this.ctlEmployeeSearchForm1 = new StudentMonitoringSystem.Ctl.ctlEmployeeSearchForm();
            this.SuspendLayout();
            // 
            // ctlEmployeeSearchForm1
            // 
            this.ctlEmployeeSearchForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlEmployeeSearchForm1.Location = new System.Drawing.Point(0, 0);
            this.ctlEmployeeSearchForm1.Name = "ctlEmployeeSearchForm1";
            this.ctlEmployeeSearchForm1.Presenter = null;
            this.ctlEmployeeSearchForm1.Size = new System.Drawing.Size(878, 372);
            this.ctlEmployeeSearchForm1.TabIndex = 0;
            // 
            // FormEmployeeInfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 372);
            this.Controls.Add(this.ctlEmployeeSearchForm1);
            this.Name = "FormEmployeeInfoList";
            this.TabText = "EmployeeInfoList";
            this.Tag = "";
            this.Text = "EmployeeInfoList";
            this.Load += new System.EventHandler(this.FormEmployeeInfoList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeInfoListDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeInfoListidDataGridViewTextBoxColumn;
        private Ctl.ctlEmployeeSearchForm ctlEmployeeSearchForm1;
    }
}