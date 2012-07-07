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
            var items = Controller.GetObject<core_barangay>().Where(c=>c.city_id == cityID).ToList();
            View.BarangayDataSource = items;
        }

        #endregion

        #region Get

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
                    View.Notify(Common.Result.DeleteFailed, ex);
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
                core_student item;
                item = new core_student();
                GetValues(ref item);
                var result = Controller.CreateObject<core_student>(item);
                View.ID = result.id;
                View.Notify(Common.Result.SaveSucceeded, null);
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.SaveFailed, ex);
            }
        }

        private void UpdateStudent()
        {
            try
            {
                core_student item;
                item = Controller.GetObjectItemByColumnID<core_student>(View.ID);
                if (item == null)
                    return;

                GetValues(ref item);
                Controller.UpdateObject<core_student>(item);
                View.Notify(Common.Result.UpdateSuceeded, null);
            }
            catch (Exception ex)
            {
                View.Notify(Common.Result.UpdateFailed, ex);
            }
        }

        #endregion


    }
}
