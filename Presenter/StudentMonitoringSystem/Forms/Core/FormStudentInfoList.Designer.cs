namespace StudentMonitoringSystem.Forms.Core
{
    partial class FormStudentInfoList
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
            this.ctlStudentSearchForm1 = new StudentMonitoringSystem.Ctl.ctlStudentSearchForm();
            this.SuspendLayout();
            // 
            // ctlStudentSearchForm1
            // 
            this.ctlStudentSearchForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlStudentSearchForm1.Location = new System.Drawing.Point(0, 0);
            this.ctlStudentSearchForm1.Name = "ctlStudentSearchForm1";
            this.ctlStudentSearchForm1.Presenter = null;
            this.ctlStudentSearchForm1.Size = new System.Drawing.Size(878, 372);
            this.ctlStudentSearchForm1.TabIndex = 0;
            // 
            // FormStudentInfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 372);
            this.Controls.Add(this.ctlStudentSearchForm1);
            this.Name = "FormStudentInfoList";
            this.TabText = "StudentInfoList";
            this.Tag = "";
            this.Text = "StudentInfoList";
            this.Load += new System.EventHandler(this.FormStudentInfoList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentInfoListDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentInfoListidDataGridViewTextBoxColumn;
        private Ctl.ctlStudentSearchForm ctlStudentSearchForm1;
    }
}