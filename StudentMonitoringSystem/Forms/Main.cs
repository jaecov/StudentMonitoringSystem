using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentMonitoringSystem.Forms.SMS;

namespace StudentMonitoringSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Form Events

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void sendSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            SendSMS newMDIChild = new SendSMS();
            newMDIChild.MdiParent = this;
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
