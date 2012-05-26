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
            this.grdStudents.DataSource = BO.Student.GetStudentByStatus(true).Select
                    (s => new { 
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
                        CreatedBy = s.employee.FirstName + ' ' + s.employee.LastName,
                        s.CreatedDate,
                        s.ModifiedBy,
                        s.ModifiedDate,
                        
                    }).ToList(); 
           
         
        }

        private void grdStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
