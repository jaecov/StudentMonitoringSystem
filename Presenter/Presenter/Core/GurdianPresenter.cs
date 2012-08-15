using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Presenter.Core
{
    public class GuardianPresenter : BasePresenter<IGuardian>
    {
        #region Constructor

        public GuardianPresenter(IGuardian view)
        {
            View = view;
        }

        #endregion

        #region Load

        public void LoadItems()
        {
            View.GuardianDataSource = Controller.GetObject<core_guardian>()
                                               .Where(c => c.student_id == View.Student_ID)
                                               .ToList();
        }

        #endregion

        #region Get

        private void GetValues(ref core_guardian item)
        {
            item.id = View.ID;
            item.name = View.Name;
            item.address = View.Address;
            item.relationship = View.Relationship;

            item.student_id = View.Student_ID;
            item.number = View.Number;
            item.emailaddress = View.Emailaddress;
            item.note = View.Note;
        }

        public void LoadGuardianInfo(int id)
        {
            var item = Controller.GetObjectItemByColumnID<core_guardian>(id);
            if (item == null)
                return;

            View.Name = item.name;
            View.Address = item.address;
            View.Relationship = item.relationship;
            View.Emailaddress = item.emailaddress;
            View.Number = item.number;
            View.Note = item.note;
            View.ID = item.id;
        }

        #endregion

        #region CRUD

        public bool Delete()
        {
            if (View.ID > 0)
            {
                try
                {
                    var item = Controller.GetObjectItemByColumnID<core_guardian>(View.ID);
                    if (item == null)
                        return false;

                    Controller.DeleteObject<core_guardian>(item);
                    LoadItems();
                    View.Notify(Common.Result.DeleteSuceeded, null);
                    return true;
                }
                catch (Exception ex)
                {
                    View.Notify(Common.Result.DeleteFailed, new List<string> { ex.ToString() });
                }
            }
            return false;
        }

        public void Save()
        {
            if (View.ID == 0)
            {
                CreateGuardian();
            }
            else
            {
                UpdateGuardian();
            }

            LoadItems();
        }

        private void CreateGuardian()
        {
            try
            {

                List<string> brokenRules = BrokenRules(Common.Operation.Insert);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                var item = new core_guardian();
                GetValues(ref item);
                var result = Controller.CreateObject<core_guardian>(item);
                View.ID = result.id;
                View.Notify(Common.Result.InsertSucceeded, null);
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.InsertFailed, new List<string> { ex.ToString() });
            }
        }

        private void UpdateGuardian()
        {
            try
            {
                List<string> brokenRules = BrokenRules(Common.Operation.Update);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                var item = Controller.GetObjectItemByColumnID<core_guardian>(View.ID);
                if (item == null)
                {
                    throw new Exception("Can not update.Item not found.");
                }

                GetValues(ref item);
                Controller.UpdateObject<core_guardian>(item);
                View.Notify(Common.Result.UpdateSuceeded, null);
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.UpdateFailed, new List<string> { ex.ToString() });
            }
        }

        #endregion

        #region Validation

        public List<string> BrokenRules(Common.Operation operation)
        {
            List<string> brokenRules = new List<string>();
            switch (operation)
            {
                case Common.Operation.Insert:
                    if (View.Student_ID == 0)
                        brokenRules.Add("Save student information first.");
                    if (View.Name == string.Empty)
                        brokenRules.Add("Name is required.");
                    if (View.Number.Trim().Replace("-", "") == string.Empty && View.Emailaddress == string.Empty)                       
                        brokenRules.Add("Enter either number or email address");
                    break;

                case Common.Operation.Update:
                    if (View.Student_ID == 0)
                        brokenRules.Add("Save student information first.");
                    if (View.Name == string.Empty)
                        brokenRules.Add("Name is required.");
                    if (View.ID == 0)
                        brokenRules.Add("Select record first.");

                    if (View.Number.Trim().Replace("-", "") == string.Empty && View.Emailaddress == string.Empty)
                        brokenRules.Add("Enter either number or email address");
                    break;

                case Common.Operation.Delete:
                    if (View.ID == 0)
                        brokenRules.Add("Select record first.");
                    break;
                default:
                    break;
            }

            return brokenRules;
        }
        #endregion
    }
}
