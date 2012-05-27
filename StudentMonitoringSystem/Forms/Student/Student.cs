using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BO = BusinessObjects;

namespace StudentMonitoringSystem.Forms.Student
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            PopulateStudents(true);
        }



        #region Methods

        private void PopulateStudents(bool Status)
        {
            this.grdStudents.DataSource = BO.Student.GetStudentByStatus(Status).Select
                    (s => new
                    {
                        s.StudentID,
                        s.StudentNumber,
                        s.FirstName,
                        s.MiddleName,
                        s.LastName,
                        s.Birthday,
                        s.ImagePath,
                        s.EmailAddress,
                        s.section.SectionName,
                        s.Active,
                        CreatedBy = s.employee.FirstName + ' ' + s.employee.MiddleName + ' ' + s.employee.LastName,
                        s.CreatedDate,
                        s.ModifiedBy,
                        s.ModifiedDate
                    }).ToList(); 
        }


        #endregion

        #region Events

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void grdStudents_Click(object sender, EventArgs e)
        {
            //int orderId = (int)grdStudents.SelectedRows[0].Cells[0].Value;

            //this.grdStudents.SelectedCells[XXXXXXXXXXX].Value.ToString();
            this.txtStudentNumber.Text = this.grdStudents.SelectedCells[1].Value.ToString();
            //this.txtFirstName.Text      = this.grdStudents.SelectedRows[1].Cells[2].Value.ToString();
            //this.txtMiddleName.Text     = this.grdStudents.SelectedCells[3].Value.ToString();
            //this.txtLastName.Text       = this.grdStudents.SelectedCells[4].Value.ToString();
            //this.cmbBirthday.Text       = this.grdStudents.SelectedCells[5].Value.ToString();
            //this.cmbSection.Text        = this.grdStudents.SelectedCells[6].Value.ToString();
            //this.txtNumber.Text         = this.grdStudents.SelectedCells[7].Value.ToString();
            //this.txtEmail.Text          = this.grdStudents.SelectedCells[8].Value.ToString();
            //this.cmbGuardian.Text       = this.grdStudents.SelectedCells[9].Value.ToString();
            //this.txtGuardianNumber.Text = this.grdStudents.SelectedCells[10].Value.ToString();
            //this.txtGuardianEmail.Text  = this.grdStudents.SelectedCells[10].Value.ToString();
            //this.txtNote.Text           = this.grdStudents.SelectedCells[11].Value.ToString();
        }




    }
}
