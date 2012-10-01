using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using Microsoft.VisualBasic;
using System.Threading;

namespace StudentMonitoringSystem.Ctl
{
    public partial class ctlRFID : UserControl
    {
        public ctlRFID()
        {
            InitializeComponent();
        }

        public string RFID
        {
            get
            {
                return txtRFID.Text;
            }
            set
            {
                if (! changing)
                {
                    originalId = value;
                    lblStatus.Text = "Current ID.";
                }

                txtRFID.Text = value;
            }
        }

        #region PORT

        delegate void SetTextCallback(string RFvalue);
        // use for threading on serial port
        string returnStr = string.Empty;
        bool changing = false;
        string originalId = "";

        public string PORT { get; set; }
        public int BaudRate { get; set; }
        public int DataBits { get; set; }
        public bool RtsEnable { get; set; }
        public bool DtrEnable { get; set; }

        public void SetDefault()
        {
            BaudRate = 9600;
            DataBits = 8;
            RtsEnable = true;
            DtrEnable = true;
        }

        public void OpenPort()
        {
            SerialPort1.DataReceived += SerialPort1_DataReceived;

            int counter = 0;

            while (counter < 2)
            {
                try
                {                  
                    SerialPort1.Close();
                    SerialPort1.PortName = PORT;
                    SerialPort1.BaudRate = BaudRate;
                    SerialPort1.Parity = System.IO.Ports.Parity.None;
                    SerialPort1.DataBits = DataBits;
                    SerialPort1.StopBits = System.IO.Ports.StopBits.One;
                    SerialPort1.RtsEnable = RtsEnable;
                    SerialPort1.DtrEnable = DtrEnable;
                    SerialPort1.Encoding.GetEncoder();
                    SerialPort1.ReceivedBytesThreshold = 1;
                    SerialPort1.NewLine = Environment.NewLine;
                    SerialPort1.Open();

                    counter = 2;
                }
                catch (Exception)
                {
                    //Thread.Sleep(30000);
                    counter += 1;
                }
            }
        }

        public void ClosePort()
        {
            SerialPort1.Close();
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int bRead = 0;
            int nRead = 0;

            //Number of Bytes to read
            bRead = SerialPort1.BytesToRead;
            byte[] cData = new byte[bRead];
            nRead = SerialPort1.Read(cData, 0, bRead);

            //Reading the Data
            foreach (byte b in cData)
            {
                returnStr += Convert.ToString(b);
            }

            if (returnStr.Length == 27)
            {
                SetText(returnStr);
                returnStr = "";
            }

            //***************
            ////Try
            ////Sub to Receive Data from the Serial Port, Will Run in a Thread
            //int bRead = 0;
            //int nRead = 0;
            //string ascStr = "";
            //bRead = SerialPort1.BytesToRead;
            ////Number of Bytes to read
            //byte[] cData = new byte[bRead];
            ////SerialPort1.Encoding = Encoding.GetEncoding(65001)
            //nRead = SerialPort1.Read(cData, 0, bRead);
            ////Reading the Data
            //foreach (byte b in cData)
            //{
            //    ascStr += Strings.Chr(b);
            //    //Ascii String
            //    returnStr += Conversion.Hex(b).PadLeft(2, "0");
            //    //Hex String (Modified Padding, to intake compulsory 2 chars, mainly in case of 0)
            //}

            //if (Strings.Len(returnStr) == 20)
            //{
            //    SetText(returnStr);
            //    returnStr = "";
            //}
            //*****************************

        }
             
        private void SetText(string value)
        {
            SetTextCallback d = SetRFID;
            this.Invoke(d, new object[] { value });
        }
          
        public void SetRFID(string value)
        {
            changing = true;
            RFID = value;
            lblStatus.Text = "RFID Changed.";
        }

        #endregion

        private void btnUndo_Click(object sender, EventArgs e)
        {
            RFID = originalId;
        }
    }
}
