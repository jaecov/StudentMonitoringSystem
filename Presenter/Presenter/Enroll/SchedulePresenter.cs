using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Presenter.Enroll
{
    public class SchedulePresenter : BasePresenter<ISchedule>
    {
        #region Constructor

        public SchedulePresenter(ISchedule view)
        {
            View = view;
        }

        #endregion

        #region Load

        public void LoadItems()
        {
            View.CourseDataSource = Controller.GetObject<enroll_course>().ToList();            
            View.EmployeeDataSource = Controller.GetObject<vemployeeinfo>().ToList();
            View.SubjectDataSource = Controller.GetObject<enroll_subject>().ToList();
            View.RoomDataSource = Controller.GetObject<enroll_room>().ToList();
            View.DayDataSource = Controller.GetObject<core_day>().ToList();
            LoadScheduleDataSource();
        }

        public void LoadScheduleDataSource()
        {
            View.ScheduleDataSource = Controller.GetObject<vscheduleinfo>().ToList();
        }

        public void LoadSectionDataSource(int course_id)
        {
            View.SectionDataSource = Controller.GetObject<enroll_section>().Where(c => c.course_id == course_id).ToList();
        }

        public void LoadScheduleInfo(int id)
        {
            var item = Controller.GetObjectItemByColumnID<vscheduleinfo>(id);
            if (item == null)
            {
                throw new Exception("Item not found.");
            }

            View.ID = id;
            View.Course_ID = item.course_id;
            View.Section_ID = item.section_id;
            View.Employee_ID = item.employee_id;
            View.Subject_ID = item.subject_id;
            View.Room_ID = item.room_id;
            View.Day_ID = item.day_id;
            View.DateStart = item.datestart;
            View.DateEnd = item.dateend;
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
                var item = Controller.GetObjectItemByColumnID<enroll_schedule>(View.ID);
                if (item == null)
                {
                    throw new Exception("Item not found.");
                }

                Controller.DeleteObject<enroll_schedule>(item);
                LoadScheduleDataSource();
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
                CreateSchedule();
            }
            else
            {
                UpdateSchedule();
            }

            LoadScheduleDataSource();
        }

        private void CreateSchedule()
        {
            try
            {
                List<string> brokenRules = GetBrokenRules(Common.Operation.Insert);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                var item = new enroll_schedule();
                item.id = View.ID;
                item.section_id = View.Section_ID;
                item.employee_id = View.Employee_ID;
                item.subject_id = View.Subject_ID;
                item.room_id = View.Room_ID;
                item.day_id = View.Day_ID;
                item.datestart = View.DateStart;
                item.dateend = View.DateEnd;
                item.note = View.Note;

                var result = Controller.CreateObject<enroll_schedule>(item);
                View.ID = result.id;
                View.Notify(Common.Result.InsertSucceeded, null);
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.InsertFailed, new List<string> { ex.ToString() });
            }
        }

        private void UpdateSchedule()
        {
            try
            {
                List<string> brokenRules = GetBrokenRules(Common.Operation.Update);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                var item = Controller.GetObjectItemByColumnID<enroll_schedule>(View.ID);
                if (item == null)
                {
                    throw new Exception("Can not update.Item not found.");
                }
                item.section_id = View.Section_ID;
                item.employee_id = View.Employee_ID;
                item.subject_id = View.Subject_ID;
                item.room_id = View.Room_ID;
                item.day_id = View.Day_ID;
                item.datestart = View.DateStart;
                item.dateend = View.DateEnd;
                item.note = View.Note;

                Controller.UpdateObject<enroll_schedule>(item);
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
                    if (View.Section_ID == 0) brokenRules.Add("Section is required.");
                    if (View.Employee_ID == 0) brokenRules.Add("Employee is required.");
                    if (View.Subject_ID == 0) brokenRules.Add("Subject is required.");
                    if (View.Room_ID == 0) brokenRules.Add("Room is required.");
                    if (View.Day_ID == 0) brokenRules.Add("Day is required.");
                    if (View.DateStart == null) brokenRules.Add("Start date is required.");
                    if (View.DateEnd == null) brokenRules.Add("End date is required.");
                    break;

                case Common.Operation.Update:
                    if (View.ID == 0) brokenRules.Add("Select record first.");                                        
                    if (View.Section_ID == 0) brokenRules.Add("Section is required.");
                    if (View.Employee_ID == 0) brokenRules.Add("Employee is required.");
                    if (View.Subject_ID == 0) brokenRules.Add("Subject is required.");
                    if (View.Room_ID == 0) brokenRules.Add("Room is required.");
                    if (View.Day_ID == 0) brokenRules.Add("Day is required.");
                    if (View.DateStart == null) brokenRules.Add("Start date is required.");
                    if (View.DateEnd == null) brokenRules.Add("End date is required.");
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
