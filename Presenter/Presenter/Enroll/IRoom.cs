﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentMonitoringSystem.Entities;
using System.Collections;

namespace StudentMonitoringSystem.Presenter.Enroll
{
    public interface IRoom : IBaseView
    {
        int ID { get; set; }
        string Name { get; set; }
        string Note { get; set; }
        List<enroll_room> RoomDataSource { set; }
    }
}
