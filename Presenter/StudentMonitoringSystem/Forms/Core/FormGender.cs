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
    public partial class FormGender : WeifenLuo.WinFormsUI.Docking.DockContent, IGender
    {
        #region Constructor

        public FormGender()
        {           
            InitializeComponent();
            grdGender.AutoGenerateColumns = false;
            Presenter = new GenderPresenter(this);
            Name = string.Empty;
        }

        public GenderPresenter Presenter
        {
            get;
            set;
        }

        #endregion

        #region Events

        private void FormGender_Load(object sender, EventArgs e)
        {
            Presenter.LoadItems();
        }

        private void grdGender_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            if (grdGender.CurrentRow == null)
                return;

            var data = grdGender.CurrentRow.DataBoundItem as core_gender;
            if (data == null)
                return;

            int id = data.id;
            Presenter.LoadGenderInfo(id);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ID = 0;
            Name = string.Empty;
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

        #region IGender

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

        public List<core_gender> GenderDataSource
        {
            set
            {
                GenderinfoBindingSource.DataSource = value;
            }
        }
       
        #endregion       

    }
}
