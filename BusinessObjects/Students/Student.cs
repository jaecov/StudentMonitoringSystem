using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using System.Collections;


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

        #region Factory

        /// <summary>
        /// Get all list of student by status
        /// </summary>
        /// <param name="status">Active = True, Inactive = False</param>
        /// <returns>List of student</returns>
        public static List<student> GetStudentByStatus(bool status)
        {
            try
            {
                return Fetch(new Criteria(CriteriaType.ByStatus, status));
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
                return Fetch(new Criteria(CriteriaType.ByStudentNumber, studentNumber));
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
                return Fetch(new Criteria(CriteriaType.BySection, sectionID));
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
                return Fetch(new Criteria(CriteriaType.ByName, name));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region DataAccess

        private enum CriteriaType
        {
            ByStatus,
            ByStudentNumber,
            BySection,
            ByName
        }

        private class Criteria
        {
            private CriteriaType m_Type;
            public CriteriaType Type
            {
                get { return m_Type; }
            }

            private bool m_Status;
            private string m_StudentNumber;
            private int m_Section;
            private string m_Name;

            public bool Status
            {
                get { return m_Status; }
                set { m_Status = value; }
            }

            public string StudentNumber
            {
                get { return m_StudentNumber; }
                set { m_StudentNumber = value; }
            }

            public int Section
            {
                get { return m_Section; }
                set { m_Section = value; }
            }

            public string Name
            {
                get { return m_Name; }
                set { m_Name = value; }
            }

            public Criteria(CriteriaType type, bool sParameter)
            {
                m_Type = type;
                switch (type)
                {
                    case CriteriaType.ByStatus:
                        m_Status = sParameter;
                        break;
                    default:
                        throw new Exception("Invalid criteria type.");
                }
            }

            public Criteria(CriteriaType type, string sParameter)
            {
                m_Type = type;
                switch (type)
                {
                    case CriteriaType.ByStudentNumber:
                        m_StudentNumber = sParameter;
                        break;
                    case CriteriaType.ByName:
                        m_Name = sParameter;
                        break;
                    default:
                        throw new Exception("Invalid criteria type.");
                }
            }

            public Criteria(CriteriaType type, int sParameter)
            {
                m_Type = type;
                switch (type)
                {
                    case CriteriaType.BySection:
                        m_Section = sParameter;
                        break;
                    default:
                        throw new Exception("Invalid criteria type.");
                }
            }
        }

        /// <summary>
        /// Get all list of active student
        /// </summary>
        /// <returns>List of active student</returns>
        private static List<student> Fetch(Criteria criteria)
        {
            try
            {
                if (StudentList != null) return StudentList;

                using (smsEntities db = new smsEntities())
                {
                    IList stud;

                    switch (criteria.Type)
                    {
                        case CriteriaType.ByStatus:
                            stud = (from x in db.students
                                       where x.Active == criteria.Status
                                       select x).ToList();
                            break;
                        case CriteriaType.BySection:
                            stud = (from x in db.students
                                   where x.SectionID == criteria.Section
                                    select x).ToList();
                            break;
                        case CriteriaType.ByStudentNumber:
                            stud = (from x in db.students
                                    where x.StudentNumber == criteria.StudentNumber
                                    select x).ToList();
                            break;
                        case CriteriaType.ByName:
                            stud = (from x in db.students
                                    where x.FirstName.StartsWith(criteria.Name) || x.LastName.StartsWith(criteria.Name)
                                    select x).ToList();
                            break;
                        default:
                            throw new Exception("Invalid CriteriaType.");
                        
                    }
                    return (List<student>)stud;
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
        public static bool InsertStudent(string studentNumber, string firstName, string middleName, string lastName, DateTime birthday, string note)
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
                    stud.Note = note;
                    stud.Active = true;
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
        public static bool UpdateStudent(int studentID, string studentNumber, string firstName, string middleName, string lastName, DateTime birthday, string note, bool studentStatus)
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
                    stud.Note = note;
                    stud.Active = studentStatus;
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
