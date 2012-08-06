using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Presenter.Employee
{
    public class EmployeePresenter : BasePresenter<IEmployee>
    {
        #region Constructor

        public EmployeePresenter(IEmployee view)
        {
            View = view;
        }

        #endregion

        #region Load

        public void LoadItems()
        {
            View.CivilStatusDataSource = Controller.GetObject<core_civilstatus>().ToList();
            View.GenderDataSource = Controller.GetObject<core_gender>().ToList();
            View.ProvinceDataSource = Controller.GetObject<core_province>().ToList();
            LoadEmployeeDataSource();
            //View.Number = Common.GenerateNewNumber();

        }

        public void LoadEmployeeDataSource()
        {
            View.EmployeeDataSource = Controller.GetObject<vemployeeinfo>().ToList();
        }

        public void LoadEmployeeInfo(int id)
        {
            var item = Controller.GetObjectItemByColumnID<vemployeeinfo>(id);
            if (item == null)
                return;
            
            View.ID = id;
            View.Number = item.number;
            View.Firstname = item.firstname;
            View.Middlename = item.middlename;
            View.Lastname = item.lastname;
            View.Gender_ID = item.gender_id;
            View.CivilStatus_ID = item.civilstatus_id;
            View.Citizenship = item.citizenship;
            View.Province_ID = item.province_id;
            View.City_ID = item.city_id;
            View.Barangay_ID = item.barangay_id;
            View.Street = item.street;
            View.Note = item.note;
            View.Picture = item.picture;
        }

        public void LoadCityDataSource(int provinceID)
        {
            if (provinceID > 0)
            {
                var items = Controller.GetObject<core_city>().Where(c => c.province_id == provinceID).ToList();
                View.CityDataSource = items;
            }
            else
            {
                var items = Controller.GetObject<core_city>().ToList();
                View.CityDataSource = items;
            }

        }

        public void LoadBarangayDataSource(int cityID)
        {
            var items = Controller.GetObject<core_barangay>().Where(c => c.city_id == cityID).ToList();
            View.BarangayDataSource = items;
        }

        #endregion

        #region Get

        private void GetValues(ref emp_employee item)
        {
            item.id = View.ID;
            item.number = View.Number;
            item.firstname = View.Firstname;
            item.middlename = View.Middlename;
            item.lastname = View.Lastname;
            item.dateofbirth = View.DateOfBirth;
            item.gender_id = View.Gender_ID;
            item.civilstatus_id = View.CivilStatus_ID;
            item.citizenship = View.Citizenship;
            item.barangay_id = View.Barangay_ID;
            item.street = View.Street;
            item.note = View.Note;
            item.picture = View.Picture;
        }

        public string GetProvider(string code)
        {
            var prov = (from network in Controller.GetObject<sms_networkprovider>()
                        join networkCode in Controller.GetObject<sms_networkprovidercode>() on network.id equals networkCode.networkprovider_id
                        where networkCode.name == code
                        select network.name).FirstOrDefault();
            return prov;
        }
        #endregion

        #region CRUD

        public bool Delete()
        {
            if (View.ID > 0)
            {
                try
                {
                    var item = Controller.GetObjectItemByColumnID<emp_employee>(View.ID);
                    if (item == null)
                        return false;

                    Controller.DeleteObject<emp_employee>(item);
                    LoadEmployeeDataSource();
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
                CreateEmployee();
            }
            else
            {
                UpdateEmployee();
            }

            LoadEmployeeDataSource();
        }

        private void CreateEmployee()
        {
            try
            {
                List<string> brokenRules = BrokenRules(Common.Operation.Insert);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                emp_employee item;
                item = new emp_employee();
                GetValues(ref item);
                var result = Controller.CreateObject<emp_employee>(item);
                View.ID = result.id;
                View.Notify(Common.Result.InsertSucceeded, null);
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.InsertFailed, new List<string> { ex.ToString() });
            }
        }

        private void UpdateEmployee()
        {
            try
            {
                List<string> brokenRules = BrokenRules(Common.Operation.Update);
                if (brokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, brokenRules);
                    return;
                }

                emp_employee item;
                item = Controller.GetObjectItemByColumnID<emp_employee>(View.ID);
                if (item == null)
                    return;

                GetValues(ref item);
                Controller.UpdateObject<emp_employee>(item);
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
                    if (View.Gender_ID == 0) brokenRules.Add("Gender is required.");
                    if (View.Barangay_ID == 0) brokenRules.Add("Barangay is required.");
                    if (View.CivilStatus_ID == 0) brokenRules.Add("Civil status is required.");
                    break;

                case Common.Operation.Update:
                    if (View.ID == 0) brokenRules.Add("Select employee first.");
                    if (View.Gender_ID == 0) brokenRules.Add("Gender is required.");
                    if (View.Barangay_ID == 0) brokenRules.Add("Barangay is required.");
                    if (View.CivilStatus_ID == 0) brokenRules.Add("Civil status is required.");
                    break;

                case Common.Operation.Delete:
                    if (View.ID == 0) brokenRules.Add("Select employee first.");
                    break;

                default:
                    break;
            }         

            return brokenRules;
        }
        #endregion
    }
}
