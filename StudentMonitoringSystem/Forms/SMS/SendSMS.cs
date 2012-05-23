using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GsmComm.PduConverter;
using GsmComm.PduConverter.SmartMessaging;
using GsmComm.GsmCommunication;
using GsmComm.Interfaces;
using GsmComm.Server;

namespace StudentMonitoringSystem.Forms.SMS
{
    public partial class SendSMS : Form
    {
        public SendSMS()
        {
            InitializeComponent();
        }

        private void SendSMS_Load(object sender, EventArgs e)
        {

        }
    }
}
