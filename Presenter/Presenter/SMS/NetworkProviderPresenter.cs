using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Presenter.SMS
{
    public class NetworkProviderPresenter : BasePresenter<INetworkProvider>
    {
        #region Constructor

        public NetworkProviderPresenter(INetworkProvider view)
        {
            View = view;
        }

        #endregion

        #region Load

        public void LoadItems()
        {            
            View.NetworkProviderDataSource = Controller.GetObject<sms_networkprovider>().ToList();           
        }

        public void LoadNetworkProviderInfo(int id)
        {
            var item = Controller.GetObjectItemByColumnID<sms_networkprovider>(id);
            if (item == null)
                return;

            View.ID = id;
            View.Name = item.name;    
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
                var item = Controller.GetObjectItemByColumnID<sms_networkprovider>(View.ID);
                if (item == null)
                    return false;

                Controller.DeleteObject<sms_networkprovider>(item);
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
                CreateNetworkProvider();
            }
            else
            {
                UpdateNetworkProvider();
            }

            LoadItems();
        }

        private void CreateNetworkProvider()
        {
            try
            {
                List<string> brokenRules = GetBrokenRules(Common.Operation.Insert);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                var item = new sms_networkprovider();
                item.name = View.Name;

                var result = Controller.CreateObject<sms_networkprovider>(item);
                View.ID = result.id;
                View.Notify(Common.Result.InsertSucceeded, null);
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.InsertFailed, new List<string> { ex.ToString() });
            }
        }

        private void UpdateNetworkProvider()
        {
            try
            {
                List<string> brokenRules = GetBrokenRules(Common.Operation.Update);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                var item = Controller.GetObjectItemByColumnID<sms_networkprovider>(View.ID);
                if (item == null)
                    return;

                item.name = View.Name;

                Controller.UpdateObject<sms_networkprovider>(item);
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
