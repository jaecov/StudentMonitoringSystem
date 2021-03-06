﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentMonitoringSystem.Presenter.Enroll;
using StudentMonitoringSystem.Entities;
using StudentMonitoringSystem.Presenter;

namespace StudentMonitoringSystem.Forms.Enroll
{
    public partial class FormEnrolledYear : WeifenLuo.WinFormsUI.Docking.DockContent, IEnrolledYear
    {
        #region Constructor

        public FormEnrolledYear()
        {           
            InitializeComponent();
            grdEnrolledYear.AutoGenerateColumns = false;
            Presenter = new EnrolledYearPresenter(this);           
        }

        public EnrolledYearPresenter Presenter
        {
            get;
            set;
        }

        #endregion

        #region Events

        private void FormEnrolledYear_Load(object sender, EventArgs e)
        {
            Presenter.LoadItems();
        }

        private void grdEnrolledYear_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            if (grdEnrolledYear.CurrentRow == null)
                return;

            var data = grdEnrolledYear.CurrentRow.DataBoundItem as venrolledyearinfo;
            if (data == null)
                return;

            int id = data.id;
            Presenter.LoadEnrolledYearInfo(id);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ID = 0;
            Name = string.Empty;
            Note = string.Empty;
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

        #region IEnrolledYear

        public int ID
        {
            get;
            set;
        }

        public int Course_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbCourse.SelectedValue), out value);
                return value;
            }
            set
            {
                if (cmbCourse.Items.Count > 0)
                    cmbCourse.SelectedValue = value;
            }
        }

        public int Level_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbLevel.SelectedValue), out value);
                return value;
            }
            set
            {
                if (cmbLevel.Items.Count > 0)
                    cmbLevel.SelectedValue = value;
            }
        }

        public int SchoolYear_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbSchoolYear.SelectedValue), out value);
                return value;
            }
            set
            {
                if (cmbSchoolYear.Items.Count > 0)
                    cmbSchoolYear.SelectedValue = value;
            }
        }

        public int Semester_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbSemester.SelectedValue), out value);
                return value;
            }
            set
            {
                if (cmbSemester.Items.Count > 0)
                    cmbSemester.SelectedValue = value;
            }
        }

        public int Section_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbSection.SelectedValue), out value);
                return value;
            }
            set
            {
                if (cmbSection.Items.Count > 0)
                    cmbSection.SelectedValue = value;
            }
        }

        public new string Note
        {
            get { return txtNote.Text; }
            set { txtNote.Text = value; }
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

        public List<venrolledyearinfo> EnrolledYearDataSource
        {
            set
            {
                this.vEnrolledYearinfoBindingSource.DataSource = value;
            }
        }

        public List<enroll_course> CourseDataSource
        {
            set
            {
                value.Insert(0, new enroll_course() { id = 0, name = "Select" });
                cmbCourse.DisplayMember = "name";
                cmbCourse.ValueMember = "id";
                cmbCourse.DataSource = value;
            }
        }

        public List<enroll_level> LevelDataSource
        {
            set
            {
                value.Insert(0, new enroll_level() { id = 0, name = "Select" });
                cmbLevel.DisplayMember = "name";
                cmbLevel.ValueMember = "id";
                cmbLevel.DataSource = value;
            }
        }
      
        #endregion       

    }
}
