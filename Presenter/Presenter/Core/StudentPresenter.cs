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

        public void LoadItems()
        {
            View.CivilStatusDataSource = Controller.GetObject<core_civilstatus>().ToList();
            View.GenderDataSource = Controller.GetObject<core_gender>().ToList();
            LoadStudents();
            View.Number = Common.GenerateNewNumber();

        }

        public void LoadStudents()
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
            View.Gender_id = item.gender_id;
            View.CivilStatus_id = item.civilstatus_id;
            View.Citizenship = item.citizenship;
        }

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
                    LoadStudents();
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

            LoadStudents();
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

        private void GetValues(ref core_student item)
        {
            item.id = View.ID;
            item.number = View.Number;
            item.firstname = View.Firstname;
            item.middlename = View.Middlename;
            item.lastname = View.Lastname;
            item.dateofbirth = View.DateOfBirth;
            item.gender_id = View.Gender_id;
            item.civilstatus_id = View.CivilStatus_id;
            item.citizenship = View.Citizenship;
        }

    }
}
