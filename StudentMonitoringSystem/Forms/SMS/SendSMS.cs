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
        private delegate void SetTextCallback(string text);
        //private GsmCommMain comm;

        public SendSMS()
        {
            InitializeComponent();
        }

        #region Events

        private void SendSMS_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // Send an SMS message
                SmsSubmitPdu pdu;
                bool alert = chkAlert.Checked;
                bool unicode = chkUnicode.Checked;
                string smsc = chkSMSC.Checked ? txtSMSC.Text : string.Empty;
                if (!alert && !unicode)
                {
                    // The straightforward version
                    pdu = new SmsSubmitPdu(txtMessage.Text, txtNumber.Text, smsc);
                }
                else
                {
                    // The extended version with dcs
                    byte dcs;
                    if (!alert && unicode)
                        dcs = DataCodingScheme.NoClass_16Bit;
                    else if (alert && !unicode)
                        dcs = DataCodingScheme.Class0_7Bit;
                    else if (alert && unicode)
                        dcs = DataCodingScheme.Class0_16Bit;
                    else
                        dcs = DataCodingScheme.NoClass_7Bit; // should never occur here

                    pdu = new SmsSubmitPdu(txtMessage.Text, txtNumber.Text, smsc, dcs);
                }

                // If a status report should be generated, set that here
                pdu.RequestStatusReport = true;

                // If SMS batch mode should be activated, do it before sending the first message
                comm.EnableTemporarySmsBatchMode();

                // No. of Recipients
                int Recipients = 0;

                // Send the message the specified number of times
                for (int i = 0; i < Recipients; i++)
                {
                    comm.SendMessage(pdu);
                    Output("Message {0} of {1} sent.", i + 1, Recipients);
                    Output("");
                }
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }

            Cursor.Current = Cursors.Default;
        }

        #endregion
        
        #region Methods

        private void ShowException(Exception ex)
        {
            Output("Error: " + ex.Message + " (" + ex.GetType().ToString() + ")");
            Output("");
        }

        private void Output(string text)
        {
            if (this.txtOutput.InvokeRequired)
            {
                SetTextCallback stc = new SetTextCallback(Output);
                this.Invoke(stc, new object[] { text });
            }
            else
            {
                txtOutput.AppendText(text);
                txtOutput.AppendText("\r\n");
            }
        }

        private void Output(string text, params object[] args)
        {
            string msg = string.Format(text, args);
            Output(msg);
        }

        #endregion

        private void chkSMSC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            int LimitText = txtMessage.Text.Trim().Length;
            numOfText.Text = (160 - LimitText).ToString();
        }
    }
}
