using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentMonitoringSystem.Forms.Core;
using StudentMonitoringSystem.Forms.Employee;
using StudentMonitoringSystem.Forms.SMS;
using StudentMonitoringSystem.Forms.Enroll;
using StudentMonitoringSystem.Forms;

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

        #region Events

        private void Main_Load(object sender, EventArgs e)
        {
            FormTest student = new FormTest();
            ShowForm(student);
        }

        private void studentmonitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudent student = new FormStudent();
            ShowForm(student);
        }

        private void EmployeeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployee student = new FormEmployee();
            ShowForm(student);
        }

        private void BarangayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormBarangay();
            ShowForm(form);
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCity();
            ShowForm(form);
        }

        private void provinceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormProvince();
            ShowForm(form);
        }

        private void NetworkProviderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormNetworkProvider();
            ShowForm(form);
        }

        private void networkProviderCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormNetworkProviderCode();
            ShowForm(form);
        }

        private void CourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCourse();
            ShowForm(form);
        }

        #endregion
        
        #region Methods

        private void ShowForm(WeifenLuo.WinFormsUI.Docking.DockContent form)
        {
            var dockform = DockPanel1.Contents.Where(c => (c as Form).Text == form.Text).FirstOrDefault();
            if (dockform == null)
            {                
                form.Show(this.DockPanel1);
                form.Activate();
            }
            else
            {
                (dockform as Form).Activate();
            }
        }

        #endregion

    }
}
