namespace StudentMonitoringSystem.Forms.SMS
{
    partial class SendSMS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNoReceiver = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtFailed = new System.Windows.Forms.TextBox();
            this.txtSent = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtModemResponce = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.numOfText = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtNoReceiver);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.txtFailed);
            this.GroupBox2.Controls.Add(this.txtSent);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Location = new System.Drawing.Point(12, 295);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(225, 101);
            this.GroupBox2.TabIndex = 173;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Status Report";
            // 
            // txtNoReceiver
            // 
            this.txtNoReceiver.Location = new System.Drawing.Point(129, 23);
            this.txtNoReceiver.Name = "txtNoReceiver";
            this.txtNoReceiver.ReadOnly = true;
            this.txtNoReceiver.Size = new System.Drawing.Size(56, 20);
            this.txtNoReceiver.TabIndex = 162;
            this.txtNoReceiver.TabStop = false;
            this.txtNoReceiver.Text = "0";
            this.txtNoReceiver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(38, 26);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(85, 13);
            this.Label4.TabIndex = 163;
            this.Label4.Text = "No. of Receiver:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(85, 78);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(38, 13);
            this.Label9.TabIndex = 161;
            this.Label9.Text = "Failed:";
            // 
            // txtFailed
            // 
            this.txtFailed.BackColor = System.Drawing.Color.LightCoral;
            this.txtFailed.Location = new System.Drawing.Point(129, 75);
            this.txtFailed.Name = "txtFailed";
            this.txtFailed.ReadOnly = true;
            this.txtFailed.Size = new System.Drawing.Size(56, 20);
            this.txtFailed.TabIndex = 160;
            this.txtFailed.TabStop = false;
            this.txtFailed.Text = "0";
            this.txtFailed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSent
            // 
            this.txtSent.BackColor = System.Drawing.Color.PaleGreen;
            this.txtSent.Location = new System.Drawing.Point(129, 49);
            this.txtSent.Name = "txtSent";
            this.txtSent.ReadOnly = true;
            this.txtSent.Size = new System.Drawing.Size(56, 20);
            this.txtSent.TabIndex = 156;
            this.txtSent.TabStop = false;
            this.txtSent.Text = "0";
            this.txtSent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(29, 52);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(94, 13);
            this.Label7.TabIndex = 157;
            this.Label7.Text = "Successfully Sent:";
            // 
            // txtModemResponce
            // 
            this.txtModemResponce.BackColor = System.Drawing.Color.SteelBlue;
            this.txtModemResponce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModemResponce.ForeColor = System.Drawing.Color.White;
            this.txtModemResponce.Location = new System.Drawing.Point(12, 435);
            this.txtModemResponce.Multiline = true;
            this.txtModemResponce.Name = "txtModemResponce";
            this.txtModemResponce.ReadOnly = true;
            this.txtModemResponce.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtModemResponce.Size = new System.Drawing.Size(225, 126);
            this.txtModemResponce.TabIndex = 170;
            this.txtModemResponce.TabStop = false;
            this.txtModemResponce.WordWrap = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(15, 49);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 13);
            this.Label2.TabIndex = 169;
            this.Label2.Text = "Message:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 419);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(96, 13);
            this.Label3.TabIndex = 171;
            this.Label3.Text = "Modem Response:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(15, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 168;
            this.Label1.Text = "Number:";
            // 
            // txtMessage
            // 
            this.txtMessage.Enabled = false;
            this.txtMessage.Location = new System.Drawing.Point(12, 65);
            this.txtMessage.MaxLength = 160;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(225, 172);
            this.txtMessage.TabIndex = 166;
            // 
            // txtNumber
            // 
            this.txtNumber.Enabled = false;
            this.txtNumber.Location = new System.Drawing.Point(12, 26);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(171, 20);
            this.txtNumber.TabIndex = 165;
            // 
            // numOfText
            // 
            this.numOfText.Enabled = false;
            this.numOfText.Location = new System.Drawing.Point(200, 245);
            this.numOfText.MaxLength = 3;
            this.numOfText.Name = "numOfText";
            this.numOfText.ReadOnly = true;
            this.numOfText.Size = new System.Drawing.Size(37, 20);
            this.numOfText.TabIndex = 172;
            this.numOfText.TabStop = false;
            this.numOfText.Text = "160";
            this.numOfText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(12, 243);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(169, 23);
            this.btnSend.TabIndex = 167;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // SendSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 659);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.txtModemResponce);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.numOfText);
            this.Controls.Add(this.btnSend);
            this.Name = "SendSMS";
            this.Text = "SendSMS";
            this.Load += new System.EventHandler(this.SendSMS_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtNoReceiver;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtFailed;
        internal System.Windows.Forms.TextBox txtSent;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtModemResponce;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtMessage;
        internal System.Windows.Forms.TextBox txtNumber;
        internal System.Windows.Forms.TextBox numOfText;
        internal System.Windows.Forms.Button btnSend;

    }
}