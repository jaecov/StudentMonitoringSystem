using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Presenter.Enroll
{
    public class EnrolledYearPresenter : BasePresenter<IEnrolledYear>
    {
        #region Constructor

        public EnrolledYearPresenter(IEnrolledYear view)
        {
            View = view;
        }

        #endregion

        #region Load

        public void LoadItems()
        {
            LoadEnrolledYearDataSource();

            View.LevelDataSource = Controller.GetObject<enroll_level>().ToList();
            View.SchoolYearDataSource = Controller.GetObject<enroll_schoolyear>().ToList();
            View.SemesterDataSource = Controller.GetObject<enroll_semester>().ToList();
            View.CourseDataSource = Controller.GetObject<enroll_course>().ToList();
            View.SectionDataSource = Controller.GetObject<enroll_section>().ToList();
        }

        public void LoadEnrolledYearDataSource()
        {
            View.EnrolledYearDataSource = Controller.GetObject<venrolledyearinfo>().Where(c => c.student_id == View.Student_ID).ToList();
        }

        public void LoadEnrolledYearInfo(int id)
        {
            var item = Controller.GetObjectItemByColumnID<venrolledyearinfo>(id);
            if (item == null)
                return;

            View.ID = id;
            View.Level_ID = item.level_id;
            View.SchoolYear_ID = item.schoolyear_id;
            View.Semester_ID = item.semester_id;
            View.SchoolYear_ID = item.schoolyear_id;
            View.Course_ID = item.course_id;
            View.Section_ID = item.section_id;
            View.Note = item.note;
        }

        #endregion

        #region CRUD

        public bool Delete()
        {
            List<string> brokenRules = GetBrokenRules(Common.Operation.Delete);
            if (brokenRules.Count > 0)
            {
                View.Notify(Common.Result.ValidationFailed, brokenRules);
                return false;
            }

            try
            {
                var item = Controller.GetObjectItemByColumnID<enroll_schoolyear>(View.ID);
                if (item == null)
                    return false;

                Controller.DeleteObject<enroll_schoolyear>(item);
                LoadEnrolledYearDataSource();
                View.Notify(Common.Result.DeleteSuceeded, null);
                return true;
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.DeleteFailed, new List<string> { ex.ToString() });
                return false;
            }
        }

        public void Save()
        {
            if (View.ID == 0)
            {
                CreateEnrolledYear();
            }
            else
            {
                UpdateEnrolledYear();
            }
            LoadEnrolledYearDataSource();
        }

        private void CreateEnrolledYear()
        {
            try
            {
                List<string> brokenRules = GetBrokenRules(Common.Operation.Insert);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                var item = new enroll_enrolledyear();
                item.student_id = View.Student_ID;
                item.course_id = View.Course_ID;
                item.level_id = View.Level_ID;
                item.schoolyear_id = View.SchoolYear_ID;
                item.section_id = View.Section_ID;
                item.semester_id = View.Semester_ID;
                item.note = View.Note;

                var result = Controller.CreateObject<enroll_enrolledyear>(item);
                View.ID = result.id;
                View.Notify(Common.Result.InsertSucceeded, null);
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.InsertFailed, new List<string> { ex.ToString() });
            }
        }

        private void UpdateEnrolledYear()
        {
            try
            {
                List<string> brokenRules = GetBrokenRules(Common.Operation.Update);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                var item = Controller.GetObjectItemByColumnID<enroll_enrolledyear>(View.ID);
                if (item == null)
                {
                    throw new Exception("Can not update.Item not found.");
                }

                item.course_id = View.Course_ID;
                item.level_id = View.Level_ID;
                item.schoolyear_id = View.SchoolYear_ID;
                item.section_id = View.Section_ID;
                item.semester_id = View.Semester_ID;
                item.note = View.Note;

                Controller.UpdateObject<enroll_enrolledyear>(item);
                View.Notify(Common.Result.UpdateSuceeded, null);
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.UpdateFailed, new List<string> { ex.ToString() });
            }
        }

        #endregion

        #region Validation

        public List<string> GetBrokenRules(Common.Operation operation)
        {
            List<string> brokenRules = new List<string>();
            switch (operation)
            {
                case Common.Operation.Insert:
                    if (View.Student_ID == 0) brokenRules.Add("Student Id is required.");
                    if (View.Level_ID == 0) brokenRules.Add("Level is required.");
                    if (View.SchoolYear_ID == 0) brokenRules.Add("School year is required.");
                    if (View.Semester_ID == 0) brokenRules.Add("Semester is required.");
                    if (View.Section_ID == 0) brokenRules.Add("Section is required.");
                    if (View.Course_ID == 0) brokenRules.Add("Course is required.");

                    break;

                case Common.Operation.Update:
                    if (View.Level_ID == 0) brokenRules.Add("Level is required.");
                    if (View.SchoolYear_ID == 0) brokenRules.Add("School year is required.");
                    if (View.Semester_ID == 0) brokenRules.Add("Semester is required.");
                    if (View.Section_ID == 0) brokenRules.Add("Section is required.");
                    if (View.Course_ID == 0) brokenRules.Add("Course is required.");
                    break;

                case Common.Operation.Delete:
                    if (View.ID == 0) brokenRules.Add("Select record first.");
                    break;

                default:
                    break;
            }

            return brokenRules;
        }
        #endregion
    }
}
