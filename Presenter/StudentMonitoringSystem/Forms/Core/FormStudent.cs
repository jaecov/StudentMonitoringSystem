using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentMonitoringSystem.Presenter;
using StudentMonitoringSystem.Presenter.Core;
using System.Collections;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Forms.Core
{
    public partial class FormStudent : WeifenLuo.WinFormsUI.Docking.DockContent, IStudent
    {

        #region Constructor

        public FormStudent()
        {
            Presenter = new StudentPresenter(this);
            InitializeComponent();
        }

        public StudentPresenter Presenter
        {
            get;
            set;
        }

        #endregion

        #region IStudent

        public int ID
        {
            get;
            set;
        }

        public string Number
        {
            get { return txtNo.Text; }
            set { txtNo.Text = value; }
        }

        public string Citizenship
        {
            get
            {
                return txtCitizenship.Text;
            }
            set
            {
                txtCitizenship.Text = value;
            }
        }

        public int CivilStatus_id
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbCivilStatus.SelectedValue), out value);
                return value;
            }
            set
            {
                if (cmbCivilStatus.Items.Count > 0)
                    cmbCivilStatus.SelectedValue = value;
            }
        }

        public string Firstname
        {
            get
            {
                return txtFirstname.Text;
            }
            set
            {
                txtFirstname.Text = value;
            }
        }

        public int Gender_id
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbGender.SelectedValue), out value);
                return value;
            }
            set
            {
                if (cmbGender.Items.Count > 0)
                    cmbGender.SelectedValue = value;

            }
        }

        public string Lastname
        {
            get
            {
                return txtLastname.Text;
            }
            set
            {
                txtLastname.Text = value;
            }
        }

        public string Middlename
        {
            get
            {
                return txtMiddlename.Text;
            }
            set
            {
                txtMiddlename.Text = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return dteDateOfBirth.Value; }
            set { dteDateOfBirth.Value = value; }
        }

        public IList CivilStatusDataSource
        {
            set
            {
                cmbCivilStatus.DisplayMember = "Name";
                cmbCivilStatus.ValueMember = "id";
                cmbCivilStatus.DataSource = value;
            }
        }

        public IList GenderDataSource
        {
            set
            {
                cmbGender.DisplayMember = "Name";
                cmbGender.ValueMember = "id";
                cmbGender.DataSource = value;
            }
        }

        public List<vstudentinfo> StudentDataSource
        {
            set
            {
                LoadStudents(value);
            }
        }

        #endregion

        #region BaseView

        public void Notify(Common.Result result, Exception ex)
        {
            string msg = Common.Message(result);
            MessageBox.Show(msg);
        }

        #endregion

        #region Events

        private void Student_Load(object sender, EventArgs e)
        {
            Presenter.LoadItems();
        }

        private void lvwStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwStudent.SelectedItems.Count == 0)
                return;

            int id = (int)lvwStudent.SelectedItems[0].Tag;
            Presenter.LoadStudentInfo(id);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ID = 0;
            Number = Common.GenerateNewNumber();
            Firstname = string.Empty;
            Middlename = string.Empty;
            Lastname = string.Empty;
            Gender_id = 1;
            CivilStatus_id = 1;
            DateOfBirth = DateTime.Now;
            Citizenship = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Confirm("Do you want to save? Click OK to proceed."))
                Presenter.Save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Confirm("Do you want to delete? Click OK to proceed"))
            {
             var result =  Presenter.Delete();
             if (result)
             {
                 btnReset_Click(sender, e);
             }
            }           
        }

        #endregion

        #region Methods

        private bool Confirm(string msg, string title = "Confirm")
        {
            var result = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
                return true;
            else
                return false;
        }

        private void LoadStudents(List<vstudentinfo> list)
        {
            lvwStudent.Items.Clear();
            ListViewItem item = null;

            foreach (var student in list)
            {
                item = new ListViewItem();
                item.Tag = student.id;
                item.Text = student.number;
                item.SubItems.Add(string.Format("{0}, {1} {2}", student.lastname, student.firstname, student.middlename));
                item.SubItems.Add(student.gender);
                item.SubItems.Add(student.civilstatus);
                item.SubItems.Add(student.dateofbirth.ToString());
                item.SubItems.Add(student.citizenship);

                lvwStudent.Items.Add(item);
            }
        }

        #endregion            

    }
}
