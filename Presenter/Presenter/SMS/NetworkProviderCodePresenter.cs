using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Presenter.SMS
{
    public class NetworkProviderCodePresenter : BasePresenter<INetworkProviderCode>
    {
        #region Constructor

        public NetworkProviderCodePresenter(INetworkProviderCode view)
        {
            View = view;
        }

        #endregion

        #region Load

        public void LoadItems()
        {            
            View.NetworkProviderDataSource = Controller.GetObject<sms_networkprovider>().ToList();
            LoadNetworkProviderCodeDataSource();
        }

        public void LoadNetworkProviderCodeDataSource()
        {
            View.NetworkProviderCodeDataSource = Controller.GetObject<vnetworkprovidercodeinfo>().ToList();
        }

        public void LoadNetworkProviderCodeInfo(int id)
        {
            var item = Controller.GetObjectItemByColumnID<sms_networkprovidercode>(id);
            if (item == null)
                return;

            View.ID = id;
            View.Name = item.name;
            View.NetworkProvider_ID = item.networkprovider_id;
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
                var item = Controller.GetObjectItemByColumnID<sms_networkprovidercode>(View.ID);
                if (item == null)
                    return false;

                Controller.DeleteObject<sms_networkprovidercode>(item);
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
                CreateNetworkProviderCode();
            }
            else
            {
                UpdateNetworkProviderCode();
            }

            LoadNetworkProviderCodeDataSource();
        }

        private void CreateNetworkProviderCode()
        {
            try
            {
                List<string> brokenRules = GetBrokenRules(Common.Operation.Insert);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                var item = new sms_networkprovidercode();
                item.name = View.Name;
                item.networkprovider_id = View.NetworkProvider_ID;

                var result = Controller.CreateObject<sms_networkprovidercode>(item);
                View.ID = result.id;
                View.Notify(Common.Result.InsertSucceeded, null);
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.InsertFailed, new List<string> { ex.ToString() });
            }
        }

        private void UpdateNetworkProviderCode()
        {
            try
            {
                List<string> brokenRules = GetBrokenRules(Common.Operation.Update);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                var item = Controller.GetObjectItemByColumnID<sms_networkprovidercode>(View.ID);
                if (item == null)
                {
                    throw new Exception("Can not update.Item not found.");
                }

                item.name = View.Name;
                item.networkprovider_id = View.NetworkProvider_ID;

                Controller.UpdateObject<sms_networkprovidercode>(item);
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
                    if (View.Name == string.Empty) brokenRules.Add("Code is required.");
                    if (View.NetworkProvider_ID == 0) brokenRules.Add("Network provider is required.");
                    break;

                case Common.Operation.Update:
                    if (View.ID == 0) brokenRules.Add("Select record first.");
                    if (View.Name == string.Empty) brokenRules.Add("Code is required.");
                    if (View.NetworkProvider_ID == 0) brokenRules.Add("Network provider is required.");
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
