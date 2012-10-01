using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentMonitoringSystem.Presenter.Core;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Ctl
{
    public partial class ctlStudentSearchForm : UserControl, IStudentInfoList
    {
        public delegate void SelectedHandler (int id);
        public event SelectedHandler Selected;

        public ctlStudentSearchForm()
        {
            InitializeComponent();
        }

        public StudentInfoListPresenter Presenter
        {
            get;
            set;
        }

        public void LoadForm()
        {
            Presenter = new StudentInfoListPresenter(this);
        }

        public void LoadItems()
        {
            Presenter.LoadItems();
        }

        public List<vstudentinfo> StudentInfoListDataSource
        {
            set
            {
                vstudentinfoBindingSource.DataSource = value;
            }
        }

        public void Notify(Presenter.Common.Result result, List<string> messages)
        {
            throw new NotImplementedException();
        }

        private void radGridView1_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.Column.HeaderText == "Select" && e.Value != null)
            {
               var id = (int)e.Value;
                Selected(id);
            }
        }

    }
}
