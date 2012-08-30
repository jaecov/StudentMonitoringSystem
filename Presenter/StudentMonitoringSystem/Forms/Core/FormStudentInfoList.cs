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
    public partial class FormStudentInfoList : WeifenLuo.WinFormsUI.Docking.DockContent, IStudentInfoList
    {
        #region Constructor

        public FormStudentInfoList()
        {
            InitializeComponent();
            grdStudentInfoList.AutoGenerateColumns = false;
            Presenter = new StudentInfoListPresenter(this);
            Name = string.Empty;
        }

        public StudentInfoListPresenter Presenter
        {
            get;
            set;
        }

        #endregion

        #region Events

        private void FormStudentInfoList_Load(object sender, EventArgs e)
        {
            Presenter.LoadItems();
        }

        private void grdStudentInfoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            if (grdStudentInfoList.CurrentRow == null)
                return;

            var data = grdStudentInfoList.CurrentRow.DataBoundItem as vstudentinfo;
            if (data == null)
                return;
            this.ID = data.id;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ID = 0;
            Name = string.Empty;
        }

        private void txtLastname_KeyUp(object sender, KeyEventArgs e)
        {
            Presenter.LoadStudentList();
        }

        public DialogResult ShowAsDialog()
        {
            return this.ShowDialog();
        }

        #endregion

        #region IStudentInfoList

        public int ID
        {
            get;
            private set;
        }

        public string Firstname
        {
            get { return txtFirstname.Text; }
        }

        public string Lastname
        {
            get { return txtLastname.Text; }
        }

        public int Course_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbCourse.SelectedValue), out value);
                return value;
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
        }

        public int SchoolYear_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbSchoolYear.SelectedValue), out value);
                return value;
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
        }

        public int Section_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbSection.SelectedValue), out value);
                return value;
            }            
        }

        public List<vstudentinfo> StudentInfoListDataSource
        {
            set
            {
                vstudentinfoBindingSource.DataSource = value;
            }
        }

        public void Notify(Common.Result result, List<string> messages)
        {
            throw new NotImplementedException();
        }

        public List<enroll_course> CourseDataSource
        {
            set
            {
                value.Insert(0, new enroll_course() { id = 0, name = "All" });
                cmbCourse.DisplayMember = "name";
                cmbCourse.ValueMember = "id";
                cmbCourse.DataSource = value;
            }
        }

        public List<enroll_level> LevelDataSource
        {
            set
            {
                value.Insert(0, new enroll_level() { id = 0, name = "All" });
                cmbLevel.DisplayMember = "name";
                cmbLevel.ValueMember = "id";
                cmbLevel.DataSource = value;
            }
        }

        public List<enroll_schoolyear> SchoolYearDataSource
        {
            set
            {
                value.Insert(0, new enroll_schoolyear() { id = 0, name = "All" });
                cmbSchoolYear.DisplayMember = "name";
                cmbSchoolYear.ValueMember = "id";
                cmbSchoolYear.DataSource = value;
            }
        }

        public List<enroll_semester> SemesterDataSource
        {
            set
            {
                value.Insert(0, new enroll_semester() { id = 0, name = "All" });
                cmbSemester.DisplayMember = "name";
                cmbSemester.ValueMember = "id";
                cmbSemester.DataSource = value;
            }
        }

        public List<enroll_section> SectionDataSource
        {
            set
            {
                value.Insert(0, new enroll_section() { id = 0, name = "All" });
                cmbSection.DisplayMember = "name";
                cmbSection.ValueMember = "id";
                cmbSection.DataSource = value;
            }
        }

        #endregion


    }
}
