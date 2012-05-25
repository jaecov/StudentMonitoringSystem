using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using DataAccess;

namespace BusinessObjects
{
    public class Student
    {
        #region Business Methods

        private int m_StudentID;
        private string m_StudentNumber;
        private string m_FirstName;
        private string m_MiddleName;
        private string m_LastName;
        private DateTime m_Birthday;
        private string m_ImagePath;
        private string m_EmailAddress;
        private int m_SectionID;
        private int m_RFID;
        private string m_Note;

        public int StudentID
        {
            get { return m_StudentID; }
            set { m_StudentID = value; }
        }

        public string StudentNumber
        {
            get { return m_StudentNumber; }
            set { m_StudentNumber = value; }
        }

        public string FirstName
        {
            get { return m_FirstName; }
            set { m_FirstName = value; }
        }

        public string MiddleName
        {
            get { return m_MiddleName; }
            set { m_MiddleName = value; }
        }

        public string LastName
        {
            get { return m_LastName; }
            set { m_LastName = value; }
        }

        public DateTime Birthday
        {
            get { return m_Birthday; }
            set { m_Birthday = value; }
        }

        public string ImagePath
        {
            get { return m_ImagePath; }
            set { m_ImagePath = value; }
        }
        
        public string EmailAddress
        {
            get { return m_EmailAddress; }
            set { m_EmailAddress = value; }
        }

        public int SectionID
        {
            get { return m_SectionID; }
            set { m_SectionID = value; }
        }

        public int RFID
        {
            get { return m_RFID; }
            set { m_RFID = value; }
        }

        public string Note
        {
            get { return m_Note; }
            set { m_Note = value; }
        }

        #endregion

        public static void InsertStudent()
        {

            
            //using (smsEntities db = new smsEntities())
            //{
            //    student stud = new student();
            //    stud.StudentNumber = "1234";
            //    stud.FirstName = "Jake";
            //    stud.MiddleName = "santi";
            //    stud.LastName = "ddd";
            //    stud.Birthday = DateTime.Now;
            //    stud.CreatedBy = 1;
            //    stud.CreatedDate = DateTime.Now;

            //    db.AddTostudents(stud);
            //    db.SaveChanges();


            //}

          


        }


        //public static bool InsertUser(string Username, string Password)
        //{
        //    using (TrainingDBDataContext db = new TrainingDBDataContext())
        //    {
        //        DataAccess.User user = new DataAccess.User();
        //        user.UserName = Username;
        //        user.Password = Password;
        //        db.Users.InsertOnSubmit(user);
        //        db.SubmitChanges();

        //        UserList = null;
        //        return (user.ID != 0) ? true : false;
        //    }
        //}


    }
}   
