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
using StudentMonitoringSystem.Presenter.Enroll;
using System.Collections;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Forms.Core
{
    public partial class FormStudent : WeifenLuo.WinFormsUI.Docking.DockContent, IStudent
    {

        #region Constructor

        public FormStudent()
        {
            InitializeComponent();
            Presenter = new StudentPresenter(this);
            formGuardian = new FormGuardian(this);
            formContact = new FormContact(this);
            formEnrolledYear = new FormEnrolledYear(this);
        }

        public StudentPresenter Presenter
        {
            get;
            set;
        }

        #endregion

        #region Variables

        FormContact formContact;
        FormGuardian formGuardian;
        FormEnrolledYear formEnrolledYear;
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

        public int CivilStatus_ID
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

        public int Gender_ID
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

        public string Note
        {
            get
            {
                return txtNote.Text;
            }
            set
            {
                txtNote.Text = value;
            }
        }

        string picture;
        public string Picture
        {
            get
            {
                return picture;
            }
            set
            {
                picture = value;
                pctStudent.ImageLocation = picture;
            }
        }

        public string Street
        {
            get
            {
                return txtStreet.Text;
            }
            set
            {
                txtStreet.Text = value;
            }
        }

        public int Barangay_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbBarangay.SelectedValue), out value);
                return value;
            }
            set
            {
                if (cmbBarangay.Items.Count > 0)
                    cmbBarangay.SelectedValue = value;

            }
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

        public int Province_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(cmbProvince.SelectedValue), out value);
                return value;
            }
            set
            {
                if (cmbProvince.Items.Count > 0)
                    cmbProvince.SelectedValue = value;
            }
        }

        public string FatherName
        {
            get
            {
                return txtFatherName.Text;
            }
            set
            {
                txtFatherName.Text = value;
            }
        }

        public string FatherOccupation
        {
            get
            {
                return txtFatherOccupation.Text;
            }
            set
            {
                txtFatherOccupation.Text = value;
            }
        }

        public string FatherAddress
        {
            get
            {
                return txtFatherAddress.Text;
            }
            set
            {
                txtFatherAddress.Text = value;
            }
        }

        public string FatherContactNumber
        {
            get
            {
                return txtFatherContactNo.Text;
            }
            set
            {
                txtFatherContactNo.Text = value;
            }
        }

        public string MotherName
        {
            get
            {
                return txtMotherName.Text;
            }
            set
            {
                txtMotherName.Text = value;
            }
        }

        public string MotherOccupation
        {
            get
            {
                return txtMotherOccupation.Text;
            }
            set
            {
                txtMotherOccupation.Text = value;
            }
        }

        public string MotherAddress
        {
            get
            {
                return txtMotherAddress.Text;
            }
            set
            {
                txtMotherAddress.Text = value;
            }
        }

        public string MotherContactNumber
        {
            get
            {
                return txtMotherContactNo.Text;
            }
            set
            {
                txtMotherContactNo.Text = value;
            }
        }

        public List<core_guardian> GuardianDataSource
        {
            set { coreguardianBindingSource.DataSource = value; }
        }

        public List<core_civilstatus> CivilStatusDataSource
        {
            set
            {
                value.Insert(0, new core_civilstatus() { id = 0, name = "Select" });
                cmbCivilStatus.DisplayMember = "name";
                cmbCivilStatus.ValueMember = "id";
                cmbCivilStatus.DataSource = value;
            }
        }

        public List<core_gender> GenderDataSource
        {
            set
            {
                value.Insert(0, new core_gender() { id = 0, name = "Select" });
                cmbGender.DisplayMember = "name";
                cmbGender.ValueMember = "id";
                cmbGender.DataSource = value;
            }
        }

        public List<vstudentinfo> StudentDataSource
        {
            set
            {
                vstudentinfoBindingSource.DataSource = value;
            }
        }

        public List<core_barangay> BarangayDataSource
        {
            set
            {
                value.Insert(0, new core_barangay() { id = 0, name = "Select" });
                cmbBarangay.DisplayMember = "name";
                cmbBarangay.ValueMember = "id";
                cmbBarangay.DataSource = value;
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

        public List<core_province> ProvinceDataSource
        {
            set
            {
                value.Insert(0, new core_province() { id = 0, name = "Select" });
                cmbProvince.DisplayMember = "name";
                cmbProvince.ValueMember = "id";
                cmbProvince.DataSource = value;
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

        #region Events

        private void Student_Load(object sender, EventArgs e)
        {
            Presenter.LoadItems();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool ok = false;
            int studentId = 0;
            FormStudentInfoList form = new FormStudentInfoList();
            var result = form.ShowAsDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                studentId = form.ID;
                View(studentId);
            }
        }

        private void View(int studentId)
        {
            Presenter.LoadStudentInfo(studentId);
            formContact.LoadItems();
            formContact.Reset();
            formGuardian.LoadItems();
            formGuardian.Reset();
            formEnrolledYear.LoadItems();
            formEnrolledYear.Reset();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (SelectedTab == Tab.Contact)
            {
                formContact.Reset();
            }
            else if (SelectedTab == Tab.Guardian)
            {
                formGuardian.Reset();
            }
            else if (SelectedTab == Tab.Enrollment)
            {
                formEnrolledYear.Reset();
            }
            else
            {
                ID = 0;
                Number = string.Empty;
                Firstname = string.Empty;
                Middlename = string.Empty;
                Lastname = string.Empty;
                Gender_ID = 0;
                CivilStatus_ID = 0;
                DateOfBirth = DateTime.Now;
                Citizenship = string.Empty;
                Street = string.Empty;
                Province_ID = 0;
                City_ID = 0;
                Barangay_ID = 0;
                Note = string.Empty;
                Picture = string.Empty;
                FatherName = string.Empty;
                FatherAddress = string.Empty;
                FatherContactNumber = string.Empty;
                FatherOccupation = string.Empty;
                MotherName = string.Empty;
                MotherAddress = string.Empty;
                MotherContactNumber = string.Empty;
                MotherOccupation = string.Empty;

                formContact.ResetAll();
                formGuardian.ResetAll();
                formEnrolledYear.ResetAll();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SelectedTab == Tab.Contact)
            {
                formContact.Save();
            }
            else if (SelectedTab == Tab.Guardian)
            {
                formGuardian.Save();
            }
            else if (SelectedTab == Tab.Enrollment)
            {
                formEnrolledYear.Save();
            }
            else
            {
                var answer = Confirm("Do you want to save? Click OK to proceed.");
                if (answer)
                    Presenter.Save();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedTab == Tab.Contact)
            {
                formContact.Delete();
            }
            else if (SelectedTab == Tab.Guardian)
            {
                formGuardian.Delete();
            }
            else if (SelectedTab == Tab.Enrollment)
            {
                formEnrolledYear.Delete();
            }
            else
            {
                var answer = Confirm("Do you want to delete? Click OK to proceed");
                if (answer)
                {
                    Presenter.Delete();
                    btnReset_Click(sender, e);
                }
            }
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvince.SelectedValue != null)
            {
                int id = Convert.ToInt32(cmbProvince.SelectedValue);
                Presenter.LoadCityDataSource(id);
            }
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCity.SelectedValue != null)
            {
                int id = Convert.ToInt32(cmbCity.SelectedValue);
                Presenter.LoadBarangayDataSource(id);
            }
        }

        private void btnWebcam_Click(object sender, EventArgs e)
        {
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmap |*.bmp | JPG|*.jpg | GIF|*.gif | All Files|*.*";
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {

                Picture = openFileDialog.FileName;
            }
        }

        #region Contact

        private void txtNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtNumber.Text.Trim().Length >= 5)
            {
                lblNetwork.Text = Presenter.GetProvider(txtNumber.Text.Trim().Substring(0, 4));
            }
        }

        private void grdContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex <= -1 || e.RowIndex <= -1)
                return;

            if (grdContact.CurrentRow == null)
                return;

            var data = grdContact.CurrentRow.DataBoundItem as core_contact;
            if (data == null)
                return;

            int id = data.id;
            formContact.LoadContactInfo(id);
            txtNumber_KeyUp(null, null);
        }

        #endregion

        #region Guardian

        private void txtGNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtGNumber.Text.Trim().Length >= 5)
            {
                lblGNetwork.Text = Presenter.GetProvider(txtGNumber.Text.Trim().Substring(0, 4));
            }
        }

        private void grdGuardian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex <= -1 || e.RowIndex <= -1)
                return;

            if (grdGuardian.CurrentRow == null)
                return;

            var data = grdGuardian.CurrentRow.DataBoundItem as core_guardian;
            if (data == null)
                return;

            int id = data.id;
            formGuardian.LoadGuardianInfo(id);
            txtGNumber_KeyUp(null, null);
        }

        #endregion

        #region EnrolledYear

        private void grdEnrolledYear_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex <= -1 || e.RowIndex <= -1)
                return;

            if (grdEnrolledYear.CurrentRow == null)
                return;

            var data = grdEnrolledYear.CurrentRow.DataBoundItem as venrolledyearinfo;
            if (data == null)
                return;

            int id = data.id;
            this.formEnrolledYear.LoadEnrolledYearInfo(id);
        }

        #endregion

        #endregion

        #region Methods

        enum Tab
        {
            StudentInfo = 0,
            Contact = 1,
            Guardian = 2,
            Enrollment = 3
        }

        private Tab SelectedTab
        {
            get
            {
                if (this.tabControl1.SelectedTab == tabContact)
                {
                    return Tab.Contact;
                }
                else if (this.tabControl1.SelectedTab == tabGuardian)
                {
                    return Tab.Guardian;
                }
                else if (this.tabControl1.SelectedTab == tabEnrollment)
                {
                    return Tab.Enrollment;
                }
                else
                {
                    return Tab.StudentInfo;
                }
            }
        }

        public bool Confirm(string msg, string title = "Confirm")
        {
            var result = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
                return true;
            else
                return false;
        }

        #endregion

    }

    #region Contact

    public class FormContact : IContact
    {
        FormStudent parent;
        public FormContact(FormStudent emp)
        {
            Presenter = new ContactPresenter(this);
            parent = emp;
        }

        public ContactPresenter Presenter
        { get; set; }

        #region IContact

        public int ID
        {
            get;
            set;
        }

        public string Number
        {
            get
            {
                return parent.txtNumber.Text.Replace("-", "");
            }
            set
            {
                parent.txtNumber.Text = value;
            }
        }

        public string Emailaddress
        {
            get
            {
                return parent.txtEmail.Text;
            }
            set
            {
                parent.txtEmail.Text = value;
            }
        }

        public string Note
        {
            get
            {
                return parent.txtContactNote.Text;
            }
            set
            {
                parent.txtContactNote.Text = value;
            }
        }

        public int Student_ID
        {
            get { return parent.ID; }
        }

        public List<core_contact> ContactDataSource
        {
            set
            {
                parent.corecontactBindingSource.DataSource = value;
            }
        }

        public void Notify(Common.Result result, List<string> messages)
        {
            parent.Notify(result, messages);
        }

        #endregion

        #region Methods

        public void ResetAll()
        {
            Reset();
            ContactDataSource = null;
        }

        public void Reset()
        {
            this.ID = 0;
            this.Number = string.Empty;
            this.Emailaddress = string.Empty;
            this.Note = string.Empty;
            parent.lblNetwork.Text = string.Empty;
        }

        public void LoadItems()
        {
            Presenter.LoadItems();
        }

        public void LoadContactInfo(int id)
        {
            Presenter.LoadContactInfo(id);
        }

        public void Save()
        {
            var answer = parent.Confirm("Do you want to save? Click OK to proceed.", "Contact");
            if (answer)
                Presenter.Save();
        }

        public void Delete()
        {
            var answer = parent.Confirm("Do you want to delete? Click OK to proceed", "Contact");
            if (answer)
            {

                Presenter.Delete();
                Reset();
            }
        }

        #endregion
    }

    #endregion

    #region Guardian

    public class FormGuardian : IGuardian
    {
        FormStudent parent;
        public FormGuardian(FormStudent form)
        {
            Presenter = new GuardianPresenter(this);
            parent = form;
        }

        public GuardianPresenter Presenter
        { get; set; }

        #region IGuardian

        public int ID
        {
            get;
            set;
        }

        public string Name
        {
            get
            {
                return parent.txtGName.Text;
            }
            set
            {
                parent.txtGName.Text = value;
            }
        }

        public string Address
        {
            get
            {
                return parent.txtGAddress.Text;
            }
            set
            {
                parent.txtGAddress.Text = value;
            }
        }

        public string Relationship
        {
            get
            {
                return parent.txtGRelationship.Text;
            }
            set
            {
                parent.txtGRelationship.Text = value;
            }
        }

        public string Number
        {
            get
            {
                return parent.txtGNumber.Text.Replace("-", "");
            }
            set
            {
                parent.txtGNumber.Text = value;
            }
        }

        public string Emailaddress
        {
            get
            {
                return parent.txtGEmailAddress.Text;
            }
            set
            {
                parent.txtGEmailAddress.Text = value;
            }
        }

        public string Note
        {
            get
            {
                return parent.txtGNote.Text;
            }
            set
            {
                parent.txtGNote.Text = value;
            }
        }

        public int Student_ID
        {
            get { return parent.ID; }
        }

        public List<core_guardian> GuardianDataSource
        {
            set
            {
                parent.coreguardianBindingSource.DataSource = value;
            }
        }

        public void Notify(Common.Result result, List<string> messages)
        {
            parent.Notify(result, messages);
        }

        #endregion

        #region Methods

        public void ResetAll()
        {
            Reset();
            GuardianDataSource = null;
        }

        public void Reset()
        {
            this.ID = 0;
            this.Name = string.Empty;
            this.Address = string.Empty;
            this.Relationship = string.Empty;
            this.Number = string.Empty;
            this.Emailaddress = string.Empty;
            this.Note = string.Empty;
            parent.lblGNetwork.Text = string.Empty;
        }

        public void LoadItems()
        {
            Presenter.LoadItems();
        }

        public void LoadGuardianInfo(int id)
        {
            Presenter.LoadGuardianInfo(id);
        }

        public void Save()
        {
            var answer = parent.Confirm("Do you want to save? Click OK to proceed.", "Guardian");
            if (answer)
                Presenter.Save();
        }

        public void Delete()
        {
            var answer = parent.Confirm("Do you want to delete? Click OK to proceed", "Guardian");
            if (answer)
            {
                Presenter.Delete();
                Reset();
            }
        }

        #endregion

    }

    #endregion

    #region EnrolledYear

    public class FormEnrolledYear : IEnrolledYear
    {
        FormStudent parent;
        public FormEnrolledYear(FormStudent form)
        {
            Presenter = new EnrolledYearPresenter(this);
            parent = form;

            LoadItems();
        }

        public EnrolledYearPresenter Presenter
        { get; set; }

        #region IEnrolledYear

        public int ID
        {
            get;
            set;
        }

        public int Student_ID
        {
            get { return parent.ID; }
        }

        public int Course_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(parent.cmbCourse.SelectedValue), out value);
                return value;
            }
            set
            {
                if (parent.cmbCourse.Items.Count > 0)
                    parent.cmbCourse.SelectedValue = value;
            }
        }

        public int Level_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(parent.cmbLevel.SelectedValue), out value);
                return value;
            }
            set
            {
                if (parent.cmbLevel.Items.Count > 0)
                    parent.cmbLevel.SelectedValue = value;
            }
        }

        public int SchoolYear_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(parent.cmbSchoolYear.SelectedValue), out value);
                return value;
            }
            set
            {
                if (parent.cmbSchoolYear.Items.Count > 0)
                    parent.cmbSchoolYear.SelectedValue = value;
            }
        }

        public int Semester_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(parent.cmbSemester.SelectedValue), out value);
                return value;
            }
            set
            {
                if (parent.cmbSemester.Items.Count > 0)
                    parent.cmbSemester.SelectedValue = value;
            }
        }

        public int Section_ID
        {
            get
            {
                int value = 0;
                int.TryParse(Convert.ToString(parent.cmbSection.SelectedValue), out value);
                return value;
            }
            set
            {
                if (parent.cmbSection.Items.Count > 0)
                    parent.cmbSection.SelectedValue = value;
            }
        }

        public string Note
        {
            get { return parent.txtEnrollmentNote.Text; }
            set { parent.txtEnrollmentNote.Text = value; }
        }

        public void Notify(Common.Result result, List<string> messages)
        {
            parent.Notify(result, messages);
        }

        public List<venrolledyearinfo> EnrolledYearDataSource
        {
            set
            {
                parent.venrolledyearinfoBindingSource.DataSource = value;
            }
        }

        public List<enroll_course> CourseDataSource
        {
            set
            {
                value.Insert(0, new enroll_course() { id = 0, name = "Select" });
                parent.cmbCourse.DisplayMember = "name";
                parent.cmbCourse.ValueMember = "id";
                parent.cmbCourse.DataSource = value;
            }
        }

        public List<enroll_level> LevelDataSource
        {
            set
            {
                value.Insert(0, new enroll_level() { id = 0, name = "Select" });
                parent.cmbLevel.DisplayMember = "name";
                parent.cmbLevel.ValueMember = "id";
                parent.cmbLevel.DataSource = value;
            }
        }

        public List<enroll_schoolyear> SchoolYearDataSource
        {
            set
            {
                value.Insert(0, new enroll_schoolyear() { id = 0, name = "Select" });
                parent.cmbSchoolYear.DisplayMember = "name";
                parent.cmbSchoolYear.ValueMember = "id";
                parent.cmbSchoolYear.DataSource = value;
            }
        }

        public List<enroll_semester> SemesterDataSource
        {
            set
            {
                value.Insert(0, new enroll_semester() { id = 0, name = "Select" });
                parent.cmbSemester.DisplayMember = "name";
                parent.cmbSemester.ValueMember = "id";
                parent.cmbSemester.DataSource = value;
            }
        }

        public List<enroll_section> SectionDataSource
        {
            set
            {
                value.Insert(0, new enroll_section() { id = 0, name = "Select" });
                parent.cmbSection.DisplayMember = "name";
                parent.cmbSection.ValueMember = "id";
                parent.cmbSection.DataSource = value;
            }
        }

        #endregion

        #region Methods

        public void ResetAll()
        {
            Reset();
            EnrolledYearDataSource = null;
        }

        public void Reset()
        {
            this.ID = 0;
            this.Level_ID = 0;
            this.SchoolYear_ID = 0;
            this.Semester_ID = 0;
            this.Course_ID = 0;
            this.Section_ID = 0;
            this.Note = string.Empty;
        }

        public void LoadItems()
        {
            Presenter.LoadItems();
        }

        public void LoadEnrolledYearInfo(int id)
        {
            Presenter.LoadEnrolledYearInfo(id);
        }

        public void Save()
        {
            var answer = parent.Confirm("Do you want to save? Click OK to proceed.", "Enrollment");
            if (answer)
                Presenter.Save();
        }

        public void Delete()
        {
            var answer = parent.Confirm("Do you want to delete? Click OK to proceed", "Enrollment");
            if (answer)
            {
                Presenter.Delete();
                Reset();
            }
        }

        #endregion



    }
    #endregion

}
