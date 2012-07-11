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

        #endregion
        
        #region Methods

        private void ShowForm(WeifenLuo.WinFormsUI.Docking.DockContent form)
        {
            var dockform = DockPanel1.Contents.Where(c => (c as Form).Name == form.Name).SingleOrDefault();
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
