﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Presenter.Core
{
    public class ContactPresenter : BasePresenter<IContact>
    {
        #region Constructor

        public ContactPresenter(IContact view)
        {
            View = view;
        }

        #endregion

        #region Load

        public void LoadItems()
        {
            View.ContactDataSource = Controller.GetObject<core_contact>()
                                               .Where(c => c.student_id == View.Student_ID)
                                               .ToList();
        }

        #endregion

        #region Get

        private void GetValues(ref core_contact item)
        {
            item.id = View.ID;
            item.student_id = View.Student_ID;
            item.number = View.Number;
            item.emailaddress = View.Emailaddress;
            item.note = View.Note;
        }

        public void LoadContactInfo(int id)
        {
            var item = Controller.GetObjectItemByColumnID<core_contact>(id);
            if (item == null)
                return;

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
                    var item = Controller.GetObjectItemByColumnID<core_contact>(View.ID);
                    if (item == null)
                        return false;

                    Controller.DeleteObject<core_contact>(item);
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
                CreateContact();
            }
            else
            {
                UpdateContact();
            }

            LoadItems();
        }

        private void CreateContact()
        {
            try
            {

                List<string> brokenRules = BrokenRules(Common.Operation.Insert);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                core_contact item = new core_contact();
                GetValues(ref item);
                var result = Controller.CreateObject<core_contact>(item);
                View.ID = result.id;
                View.Notify(Common.Result.InsertSucceeded, null);
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.InsertFailed, new List<string> { ex.ToString() });
            }
        }

        private void UpdateContact()
        {
            try
            {
                List<string> brokenRules = BrokenRules(Common.Operation.Update);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                core_contact item;
                item = Controller.GetObjectItemByColumnID<core_contact>(View.ID);
                if (item == null)
                {
                    throw new Exception("Can not update.Item not found.");
                }

                GetValues(ref item);
                Controller.UpdateObject<core_contact>(item);
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

                    if (View.Number.Trim().Replace("-", "") == string.Empty && View.Emailaddress == string.Empty)
                        brokenRules.Add("Enter either number or email address");
                    break;

                case Common.Operation.Update:
                    if (View.Student_ID == 0)
                        brokenRules.Add("Save student information first.");

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
