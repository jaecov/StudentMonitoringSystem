namespace StudentMonitoringSystem.Forms.Core
{
    partial class FormStudentInfoList
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
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.vstudentinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdStudentInfoList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civilstatusidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civilstatusnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citizenshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangayidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gendernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangaynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatheroccupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathercontactnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatheraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mothernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motheroccupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mothercontactnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motheraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label28 = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.cmbSchoolYear = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label58 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vstudentinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentInfoList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(678, 9);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(188, 20);
            this.txtFirstname.TabIndex = 209;
            this.txtFirstname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLastname_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(611, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 214;
            this.label7.Text = "Firstname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 219;
            this.label1.Text = "Lastname :";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(678, 39);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(188, 20);
            this.txtLastname.TabIndex = 218;
            this.txtLastname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLastname_KeyUp);
            // 
            // vstudentinfoBindingSource
            // 
            this.vstudentinfoBindingSource.DataSource = typeof(StudentMonitoringSystem.Entities.vstudentinfo);
            // 
            // grdStudentInfoList
            // 
            this.grdStudentInfoList.AllowUserToAddRows = false;
            this.grdStudentInfoList.AllowUserToDeleteRows = false;
            this.grdStudentInfoList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStudentInfoList.AutoGenerateColumns = false;
            this.grdStudentInfoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdStudentInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudentInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.pictureDataGridViewTextBoxColumn,
            this.genderidDataGridViewTextBoxColumn,
            this.civilstatusidDataGridViewTextBoxColumn,
            this.civilstatusnameDataGridViewTextBoxColumn,
            this.citizenshipDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.barangayidDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.gendernameDataGridViewTextBoxColumn,
            this.barangaynameDataGridViewTextBoxColumn,
            this.cityidDataGridViewTextBoxColumn,
            this.citynameDataGridViewTextBoxColumn,
            this.provinceidDataGridViewTextBoxColumn,
            this.provincenameDataGridViewTextBoxColumn,
            this.fathernameDataGridViewTextBoxColumn,
            this.fatheroccupationDataGridViewTextBoxColumn,
            this.fathercontactnumberDataGridViewTextBoxColumn,
            this.fatheraddressDataGridViewTextBoxColumn,
            this.mothernameDataGridViewTextBoxColumn,
            this.motheroccupationDataGridViewTextBoxColumn,
            this.mothercontactnumberDataGridViewTextBoxColumn,
            this.motheraddressDataGridViewTextBoxColumn});
            this.grdStudentInfoList.DataSource = this.vstudentinfoBindingSource;
            this.grdStudentInfoList.Location = new System.Drawing.Point(3, 98);
            this.grdStudentInfoList.Name = "grdStudentInfoList";
            this.grdStudentInfoList.ReadOnly = true;
            this.grdStudentInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStudentInfoList.Size = new System.Drawing.Size(871, 272);
            this.grdStudentInfoList.TabIndex = 208;
            this.grdStudentInfoList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudentInfoList_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "middlename";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "Middlename";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            this.middlenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "dateofbirth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            this.dateofbirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureDataGridViewTextBoxColumn
            // 
            this.pictureDataGridViewTextBoxColumn.DataPropertyName = "picture";
            this.pictureDataGridViewTextBoxColumn.HeaderText = "Picture";
            this.pictureDataGridViewTextBoxColumn.Name = "pictureDataGridViewTextBoxColumn";
            this.pictureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderidDataGridViewTextBoxColumn
            // 
            this.genderidDataGridViewTextBoxColumn.DataPropertyName = "gender_id";
            this.genderidDataGridViewTextBoxColumn.HeaderText = "gender_id";
            this.genderidDataGridViewTextBoxColumn.Name = "genderidDataGridViewTextBoxColumn";
            this.genderidDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderidDataGridViewTextBoxColumn.Visible = false;
            // 
            // civilstatusidDataGridViewTextBoxColumn
            // 
            this.civilstatusidDataGridViewTextBoxColumn.DataPropertyName = "civilstatus_id";
            this.civilstatusidDataGridViewTextBoxColumn.HeaderText = "civilstatus_id";
            this.civilstatusidDataGridViewTextBoxColumn.Name = "civilstatusidDataGridViewTextBoxColumn";
            this.civilstatusidDataGridViewTextBoxColumn.ReadOnly = true;
            this.civilstatusidDataGridViewTextBoxColumn.Visible = false;
            // 
            // civilstatusnameDataGridViewTextBoxColumn
            // 
            this.civilstatusnameDataGridViewTextBoxColumn.DataPropertyName = "civilstatus_name";
            this.civilstatusnameDataGridViewTextBoxColumn.HeaderText = "Civil Status";
            this.civilstatusnameDataGridViewTextBoxColumn.Name = "civilstatusnameDataGridViewTextBoxColumn";
            this.civilstatusnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // citizenshipDataGridViewTextBoxColumn
            // 
            this.citizenshipDataGridViewTextBoxColumn.DataPropertyName = "citizenship";
            this.citizenshipDataGridViewTextBoxColumn.HeaderText = "Citizenship";
            this.citizenshipDataGridViewTextBoxColumn.Name = "citizenshipDataGridViewTextBoxColumn";
            this.citizenshipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barangayidDataGridViewTextBoxColumn
            // 
            this.barangayidDataGridViewTextBoxColumn.DataPropertyName = "barangay_id";
            this.barangayidDataGridViewTextBoxColumn.HeaderText = "barangay_id";
            this.barangayidDataGridViewTextBoxColumn.Name = "barangayidDataGridViewTextBoxColumn";
            this.barangayidDataGridViewTextBoxColumn.ReadOnly = true;
            this.barangayidDataGridViewTextBoxColumn.Visible = false;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gendernameDataGridViewTextBoxColumn
            // 
            this.gendernameDataGridViewTextBoxColumn.DataPropertyName = "gender_name";
            this.gendernameDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.gendernameDataGridViewTextBoxColumn.Name = "gendernameDataGridViewTextBoxColumn";
            this.gendernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barangaynameDataGridViewTextBoxColumn
            // 
            this.barangaynameDataGridViewTextBoxColumn.DataPropertyName = "barangay_name";
            this.barangaynameDataGridViewTextBoxColumn.HeaderText = "Barangay";
            this.barangaynameDataGridViewTextBoxColumn.Name = "barangaynameDataGridViewTextBoxColumn";
            this.barangaynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityidDataGridViewTextBoxColumn
            // 
            this.cityidDataGridViewTextBoxColumn.DataPropertyName = "city_id";
            this.cityidDataGridViewTextBoxColumn.HeaderText = "city_id";
            this.cityidDataGridViewTextBoxColumn.Name = "cityidDataGridViewTextBoxColumn";
            this.cityidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityidDataGridViewTextBoxColumn.Visible = false;
            // 
            // citynameDataGridViewTextBoxColumn
            // 
            this.citynameDataGridViewTextBoxColumn.DataPropertyName = "city_name";
            this.citynameDataGridViewTextBoxColumn.HeaderText = "City";
            this.citynameDataGridViewTextBoxColumn.Name = "citynameDataGridViewTextBoxColumn";
            this.citynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provinceidDataGridViewTextBoxColumn
            // 
            this.provinceidDataGridViewTextBoxColumn.DataPropertyName = "province_id";
            this.provinceidDataGridViewTextBoxColumn.HeaderText = "province_id";
            this.provinceidDataGridViewTextBoxColumn.Name = "provinceidDataGridViewTextBoxColumn";
            this.provinceidDataGridViewTextBoxColumn.ReadOnly = true;
            this.provinceidDataGridViewTextBoxColumn.Visible = false;
            // 
            // provincenameDataGridViewTextBoxColumn
            // 
            this.provincenameDataGridViewTextBoxColumn.DataPropertyName = "province_name";
            this.provincenameDataGridViewTextBoxColumn.HeaderText = "Province";
            this.provincenameDataGridViewTextBoxColumn.Name = "provincenameDataGridViewTextBoxColumn";
            this.provincenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fathernameDataGridViewTextBoxColumn
            // 
            this.fathernameDataGridViewTextBoxColumn.DataPropertyName = "fathername";
            this.fathernameDataGridViewTextBoxColumn.HeaderText = "Father";
            this.fathernameDataGridViewTextBoxColumn.Name = "fathernameDataGridViewTextBoxColumn";
            this.fathernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fatheroccupationDataGridViewTextBoxColumn
            // 
            this.fatheroccupationDataGridViewTextBoxColumn.DataPropertyName = "fatheroccupation";
            this.fatheroccupationDataGridViewTextBoxColumn.HeaderText = "Father Occupation";
            this.fatheroccupationDataGridViewTextBoxColumn.Name = "fatheroccupationDataGridViewTextBoxColumn";
            this.fatheroccupationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fathercontactnumberDataGridViewTextBoxColumn
            // 
            this.fathercontactnumberDataGridViewTextBoxColumn.DataPropertyName = "fathercontactnumber";
            this.fathercontactnumberDataGridViewTextBoxColumn.HeaderText = "Father Contact No.";
            this.fathercontactnumberDataGridViewTextBoxColumn.Name = "fathercontactnumberDataGridViewTextBoxColumn";
            this.fathercontactnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fatheraddressDataGridViewTextBoxColumn
            // 
            this.fatheraddressDataGridViewTextBoxColumn.DataPropertyName = "fatheraddress";
            this.fatheraddressDataGridViewTextBoxColumn.HeaderText = "Father Address";
            this.fatheraddressDataGridViewTextBoxColumn.Name = "fatheraddressDataGridViewTextBoxColumn";
            this.fatheraddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mothernameDataGridViewTextBoxColumn
            // 
            this.mothernameDataGridViewTextBoxColumn.DataPropertyName = "mothername";
            this.mothernameDataGridViewTextBoxColumn.HeaderText = "Mother";
            this.mothernameDataGridViewTextBoxColumn.Name = "mothernameDataGridViewTextBoxColumn";
            this.mothernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motheroccupationDataGridViewTextBoxColumn
            // 
            this.motheroccupationDataGridViewTextBoxColumn.DataPropertyName = "motheroccupation";
            this.motheroccupationDataGridViewTextBoxColumn.HeaderText = "Mother Occupation";
            this.motheroccupationDataGridViewTextBoxColumn.Name = "motheroccupationDataGridViewTextBoxColumn";
            this.motheroccupationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mothercontactnumberDataGridViewTextBoxColumn
            // 
            this.mothercontactnumberDataGridViewTextBoxColumn.DataPropertyName = "mothercontactnumber";
            this.mothercontactnumberDataGridViewTextBoxColumn.HeaderText = "Mother Contact No.";
            this.mothercontactnumberDataGridViewTextBoxColumn.Name = "mothercontactnumberDataGridViewTextBoxColumn";
            this.mothercontactnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motheraddressDataGridViewTextBoxColumn
            // 
            this.motheraddressDataGridViewTextBoxColumn.DataPropertyName = "motheraddress";
            this.motheraddressDataGridViewTextBoxColumn.HeaderText = "Mother Address";
            this.motheraddressDataGridViewTextBoxColumn.Name = "motheraddressDataGridViewTextBoxColumn";
            this.motheraddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(23, 71);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(46, 13);
            this.label28.TabIndex = 266;
            this.label28.Text = "Section:";
            // 
            // cmbSection
            // 
            this.cmbSection.DisplayMember = "name";
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(71, 71);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(212, 21);
            this.cmbSection.TabIndex = 267;
            this.cmbSection.ValueMember = "id";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.ForeColor = System.Drawing.Color.Red;
            this.label42.Location = new System.Drawing.Point(10, 71);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(11, 13);
            this.label42.TabIndex = 268;
            this.label42.Text = "*";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(319, 71);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(54, 13);
            this.label51.TabIndex = 263;
            this.label51.Text = "Semester:";
            // 
            // cmbSemester
            // 
            this.cmbSemester.DisplayMember = "name";
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(389, 71);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(212, 21);
            this.cmbSemester.TabIndex = 264;
            this.cmbSemester.ValueMember = "id";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.ForeColor = System.Drawing.Color.Red;
            this.label52.Location = new System.Drawing.Point(310, 71);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(11, 13);
            this.label52.TabIndex = 265;
            this.label52.Text = "*";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(319, 42);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(68, 13);
            this.label53.TabIndex = 260;
            this.label53.Text = "School Year:";
            // 
            // cmbSchoolYear
            // 
            this.cmbSchoolYear.DisplayMember = "name";
            this.cmbSchoolYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchoolYear.FormattingEnabled = true;
            this.cmbSchoolYear.Location = new System.Drawing.Point(389, 42);
            this.cmbSchoolYear.Name = "cmbSchoolYear";
            this.cmbSchoolYear.Size = new System.Drawing.Size(212, 21);
            this.cmbSchoolYear.TabIndex = 261;
            this.cmbSchoolYear.ValueMember = "id";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.ForeColor = System.Drawing.Color.Red;
            this.label54.Location = new System.Drawing.Point(310, 42);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(11, 13);
            this.label54.TabIndex = 262;
            this.label54.Text = "*";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(23, 42);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(36, 13);
            this.label55.TabIndex = 257;
            this.label55.Text = "Level:";
            // 
            // cmbLevel
            // 
            this.cmbLevel.DisplayMember = "name";
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Location = new System.Drawing.Point(71, 42);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(212, 21);
            this.cmbLevel.TabIndex = 258;
            this.cmbLevel.ValueMember = "id";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.ForeColor = System.Drawing.Color.Red;
            this.label56.Location = new System.Drawing.Point(10, 42);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(11, 13);
            this.label56.TabIndex = 259;
            this.label56.Text = "*";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(23, 12);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(43, 13);
            this.label57.TabIndex = 254;
            this.label57.Text = "Course:";
            // 
            // cmbCourse
            // 
            this.cmbCourse.DisplayMember = "name";
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(71, 12);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(529, 21);
            this.cmbCourse.TabIndex = 255;
            this.cmbCourse.ValueMember = "id";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.ForeColor = System.Drawing.Color.Red;
            this.label58.Location = new System.Drawing.Point(10, 12);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(11, 13);
            this.label58.TabIndex = 256;
            this.label58.Text = "*";
            // 
            // FormStudentInfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 372);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.cmbSchoolYear);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.grdStudentInfoList);
            this.Name = "FormStudentInfoList";
            this.TabText = "StudentInfoList";
            this.Tag = "";
            this.Text = "StudentInfoList";
            this.Load += new System.EventHandler(this.FormStudentInfoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vstudentinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentInfoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentInfoListDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentInfoListidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.BindingSource vstudentinfoBindingSource;
        private System.Windows.Forms.DataGridView grdStudentInfoList;
        private System.Windows.Forms.Label label28;
        public System.Windows.Forms.ComboBox cmbSection;
        internal System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label51;
        public System.Windows.Forms.ComboBox cmbSemester;
        internal System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        public System.Windows.Forms.ComboBox cmbSchoolYear;
        internal System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        public System.Windows.Forms.ComboBox cmbLevel;
        internal System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        public System.Windows.Forms.ComboBox cmbCourse;
        internal System.Windows.Forms.Label label58;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn civilstatusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn civilstatusnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citizenshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barangayidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gendernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barangaynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatheroccupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathercontactnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatheraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mothernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motheroccupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mothercontactnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motheraddressDataGridViewTextBoxColumn;
    }
}