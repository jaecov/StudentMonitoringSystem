using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentMonitoringSystem;
using StudentMonitoringSystem.Forms;
using StudentMonitoringSystem.Forms.SMS;
using StudentMonitoringSystem.Forms.Student;



namespace StudentMonitoringSystem
{
    public partial class Main : Form
    {
        #region Constructor

        public Main()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Events
        
        private void Main_Load(object sender, EventArgs e)
        {
            //Student.GetStudentByStatus(true);
            //Student.GetStudentByName("Jake");
            //Student.GetStudentBySectionID(2);
            //Student.GetStudentByStudentNumber("087-2010-0015");

            
        }

        private void sendSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            SendSMS newMDIChild = new SendSMS();
            newMDIChild.MdiParent = this;
            newMDIChild.WindowState = FormWindowState.Maximized;
            newMDIChild.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            Student newMDIChild = new Student();
            newMDIChild.MdiParent = this;
            newMDIChild.WindowState = FormWindowState.Maximized;
            newMDIChild.Show();
        }

        #endregion
        
        #region Methods

        private void CloseAllForm()
        {
            foreach (Form ChildForm in this.MdiChildren)
            {
                ChildForm.Close();
            }
        }

        #endregion

      

    }
}
