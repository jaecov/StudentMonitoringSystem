﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudentMonitoringSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Start();
            Application.Run(new Main());
        }

        private static void Start()
        { 
          
        }
    }
}
