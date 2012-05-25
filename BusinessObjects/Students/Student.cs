using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;

namespace BusinessObjects
{
    public class Student
    {
        #region Business Methods

        /// <summary>
        /// Cache StudentList
        /// </summary>
        private static List<student> StudentList;

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

        #region DataAccess

        /// <summary>
        /// Get all list of active student
        /// </summary>
        /// <returns>List of active student</returns>
        public static List<student> GetStudentByAllActive()
        {
            try
            {
                if (StudentList != null) return StudentList;

                using (smsEntities db = new smsEntities())
                {
                    var stud = from x in db.students
                               where x.Active == true
                                select x;

                    StudentList = stud.ToList();
                    return StudentList;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Get all list of inactive student
        /// </summary>
        /// <returns>List of inactive student</returns>
        public static List<student> GetStudentByAllInActive()
        {
            try
            {
                if (StudentList != null) return StudentList;

                using (smsEntities db = new smsEntities())
                {
                    var stud = from x in db.students
                               where x.Active == false
                               select x;

                    StudentList = stud.ToList();
                    return StudentList;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Get student by studet number
        /// </summary>
        /// <returns>Specific student by student number</returns>
        public static List<student> GetStudentByStudentNumber(string studentNumber)
        {
            try
            {
                using (smsEntities db = new smsEntities())
                {
                    var stud = from x in db.students
                               where x.StudentNumber == studentNumber
                               select x;

                    return stud.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Get student by section
        /// </summary>
        /// <returns>Specific student by section</returns>
        public static List<student> GetStudentBySectionID(int sectionID)
        {
            try
            {
                using (smsEntities db = new smsEntities())
                {
                    var stud = from x in db.students
                               where x.SectionID == sectionID
                               select x;

                    return stud.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Get student by name
        /// </summary>
        /// <returns>Specific student by name</returns>
        public static List<student> GetStudentByName(string name)
        {
            try
            {
                using (smsEntities db = new smsEntities())
                {
                    var stud = from x in db.students
                               where x.FirstName.StartsWith(name) || x.LastName.StartsWith(name)
                               select x;

                    return stud.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Insert new student
        /// </summary>
        /// <param name="studentNumber"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthday"></param>
        /// <returns>True if added successfully otherwise false if not.</returns>
        public static bool InsertStudent(string studentNumber, string firstName, string middleName, string lastName, DateTime birthday)
        {
            try
            {
                using (smsEntities db = new smsEntities())
                {
                    student stud = new student();
                    stud.StudentNumber = studentNumber;
                    stud.FirstName = firstName;
                    stud.MiddleName = middleName;
                    stud.LastName = lastName;
                    stud.Birthday = birthday;
                    stud.CreatedBy = 1;
                    stud.CreatedDate = DateTime.Now;

                    db.AddTostudents(stud);
                    db.SaveChanges();
                    StudentList = null;

                    return (stud.StudentID != 0) ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Update existing student
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="studentNumber"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthday"></param>
        /// <returns>True if updated successfully otherwise false if not.</returns>
        public static bool UpdateStudent(int studentID, string studentNumber, string firstName, string middleName, string lastName, DateTime birthday)
        {
            try
            {
                using (smsEntities db = new smsEntities())
                {
                    student stud = db.students.Single(u => u.StudentID == studentID);
                    stud.StudentNumber = studentNumber;
                    stud.FirstName = firstName;
                    stud.MiddleName = middleName;
                    stud.LastName = lastName;
                    stud.Birthday = birthday;
                    stud.ModifiedBy = 1;
                    stud.ModifiedDate = DateTime.Now;

                    db.SaveChanges();
                    StudentList = null;

                    return (stud.StudentID != 0) ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Deactivate existing student
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns>True if deactivate successfully otherwise false if not.</returns>
        public static bool DeactivateStudent(int studentID)
        {
            try
            {
                using (smsEntities db = new smsEntities())
                {
                    student stud = db.students.Single(u => u.StudentID == studentID);
                    stud.Active = false;
                    stud.ModifiedBy = 1;
                    stud.ModifiedDate = DateTime.Now;

                    db.SaveChanges();
                    StudentList = null;

                    return (stud.StudentID != 0) ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Activate existing student
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns>True if activate successfully otherwise false if not.</returns>
        public static bool ActivateStudent(int studentID)
        {
            try
            {
                using (smsEntities db = new smsEntities())
                {
                    student stud = db.students.Single(u => u.StudentID == studentID);
                    stud.Active = true;
                    stud.ModifiedBy = 1;
                    stud.ModifiedDate = DateTime.Now;

                    db.SaveChanges();
                    StudentList = null;
                    
                    return (stud.StudentID != 0) ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion

    }
}   
