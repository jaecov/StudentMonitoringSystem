using System;
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
    public partial class FormSchedule : WeifenLuo.WinFormsUI.Docking.DockContent, ISchedule
    {
        #region Constructor

        public FormSchedule()
        {
            InitializeComponent();
            grdSchedule.AutoGenerateColumns = false;
            Presenter = new SchedulePresenter(this);
            Name = string.Empty;
        }

        public SchedulePresenter Presenter
        {
            get;
            set;
        }

        #endregion

        #region Events

        private void FormSchedule_Load(object sender, EventArgs e)
        {
            Presenter.LoadItems();
        }

        private void grdSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            if (grdSchedule.CurrentRow == null)
                return;

            var data = grdSchedule.CurrentRow.DataBoundItem as vscheduleinfo;
            if (data == null)
                return;

            int id = data.id;
            Presenter.LoadScheduleInfo(id);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ID = 0;
            Name = string.Empty;
            Note = string.Empty;
            Course_ID = 0;
            Section_ID = 0;
            Employee_ID = 0;
            Subject_ID = 0;
            Room_ID = 0;
            Day_ID = 0;
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

        #region ISchedule

        public int ID
        {
            get;
            set;
        }

        public string Note
        {
            get { return txtNote.Text; }
            set { txtNote.Text = value; }
        }

        public List<vscheduleinfo> ScheduleDataSource
        {
            set
            {
                vScheduleBindingSource.DataSource = value;
            }
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

        public int Employee_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbEmployee.SelectedValue), out value);
                return value;
            }
            set
            {
                if (cmbEmployee.Items.Count > 0)
                    cmbEmployee.SelectedValue = value;
            }
        }

        public int Subject_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbSubject.SelectedValue), out value);
                return value;
            }
            set
            {
                if (cmbSubject.Items.Count > 0)
                    cmbSubject.SelectedValue = value;
            }
        }

        public int Room_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbRoom.SelectedValue), out value);
                return value;
            }
            set
            {
                if (cmbRoom.Items.Count > 0)
                    cmbRoom.SelectedValue = value;
            }
        }

        public int Day_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbDay.SelectedValue), out value);
                return value;
            }
            set
            {
                if (cmbDay.Items.Count > 0)
                    cmbDay.SelectedValue = value;
            }
        }

        public DateTime DateStart
        {
            get
            {
                DateTime value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                DateTime.TryParse(dteStart.Text, out value);
                return value;
            }
            set
            {
                dteStart.Value = value;
            }
        }

        public DateTime DateEnd
        {
            get
            {
                DateTime value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                DateTime.TryParse(dteEnd.Text, out value);
                return value;
            }
            set
            {
                dteEnd.Value = value;
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

        public List<enroll_section> SectionDataSource
        {
            set
            {
                value.Insert(0, new enroll_section() { id = 0, name = "Select" });
                cmbSection.DisplayMember = "name";
                cmbSection.ValueMember = "id";
                cmbSection.DataSource = value;
            }
        }

        public List<vemployeeinfo> EmployeeDataSource
        {
            set
            {
                value.Insert(0, new vemployeeinfo() { id = 0, fullname = "Select" });
                cmbEmployee.DisplayMember = "fullname";
                cmbEmployee.ValueMember = "id";
                cmbEmployee.DataSource = value;
            }
        }

        public List<enroll_subject> SubjectDataSource
        {
            set
            {
                value.Insert(0, new enroll_subject() { id = 0, name = "Select" });
                cmbSubject.DisplayMember = "name";
                cmbSubject.ValueMember = "id";
                cmbSubject.DataSource = value;
            }
        }

        public List<enroll_room> RoomDataSource
        {
            set
            {
                value.Insert(0, new enroll_room() { id = 0, name = "Select" });
                cmbRoom.DisplayMember = "name";
                cmbRoom.ValueMember = "id";
                cmbRoom.DataSource = value;
            }
        }

        public List<core_day> DayDataSource
        {
            set
            {
                value.Insert(0, new core_day() { id = 0, name = "Select" });
                cmbDay.DisplayMember = "name";
                cmbDay.ValueMember = "id";
                cmbDay.DataSource = value;
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

        #endregion
    }
}
