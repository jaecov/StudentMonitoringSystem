using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Presenter.Enroll
{
    public class SubjectPresenter : BasePresenter<ISubject>
    {
        #region Constructor

        public SubjectPresenter(ISubject view)
        {
            View = view;
        }

        #endregion

        #region Load

        public void LoadItems()
        {            
            View.SubjectDataSource = Controller.GetObject<enroll_subject>().ToList();           
        }

        public void LoadSubjectInfo(int id)
        {
            var item = Controller.GetObjectItemByColumnID<enroll_subject>(id);
            if (item == null)
                return;

            View.ID = id;
            View.Name = item.name;
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
                var item = Controller.GetObjectItemByColumnID<enroll_subject>(View.ID);
                if (item == null)
                    return false;

                Controller.DeleteObject<enroll_subject>(item);
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
                CreateSubject();
            }
            else
            {
                UpdateSubject();
            }

            LoadItems();
        }

        private void CreateSubject()
        {
            try
            {
                List<string> brokenRules = GetBrokenRules(Common.Operation.Insert);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                var item = new enroll_subject();
                item.name = View.Name;
                item.note = View.Note;
                var result = Controller.CreateObject<enroll_subject>(item);
                View.ID = result.id;
                View.Notify(Common.Result.InsertSucceeded, null);
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.InsertFailed, new List<string> { ex.ToString() });
            }
        }

        private void UpdateSubject()
        {
            try
            {
                List<string> brokenRules = GetBrokenRules(Common.Operation.Update);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                var item = Controller.GetObjectItemByColumnID<enroll_subject>(View.ID);
                if (item == null)
                {
                    throw new Exception("Can not update.Item not found.");
                }

                item.name = View.Name;
                item.note = View.Note;
                Controller.UpdateObject<enroll_subject>(item);
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
                    break;

                case Common.Operation.Update:
                    if (View.ID == 0) brokenRules.Add("Select record first.");
                    if (View.Name == string.Empty) brokenRules.Add("Name is required.");                    
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
