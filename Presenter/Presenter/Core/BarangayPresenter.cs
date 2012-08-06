using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Presenter.Core
{
    public class BarangayPresenter : BasePresenter<IBarangay>
    {
        #region Constructor

        public BarangayPresenter(IBarangay view)
        {
            View = view;
        }

        #endregion

        #region Load

        public void LoadItems()
        {
            View.CityDataSource = Controller.GetObject<core_city>().ToList();
            LoadBarangayDataSource();
        }

        public void LoadBarangayDataSource()
        {
            View.BarangayDataSource = Controller.GetObject<vbarangayinfo>().ToList();
        }

        public void LoadBarangayInfo(int id)
        {
            var item = Controller.GetObjectItemByColumnID<core_barangay>(id);
            if (item == null)
                return;

            View.ID = id;
            View.Name = item.name;
            View.City_ID = item.city_id;
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
                var item = Controller.GetObjectItemByColumnID<core_barangay>(View.ID);
                if (item == null)
                    return false;

                Controller.DeleteObject<core_barangay>(item);
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
                CreateBarangay();
            }
            else
            {
                UpdateBarangay();
            }

            LoadBarangayDataSource();
        }

        private void CreateBarangay()
        {
            try
            {
                List<string> brokenRules = GetBrokenRules(Common.Operation.Insert);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                core_barangay item = new core_barangay();
                item.name = View.Name;
                item.city_id = View.City_ID;

                var result = Controller.CreateObject<core_barangay>(item);
                View.ID = result.id;
                View.Notify(Common.Result.InsertSucceeded, null);
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.InsertFailed, new List<string> { ex.ToString() });
            }
        }

        private void UpdateBarangay()
        {
            try
            {
                List<string> brokenRules = GetBrokenRules(Common.Operation.Update);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                var item = Controller.GetObjectItemByColumnID<core_barangay>(View.ID);
                if (item == null)
                    return;

                item.name = View.Name;
                item.city_id = View.City_ID;

                Controller.UpdateObject<core_barangay>(item);
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
                    if (View.City_ID == 0) brokenRules.Add("City is required.");
                    break;

                case Common.Operation.Update:
                    if (View.ID == 0) brokenRules.Add("Select record first.");
                    if (View.Name == string.Empty) brokenRules.Add("Name is required.");
                    if (View.City_ID == 0) brokenRules.Add("City is required.");
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
