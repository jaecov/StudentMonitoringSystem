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
    public partial class FormBarangay : WeifenLuo.WinFormsUI.Docking.DockContent, IBarangay
    {
        #region Constructor

        public FormBarangay()
        {           
            InitializeComponent();
            grdBarangay.AutoGenerateColumns = false;
            Presenter = new BarangayPresenter(this);
            Name = string.Empty;
        }

        public BarangayPresenter Presenter
        {
            get;
            set;
        }

        #endregion

        #region Events

        private void FormBarangay_Load(object sender, EventArgs e)
        {
            Presenter.LoadItems();
        }

        private void grdBarangay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            if (grdBarangay.CurrentRow == null)
                return;

            var data = grdBarangay.CurrentRow.DataBoundItem as vbarangayinfo;
            if (data == null)
                return;

            int id = data.id;
            Presenter.LoadBarangayInfo(id);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ID = 0;
            Name = string.Empty;
            City_ID = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var ask = Confirm("Do you want to save? Click OK to proceed.");
            if (ask)
            {
                Presenter.Save();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var ask = Confirm("Do you want to delete? Click OK to proceed.");
            if (ask)
            {
                Presenter.Delete();
                btnReset_Click(sender, e);
            }            
        }

        private bool Confirm(string msg, string title = "Confirm")
        {
            var result = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
                return true;
            else
                return false;
        }

        #endregion

        #region IBarangay

        public int ID
        {
            get;
            set;
        }

        public new string Name
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public int City_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbCity.SelectedValue), out value);
                return value;
            }
            set
            {
                if (cmbCity.Items.Count > 0)
                    cmbCity.SelectedValue = value;
            }
        }

        public void Notify(Common.Result result, List<string> messages)
        {
            if (result == Common.Result.ValidationFailed)
            {
                string title = Common.Message(result);
                string msg = string.Empty;
                int count = 1;
                foreach (var item in messages)
                {
                    msg += string.Format("{0}.{1}\n", count, item);
                    count += 1;
                }
                MessageBox.Show(msg, title);
            }
            else
            {
                string msg = Common.Message(result);
                MessageBox.Show(msg);
            }
        }

        public List<vbarangayinfo> BarangayDataSource
        {
            set
            {
                vbarangayinfoBindingSource.DataSource = value;
            }
        }
        public List<core_city> CityDataSource
        {
            set
            {
                value.Insert(0, new core_city() { id = 0, name = "Select" });
                cmbCity.DisplayMember = "name";
                cmbCity.ValueMember = "id";
                cmbCity.DataSource = value;
            }
        }

        #endregion       

    }
}
