using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Presenter.Core
{
    public class CityPresenter : BasePresenter<ICity>
    {
        #region Constructor

        public CityPresenter(ICity view)
        {
            View = view;
        }

        #endregion

        #region Load

        public void LoadItems()
        {            
            View.ProvinceDataSource = Controller.GetObject<core_province>().ToList();
            LoadCityDataSource();
        }

        public void LoadCityDataSource()
        {
            View.CityDataSource = Controller.GetObject<vcityinfo>().ToList();
        }

        public void LoadCityInfo(int id)
        {
            var item = Controller.GetObjectItemByColumnID<core_city>(id);
            if (item == null)
                return;

            View.ID = id;
            View.Name = item.name;
            View.Province_ID = item.province_id;
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
                var item = Controller.GetObjectItemByColumnID<core_city>(View.ID);
                if (item == null)
                    return false;

                Controller.DeleteObject<core_city>(item);
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
                CreateCity();
            }
            else
            {
                UpdateCity();
            }

            LoadCityDataSource();
        }

        private void CreateCity()
        {
            try
            {
                List<string> brokenRules = GetBrokenRules(Common.Operation.Insert);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                var item = new core_city();
                item.name = View.Name;
                item.province_id = View.Province_ID;

                var result = Controller.CreateObject<core_city>(item);
                View.ID = result.id;
                View.Notify(Common.Result.InsertSucceeded, null);
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.InsertFailed, new List<string> { ex.ToString() });
            }
        }

        private void UpdateCity()
        {
            try
            {
                List<string> brokenRules = GetBrokenRules(Common.Operation.Update);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                var item = Controller.GetObjectItemByColumnID<core_city>(View.ID);
                if (item == null)
                {
                    throw new Exception("Can not update.Item not found.");
                }

                item.name = View.Name;
                item.province_id = View.Province_ID;

                Controller.UpdateObject<core_city>(item);
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
                    if (View.Province_ID == 0) brokenRules.Add("Province is required.");
                    break;

                case Common.Operation.Update:
                    if (View.ID == 0) brokenRules.Add("Select record first.");
                    if (View.Name == string.Empty) brokenRules.Add("Name is required.");
                    if (View.Province_ID == 0) brokenRules.Add("Province is required.");
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
