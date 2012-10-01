using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentMonitoringSystem.Presenter.Core;
using StudentMonitoringSystem.Entities;
using StudentMonitoringSystem.Presenter;

namespace StudentMonitoringSystem.Forms.Core
{
    public partial class FormStudentInfoList : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        #region Constructor

        public FormStudentInfoList()
        {
            InitializeComponent();

        }

        #endregion

        #region Events

        private void FormStudentInfoList_Load(object sender, EventArgs e)
        {
            ctlStudentSearchForm1.LoadForm();
            ctlStudentSearchForm1.LoadItems();
            ctlStudentSearchForm1.Selected += this.Select;
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
