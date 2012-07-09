using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentMonitoringSystem.Presenter
{
    public class Common
    {
        public enum Result
        {
            SaveSucceeded,
            UpdateSuceeded,
            DeleteSuceeded,
            SaveFailed,
            UpdateFailed,
            DeleteFailed,
            ValidationFailed
        }

        public static string Message(Result result)
        {
            string msg;
            switch (result)
            {
                case Result.SaveSucceeded:
                    msg = "New record successfully created."; 
                    break;
                case Result.UpdateSuceeded:
                    msg = "Existing record successfully updated."; 
                    break;
                case Result.DeleteSuceeded:
                    msg = "Record successfully deleted."; 
                    break;
                case Result.SaveFailed:
                    msg = "Failed to create new record."; 
                    break;
                case Result.UpdateFailed:
                    msg = "Failed to update existing record."; 
                    break;
                case Result.DeleteFailed:
                    msg = "Failed to delete record."; 
                    break;
                case Result.ValidationFailed:
                    msg = "Validation failed.";
                    break;
                default:
                    msg = "No result found.";
                    break;
            }

            return msg;
        }

        public static string GenerateNewNumber()
        {
            return string.Format("{0}{1}{2}-{3}{4}{5}{6}", DateTime.Now.Year.ToString("####"),
                                                           DateTime.Now.Month.ToString("##"),
                                                           DateTime.Now.Day.ToString("##"),
                                                           DateTime.Now.Hour.ToString("##"),
                                                           DateTime.Now.Minute.ToString("##"),
                                                           DateTime.Now.Second.ToString("##"),
                                                           DateTime.Now.Millisecond.ToString("##"));
        }
    }
}
