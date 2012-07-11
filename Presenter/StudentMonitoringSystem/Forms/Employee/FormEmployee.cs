using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentMonitoringSystem.Presenter;
using StudentMonitoringSystem.Presenter.Employee;
using System.Collections;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Forms.Employee
{
    public partial class FormEmployee : WeifenLuo.WinFormsUI.Docking.DockContent, IEmployee
    {

        #region Constructor

        public FormEmployee()
        {
            Presenter = new EmployeePresenter(this);
            InitializeComponent();
        }

        public EmployeePresenter Presenter
        {
            get;
            set;
        }

        #endregion

        #region IEmployee

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

        public List<vemployeeinfo> EmployeeDataSource
        {
            set
            {
                LoadEmployees(value);
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

        private List<emp_contact> contacts;
        public List<emp_contact> ContactDataSource
        {
            get { return contacts; }
            set
            {
                contacts = value;
                LoadContacts();
            }
        }

        #endregion

        #region BaseView

        public void Notify(Common.Result result, List<string> messages)
        {
            if (result == Common.Result.ValidationFailed)
            {
                StringBuilder validationmsgs = new StringBuilder();
                string msg = Common.Message(result);

                MessageBox.Show(msg);
            }
            else
            {
                string msg = Common.Message(result);
                MessageBox.Show(msg);
            }
        }

        #endregion

        #region Events

        private void Employee_Load(object sender, EventArgs e)
        {
            Presenter.LoadItems();
        }

        private void lvwEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwEmployee.SelectedItems.Count == 0)
                return;

            int id = (int)lvwEmployee.SelectedItems[0].Tag;
            Presenter.LoadEmployeeInfo(id);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ID = 0;
            Number = Common.GenerateNewNumber();
            Firstname = string.Empty;
            Middlename = string.Empty;
            Lastname = string.Empty;
            Gender_ID = 1;
            CivilStatus_ID = 1;
            DateOfBirth = DateTime.Now;
            Citizenship = string.Empty;
            Street = string.Empty;
            Province_ID = 0;
            City_ID = 0;
            Barangay_ID = 0;
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
                var result = Presenter.Delete();
                if (result)
                {
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

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            emp_contact contact = new emp_contact();
            contact.number = txtNumber.Text;
            contact.emailaddress = txtEmail.Text;
            contact.note = txtContactNote.Text;
            AddContact(contact);
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {

        }

        private void btnAddContact_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDeleteContact_Click_1(object sender, EventArgs e)
        {

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

        private void LoadEmployees(List<vemployeeinfo> list)
        {
            lvwEmployee.Items.Clear();
            ListViewItem item = null;

            foreach (var emp in list)
            {
                item = new ListViewItem();
                item.Tag = emp.id;
                item.Text = emp.number;
                item.SubItems.Add(string.Format("{0}, {1} {2}", emp.lastname, emp.firstname, emp.middlename));
                item.SubItems.Add(emp.gender);
                item.SubItems.Add(emp.civilstatus);
                item.SubItems.Add(emp.dateofbirth.ToString());
                item.SubItems.Add(emp.citizenship);
                item.SubItems.Add(string.Format("{0} {1}, {2}, {3}", emp.street, emp.barangay, emp.city, emp.province));
                lvwEmployee.Items.Add(item);
            }
        }

        private void LoadContacts()
        {
            lvwContact.Items.Clear();
            if (ContactDataSource == null)
                return;

            foreach (var contact in ContactDataSource)
            {
                AddContact(contact);
            }
        }

        private void AddContact(emp_contact contact)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = contact.id;
            item.Text = contact.number;
            item.SubItems.Add(contact.emailaddress);
            item.SubItems.Add(contact.note);
            lvwContact.Items.Add(item);
        }

        #endregion
    }
}
