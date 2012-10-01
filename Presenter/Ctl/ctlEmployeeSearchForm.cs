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
    public partial class ctlEmployeeSearchForm : UserControl, IEmployeeInfoList
    {
        public delegate void SelectedHandler (int id);
        public event SelectedHandler Selected;

        public ctlEmployeeSearchForm()
        {
            InitializeComponent();
        }

        public EmployeeInfoListPresenter Presenter
        {
            get;
            set;
        }

        public void LoadForm()
        {
            Presenter = new EmployeeInfoListPresenter(this);
        }

        public void LoadItems()
        {
            Presenter.LoadItems();
        }

        public List<vemployeeinfo> EmployeeInfoListDataSource
        {
            set
            {
                vEmployeeinfoBindingSource.DataSource = value;
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
