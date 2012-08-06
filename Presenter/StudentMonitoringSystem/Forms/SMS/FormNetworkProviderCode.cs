using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentMonitoringSystem.Presenter.SMS;
using StudentMonitoringSystem.Entities;
using StudentMonitoringSystem.Presenter;

namespace StudentMonitoringSystem.Forms.SMS
{
    public partial class FormNetworkProviderCode : WeifenLuo.WinFormsUI.Docking.DockContent, INetworkProviderCode
    {
        #region Constructor

        public FormNetworkProviderCode()
        {           
            InitializeComponent();
            grdNetworkProviderCode.AutoGenerateColumns = false;
            Presenter = new NetworkProviderCodePresenter(this);
            Name = string.Empty;
        }

        public NetworkProviderCodePresenter Presenter
        {
            get;
            set;
        }

        #endregion

        #region Events

        private void FormNetworkProviderCode_Load(object sender, EventArgs e)
        {
            Presenter.LoadItems();
        }

        private void grdNetworkProviderCode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            if (grdNetworkProviderCode.CurrentRow == null)
                return;

            var data = grdNetworkProviderCode.CurrentRow.DataBoundItem as vnetworkprovidercodeinfo;
            if (data == null)
                return;

            int id = data.id;
            Presenter.LoadNetworkProviderCodeInfo(id);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ID = 0;
            Name = string.Empty;
            NetworkProvider_ID = 0;
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

        #region INetworkProviderCode

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

        public int NetworkProvider_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbNetworkProvider.SelectedValue), out value);
                return value;
            }
            set
            {
                if (cmbNetworkProvider.Items.Count > 0)
                    cmbNetworkProvider.SelectedValue = value;
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

        public List<vnetworkprovidercodeinfo> NetworkProviderCodeDataSource
        {
            set
            {
                vNetworkProviderCodeinfoBindingSource.DataSource = value;
            }
        }
        public List<sms_networkprovider> NetworkProviderDataSource
        {
            set
            {
                value.Insert(0, new sms_networkprovider() { id = 0, name = "Select" });
                cmbNetworkProvider.DisplayMember = "name";
                cmbNetworkProvider.ValueMember = "id";
                cmbNetworkProvider.DataSource = value;
            }
        }

        #endregion       

    }
}
