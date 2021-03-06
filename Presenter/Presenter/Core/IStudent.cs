﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;
using System.Collections;

namespace StudentMonitoringSystem.Presenter.Core
{
    public interface IStudent : IBaseView
    {
        int ID { get; set; }
        string Number { get; set; }
        string Firstname { get; set; }
        string Middlename { get; set; }
        string Lastname { get; set; }
        DateTime DateOfBirth { get; set; }
        int Gender_ID { get; set; }
        int CivilStatus_ID { get; set; }
        string Citizenship { get; set; }
        string Street { get; set; }
        int Barangay_ID { get; set; }
        int City_ID { get; set; }
        int Province_ID { get; set; }      
        string FatherName { get; set; }
        string FatherOccupation { get; set; }
        string FatherAddress { get; set; }
        string FatherContactNumber { get; set; }
        string MotherName { get; set; }
        string MotherOccupation { get; set; }
        string MotherAddress { get; set; }
        string MotherContactNumber { get; set; }
        string Note { get; set; }
        string Picture { get; set; }
        string RFID { get; set; }

        List<core_civilstatus> CivilStatusDataSource { set; }
        List<core_gender> GenderDataSource { set; }
        List<vstudentinfo> StudentDataSource { set; }
        List<core_barangay> BarangayDataSource { set; }
        List<core_city> CityDataSource { set; }
        List<core_province> ProvinceDataSource { set; }
        List<core_guardian> GuardianDataSource { set; }
    }
}
