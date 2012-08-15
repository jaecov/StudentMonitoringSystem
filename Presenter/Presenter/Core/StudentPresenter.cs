using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;

namespace StudentMonitoringSystem.Presenter.Core
{
    public class StudentPresenter : BasePresenter<IStudent>
    {
        #region Constructor

        public StudentPresenter(IStudent view)
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
            LoadStudentDataSource();
            //View.Number = Common.GenerateNewNumber();

        }

        public void LoadStudentDataSource()
        {
            View.StudentDataSource = Controller.GetObject<vstudentinfo>().ToList();
        }

        public void LoadStudentInfo(int id)
        {
            var item = Controller.GetObjectItemByColumnID<vstudentinfo>(id);
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
            View.FatherName = item.fathername;
            View.FatherAddress = item.fatheraddress;
            View.FatherContactNumber = item.fathercontactnumber;
            View.FatherOccupation = item.fatheroccupation;
            View.MotherName = item.mothername;
            View.MotherAddress = item.motheraddress;
            View.MotherContactNumber = item.mothercontactnumber;
            View.MotherOccupation = item.motheroccupation;
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

        public string GetProvider(string code)
        {
            var prov = (from network in Controller.GetObject<sms_networkprovider>()
                        join networkCode in Controller.GetObject<sms_networkprovidercode>() on network.id equals networkCode.networkprovider_id
                        where networkCode.name == code
                        select network.name).FirstOrDefault();
            return prov;
        }

        private void GetValues(ref core_student item)
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
            item.fathername = View.FatherName;
            item.fatheraddress = View.FatherAddress;
            item.fathercontactnumber = View.FatherContactNumber;
            item.fatheroccupation = View.FatherOccupation;
            item.mothername = View.MotherName;
            item.motheraddress = View.MotherAddress;
            item.mothercontactnumber = View.MotherContactNumber;
            item.motheroccupation = View.MotherOccupation;
        }

        #endregion

        #region CRUD

        public bool Delete()
        {
            if (View.ID > 0)
            {
                try
                {
                    var item = Controller.GetObjectItemByColumnID<core_student>(View.ID);
                    if (item == null)
                        return false;

                    Controller.DeleteObject<core_student>(item);
                    LoadStudentDataSource();
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
                CreateStudent();
            }
            else
            {
                UpdateStudent();
            }

            LoadStudentDataSource();
        }

        private void CreateStudent()
        {
            try
            {
                if (BrokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, BrokenRules);
                    return;
                }

                core_student item;
                item = new core_student();
                GetValues(ref item);
                var result = Controller.CreateObject<core_student>(item);
                View.ID = result.id;
                View.Notify(Common.Result.InsertSucceeded, null);
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.InsertFailed, new List<string> { ex.ToString() });
            }
        }

        private void UpdateStudent()
        {
            try
            {
                if (BrokenRules.Count > 0)
                {
                    View.Notify(Common.Result.ValidationFailed, BrokenRules);
                    return;
                }

                core_student item;
                item = Controller.GetObjectItemByColumnID<core_student>(View.ID);
                if (item == null)
                {
                    throw new Exception("Can not update.Item not found.");
                }

                GetValues(ref item);
                Controller.UpdateObject<core_student>(item);
                View.Notify(Common.Result.UpdateSuceeded, null);
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.UpdateFailed, new List<string> { ex.ToString() });
            }
        }

        #endregion

        #region Validation

        public List<string> BrokenRules
        {
            get
            {
                List<string> broken = new List<string>();
                if (View.Gender_ID == 0) broken.Add("Gender is required.");
                if (View.Barangay_ID == 0) broken.Add("Barangay is required.");
                if (View.CivilStatus_ID == 0) broken.Add("Civil status is required.");

                return broken;
            }
        }

        #endregion
    }
}
