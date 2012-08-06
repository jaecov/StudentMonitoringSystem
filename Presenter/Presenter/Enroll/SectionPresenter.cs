using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Presenter.Enroll
{
    public class SectionPresenter : BasePresenter<ISection>
    {
        #region Constructor

        public SectionPresenter(ISection view)
        {
            View = view;
        }

        #endregion

        #region Load

        public void LoadItems()
        {            
            View.CourseDataSource = Controller.GetObject<enroll_course>().ToList();
            LoadSectionDataSource();
        }

        public void LoadSectionDataSource()
        {
            View.SectionDataSource = Controller.GetObject<vsectioninfo>().ToList();
        }

        public void LoadSectionInfo(int id)
        {
            var item = Controller.GetObjectItemByColumnID<enroll_section>(id);
            if (item == null)
                return;

            View.ID = id;
            View.Name = item.name;
            View.Course_ID = item.course_id;
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
                var item = Controller.GetObjectItemByColumnID<enroll_section>(View.ID);
                if (item == null)
                    return false;

                Controller.DeleteObject<enroll_section>(item);
                LoadItems();
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
                CreateSection();
            }
            else
            {
                UpdateSection();
            }

            LoadSectionDataSource();
        }

        private void CreateSection()
        {
            try
            {
                List<string> brokenRules = GetBrokenRules(Common.Operation.Insert);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                var item = new enroll_section();
                item.name = View.Name;
                item.course_id = View.Course_ID;

                var result = Controller.CreateObject<enroll_section>(item);
                View.ID = result.id;
                View.Notify(Common.Result.InsertSucceeded, null);
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.InsertFailed, new List<string> { ex.ToString() });
            }
        }

        private void UpdateSection()
        {
            try
            {
                List<string> brokenRules = GetBrokenRules(Common.Operation.Update);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                var item = Controller.GetObjectItemByColumnID<enroll_section>(View.ID);
                if (item == null)
                    return;

                item.name = View.Name;
                item.course_id = View.Course_ID;

                Controller.UpdateObject<enroll_section>(item);
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
                    if (View.Name == string.Empty) brokenRules.Add("Name is required.");
                    if (View.Course_ID == 0) brokenRules.Add("Course is required.");
                    break;

                case Common.Operation.Update:
                    if (View.ID == 0) brokenRules.Add("Select record first.");
                    if (View.Name == string.Empty) brokenRules.Add("Name is required.");
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
