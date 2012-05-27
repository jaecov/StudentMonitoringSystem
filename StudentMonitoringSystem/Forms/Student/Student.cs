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
                        s.RFID,
                        s.Note,
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

    }
}
