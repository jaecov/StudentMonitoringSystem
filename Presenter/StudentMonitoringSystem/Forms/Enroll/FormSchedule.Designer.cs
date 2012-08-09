namespace StudentMonitoringSystem.Forms.Enroll
{
    partial class FormSchedule
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
            this.components = new System.ComponentModel.Container();
            this.grdSchedule = new System.Windows.Forms.DataGridView();
            this.vScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dteStart = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.dteEnd = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emplastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empfirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empmiddlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emppictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daycodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vScheduleBindingSource)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdSchedule
            // 
            this.grdSchedule.AllowUserToAddRows = false;
            this.grdSchedule.AllowUserToDeleteRows = false;
            this.grdSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSchedule.AutoGenerateColumns = false;
            this.grdSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.datestartDataGridViewTextBoxColumn,
            this.dateendDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.coursenameDataGridViewTextBoxColumn,
            this.coursecodeDataGridViewTextBoxColumn,
            this.emplastnameDataGridViewTextBoxColumn,
            this.empfirstnameDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.subjectidDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dayidDataGridViewTextBoxColumn,
            this.roomidDataGridViewTextBoxColumn,
            this.empnumberDataGridViewTextBoxColumn,
            this.empmiddlenameDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn,
            this.emppictureDataGridViewTextBoxColumn,
            this.daycodeDataGridViewTextBoxColumn,
            this.sectionidDataGridViewTextBoxColumn});
            this.grdSchedule.DataSource = this.vScheduleBindingSource;
            this.grdSchedule.Location = new System.Drawing.Point(3, 181);
            this.grdSchedule.Name = "grdSchedule";
            this.grdSchedule.ReadOnly = true;
            this.grdSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSchedule.Size = new System.Drawing.Size(799, 189);
            this.grdSchedule.TabIndex = 208;
            this.grdSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSchedule_CellClick);
            // 
            // vScheduleBindingSource
            // 
            this.vScheduleBindingSource.DataSource = typeof(StudentMonitoringSystem.Entities.vscheduleinfo);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(87, 127);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(347, 20);
            this.txtNote.TabIndex = 209;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 214;
            this.label7.Text = "Note:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 212;
            this.label4.Text = "Course:";
            // 
            // cmbCourse
            // 
            this.cmbCourse.DisplayMember = "name";
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(87, 12);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(347, 21);
            this.cmbCourse.TabIndex = 213;
            this.cmbCourse.ValueMember = "id";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(19, 12);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(11, 13);
            this.label27.TabIndex = 216;
            this.label27.Text = "*";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.btnDelete);
            this.GroupBox1.Controls.Add(this.btnReset);
            this.GroupBox1.Controls.Add(this.btnSave);
            this.GroupBox1.Location = new System.Drawing.Point(707, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(95, 104);
            this.GroupBox1.TabIndex = 217;
            this.GroupBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 23);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 13);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 23);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 218;
            this.label1.Text = "Section:";
            // 
            // cmbSection
            // 
            this.cmbSection.DisplayMember = "name";
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(87, 40);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(347, 21);
            this.cmbSection.TabIndex = 219;
            this.cmbSection.ValueMember = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(19, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 220;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 221;
            this.label3.Text = "Instructor:";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DisplayMember = "name";
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(87, 70);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(347, 21);
            this.cmbEmployee.TabIndex = 222;
            this.cmbEmployee.ValueMember = "id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(19, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 223;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 224;
            this.label6.Text = "Subject:";
            // 
            // cmbSubject
            // 
            this.cmbSubject.DisplayMember = "name";
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(87, 100);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(347, 21);
            this.cmbSubject.TabIndex = 225;
            this.cmbSubject.ValueMember = "id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(19, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 226;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 227;
            this.label9.Text = "Room No:";
            // 
            // cmbRoom
            // 
            this.cmbRoom.DisplayMember = "name";
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(547, 12);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(154, 21);
            this.cmbRoom.TabIndex = 228;
            this.cmbRoom.ValueMember = "id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(463, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 229;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(479, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 230;
            this.label11.Text = "Day:";
            // 
            // cmbDay
            // 
            this.cmbDay.DisplayMember = "name";
            this.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(547, 40);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(154, 21);
            this.cmbDay.TabIndex = 231;
            this.cmbDay.ValueMember = "id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(463, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 232;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(463, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 245;
            this.label13.Text = "*";
            // 
            // dteStart
            // 
            this.dteStart.CustomFormat = "";
            this.dteStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dteStart.Location = new System.Drawing.Point(547, 70);
            this.dteStart.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dteStart.Name = "dteStart";
            this.dteStart.ShowUpDown = true;
            this.dteStart.Size = new System.Drawing.Size(154, 20);
            this.dteStart.TabIndex = 240;
            this.dteStart.Value = new System.DateTime(2010, 8, 22, 7, 30, 1, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(479, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 244;
            this.label14.Text = "Time Start:";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.ForeColor = System.Drawing.Color.Red;
            this.Label25.Location = new System.Drawing.Point(463, 100);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(11, 13);
            this.Label25.TabIndex = 243;
            this.Label25.Text = "*";
            // 
            // dteEnd
            // 
            this.dteEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dteEnd.Location = new System.Drawing.Point(547, 100);
            this.dteEnd.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dteEnd.Name = "dteEnd";
            this.dteEnd.ShowUpDown = true;
            this.dteEnd.Size = new System.Drawing.Size(154, 20);
            this.dteEnd.TabIndex = 241;
            this.dteEnd.Value = new System.DateTime(2010, 8, 22, 8, 30, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(479, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 242;
            this.label15.Text = "Time End:";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datestartDataGridViewTextBoxColumn
            // 
            this.datestartDataGridViewTextBoxColumn.DataPropertyName = "datestart";
            this.datestartDataGridViewTextBoxColumn.HeaderText = "Time Start";
            this.datestartDataGridViewTextBoxColumn.Name = "datestartDataGridViewTextBoxColumn";
            this.datestartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateendDataGridViewTextBoxColumn
            // 
            this.dateendDataGridViewTextBoxColumn.DataPropertyName = "dateend";
            this.dateendDataGridViewTextBoxColumn.HeaderText = "Time End";
            this.dateendDataGridViewTextBoxColumn.Name = "dateendDataGridViewTextBoxColumn";
            this.dateendDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "day";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "course_name";
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "course_name";
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            this.coursenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursecodeDataGridViewTextBoxColumn
            // 
            this.coursecodeDataGridViewTextBoxColumn.DataPropertyName = "course_code";
            this.coursecodeDataGridViewTextBoxColumn.HeaderText = "course_code";
            this.coursecodeDataGridViewTextBoxColumn.Name = "coursecodeDataGridViewTextBoxColumn";
            this.coursecodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emplastnameDataGridViewTextBoxColumn
            // 
            this.emplastnameDataGridViewTextBoxColumn.DataPropertyName = "emp_lastname";
            this.emplastnameDataGridViewTextBoxColumn.HeaderText = "emp_lastname";
            this.emplastnameDataGridViewTextBoxColumn.Name = "emplastnameDataGridViewTextBoxColumn";
            this.emplastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empfirstnameDataGridViewTextBoxColumn
            // 
            this.empfirstnameDataGridViewTextBoxColumn.DataPropertyName = "emp_firstname";
            this.empfirstnameDataGridViewTextBoxColumn.HeaderText = "emp_firstname";
            this.empfirstnameDataGridViewTextBoxColumn.Name = "empfirstnameDataGridViewTextBoxColumn";
            this.empfirstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectidDataGridViewTextBoxColumn
            // 
            this.subjectidDataGridViewTextBoxColumn.DataPropertyName = "subject_id";
            this.subjectidDataGridViewTextBoxColumn.HeaderText = "subject_id";
            this.subjectidDataGridViewTextBoxColumn.Name = "subjectidDataGridViewTextBoxColumn";
            this.subjectidDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectidDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "course_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "course_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dayidDataGridViewTextBoxColumn
            // 
            this.dayidDataGridViewTextBoxColumn.DataPropertyName = "day_id";
            this.dayidDataGridViewTextBoxColumn.HeaderText = "day_id";
            this.dayidDataGridViewTextBoxColumn.Name = "dayidDataGridViewTextBoxColumn";
            this.dayidDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayidDataGridViewTextBoxColumn.Visible = false;
            // 
            // roomidDataGridViewTextBoxColumn
            // 
            this.roomidDataGridViewTextBoxColumn.DataPropertyName = "room_id";
            this.roomidDataGridViewTextBoxColumn.HeaderText = "room_id";
            this.roomidDataGridViewTextBoxColumn.Name = "roomidDataGridViewTextBoxColumn";
            this.roomidDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomidDataGridViewTextBoxColumn.Visible = false;
            // 
            // empnumberDataGridViewTextBoxColumn
            // 
            this.empnumberDataGridViewTextBoxColumn.DataPropertyName = "emp_number";
            this.empnumberDataGridViewTextBoxColumn.HeaderText = "emp_number";
            this.empnumberDataGridViewTextBoxColumn.Name = "empnumberDataGridViewTextBoxColumn";
            this.empnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.empnumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // empmiddlenameDataGridViewTextBoxColumn
            // 
            this.empmiddlenameDataGridViewTextBoxColumn.DataPropertyName = "emp_middlename";
            this.empmiddlenameDataGridViewTextBoxColumn.HeaderText = "emp_middlename";
            this.empmiddlenameDataGridViewTextBoxColumn.Name = "empmiddlenameDataGridViewTextBoxColumn";
            this.empmiddlenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.empmiddlenameDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // emppictureDataGridViewTextBoxColumn
            // 
            this.emppictureDataGridViewTextBoxColumn.DataPropertyName = "emp_picture";
            this.emppictureDataGridViewTextBoxColumn.HeaderText = "emp_picture";
            this.emppictureDataGridViewTextBoxColumn.Name = "emppictureDataGridViewTextBoxColumn";
            this.emppictureDataGridViewTextBoxColumn.ReadOnly = true;
            this.emppictureDataGridViewTextBoxColumn.Visible = false;
            // 
            // daycodeDataGridViewTextBoxColumn
            // 
            this.daycodeDataGridViewTextBoxColumn.DataPropertyName = "day_code";
            this.daycodeDataGridViewTextBoxColumn.HeaderText = "day_code";
            this.daycodeDataGridViewTextBoxColumn.Name = "daycodeDataGridViewTextBoxColumn";
            this.daycodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.daycodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // sectionidDataGridViewTextBoxColumn
            // 
            this.sectionidDataGridViewTextBoxColumn.DataPropertyName = "section_id";
            this.sectionidDataGridViewTextBoxColumn.HeaderText = "section_id";
            this.sectionidDataGridViewTextBoxColumn.Name = "sectionidDataGridViewTextBoxColumn";
            this.sectionidDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectionidDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 372);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dteStart);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Label25);
            this.Controls.Add(this.dteEnd);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.grdSchedule);
            this.Name = "FormSchedule";
            this.TabText = "Schedule";
            this.Tag = "";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.FormSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vScheduleBindingSource)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCourse;
        internal System.Windows.Forms.Label label27;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView grdSchedule;
        private System.Windows.Forms.BindingSource vScheduleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSection;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEmployee;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSubject;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbRoom;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDay;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.DateTimePicker dteStart;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.DateTimePicker dteEnd;
        internal System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empfirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empmiddlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emppictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daycodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionidDataGridViewTextBoxColumn;
    }
}