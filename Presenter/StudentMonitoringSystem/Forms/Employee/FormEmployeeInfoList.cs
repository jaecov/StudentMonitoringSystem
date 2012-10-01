using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentMonitoringSystem.Presenter.Employee;
using StudentMonitoringSystem.Entities;
using StudentMonitoringSystem.Presenter;

namespace StudentMonitoringSystem.Forms.Employee
{
    public partial class FormEmployeeInfoList : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        #region Constructor

        public FormEmployeeInfoList()
        {
            InitializeComponent();

        }

        #endregion

        #region Events

        private void FormEmployeeInfoList_Load(object sender, EventArgs e)
        {
            ctlEmployeeSearchForm1.LoadForm();
            ctlEmployeeSearchForm1.LoadItems();
            ctlEmployeeSearchForm1.Selected += this.Select;
        }

        public DialogResult ShowAsDialog()
        {
            return this.ShowDialog();
        }

        #endregion

        public int ID { get; private set; }

        public void Select(int id)
        {
            this.ID = id;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
