namespace StudentMonitoringSystem.Forms.Student
{
    partial class Student
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripcmbSection = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRestore = new System.Windows.Forms.Button();
            this.Label39 = new System.Windows.Forms.Label();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnViewArchive = new System.Windows.Forms.Button();
            this.CD = new System.Windows.Forms.OpenFileDialog();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.txtNumber = new System.Windows.Forms.MaskedTextBox();
            this.Label48 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Label50 = new System.Windows.Forms.Label();
            this.Label45 = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.Label46 = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnWebcam = new System.Windows.Forms.Button();
            this.Label21 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.cmbDOB = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.CDPictureBox = new System.Windows.Forms.PictureBox();
            this.CDWebcam = new System.Windows.Forms.PictureBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCitizenship = new System.Windows.Forms.ComboBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAutoTxt = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.grdStudents = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CDPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDWebcam)).BeginInit();
            this.TabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveToolStripMenuItem,
            this.RefreshDataToolStripMenuItem,
            this.ExportToExcelToolStripMenuItem,
            this.ToolStripSeparator2,
            this.UpdateSectionToolStripMenuItem,
            this.ToolStripSeparator3,
            this.ArchiveToolStripMenuItem,
            this.RestoreToolStripMenuItem,
            this.ToolStripSeparator1,
            this.DeleteToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(192, 176);
            // 
            // RemoveToolStripMenuItem
            // 
            this.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem";
            this.RemoveToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.RemoveToolStripMenuItem.Text = "Remove Selected Data";
            // 
            // RefreshDataToolStripMenuItem
            // 
            this.RefreshDataToolStripMenuItem.Name = "RefreshDataToolStripMenuItem";
            this.RefreshDataToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.RefreshDataToolStripMenuItem.Text = "Refresh Data";
            // 
            // ExportToExcelToolStripMenuItem
            // 
            this.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem";
            this.ExportToExcelToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ExportToExcelToolStripMenuItem.Text = "Export to Excel";
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // UpdateSectionToolStripMenuItem
            // 
            this.UpdateSectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripcmbSection});
            this.UpdateSectionToolStripMenuItem.Name = "UpdateSectionToolStripMenuItem";
            this.UpdateSectionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.UpdateSectionToolStripMenuItem.Text = "Update Section";
            // 
            // ToolStripcmbSection
            // 
            this.ToolStripcmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolStripcmbSection.Name = "ToolStripcmbSection";
            this.ToolStripcmbSection.Size = new System.Drawing.Size(121, 23);
            this.ToolStripcmbSection.Sorted = true;
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(188, 6);
            // 
            // ArchiveToolStripMenuItem
            // 
            this.ArchiveToolStripMenuItem.Name = "ArchiveToolStripMenuItem";
            this.ArchiveToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ArchiveToolStripMenuItem.Text = "Archive Selected";
            // 
            // RestoreToolStripMenuItem
            // 
            this.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem";
            this.RestoreToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.RestoreToolStripMenuItem.Text = "Restore Selected";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.DeleteToolStripMenuItem.Text = "Delete Permanently";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel2,
            this.lblCount});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 670);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(1009, 22);
            this.StatusStrip1.TabIndex = 244;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(112, 17);
            this.ToolStripStatusLabel2.Text = "Number of Student:";
            // 
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(14, 17);
            this.lblCount.Text = "#";
            // 
            // btnRestore
            // 
            this.btnRestore.Enabled = false;
            this.btnRestore.Location = new System.Drawing.Point(916, 32);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(81, 23);
            this.btnRestore.TabIndex = 236;
            this.btnRestore.Text = "&Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Visible = false;
            // 
            // Label39
            // 
            this.Label39.AutoSize = true;
            this.Label39.Location = new System.Drawing.Point(13, 179);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(44, 13);
            this.Label39.TabIndex = 242;
            this.Label39.Text = "Search:";
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(371, 177);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(61, 17);
            this.RadioButton2.TabIndex = 246;
            this.RadioButton2.Text = "Archive";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(63, 176);
            this.txtSearch.MaxLength = 255;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 20);
            this.txtSearch.TabIndex = 238;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(916, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 23);
            this.btnDelete.TabIndex = 237;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // btnArchive
            // 
            this.btnArchive.Enabled = false;
            this.btnArchive.Location = new System.Drawing.Point(916, 61);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(81, 23);
            this.btnArchive.TabIndex = 234;
            this.btnArchive.Text = "&Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(916, 146);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 23);
            this.btnRefresh.TabIndex = 239;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnAdd);
            this.GroupBox1.Controls.Add(this.btnCancel);
            this.GroupBox1.Controls.Add(this.btnSubmit);
            this.GroupBox1.Controls.Add(this.btnUpdate);
            this.GroupBox1.Location = new System.Drawing.Point(815, 24);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(95, 145);
            this.GroupBox1.TabIndex = 243;
            this.GroupBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 23);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "&Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(6, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 23);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(6, 48);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(81, 23);
            this.btnSubmit.TabIndex = 31;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(6, 77);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnViewArchive
            // 
            this.btnViewArchive.Location = new System.Drawing.Point(916, 117);
            this.btnViewArchive.Name = "btnViewArchive";
            this.btnViewArchive.Size = new System.Drawing.Size(81, 23);
            this.btnViewArchive.TabIndex = 235;
            this.btnViewArchive.Text = "&View Archive";
            this.btnViewArchive.UseVisualStyleBackColor = true;
            this.btnViewArchive.Visible = false;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(717, 158);
            this.TabControl1.TabIndex = 233;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.txtNumber);
            this.TabPage1.Controls.Add(this.Label48);
            this.TabPage1.Controls.Add(this.txtEmail);
            this.TabPage1.Controls.Add(this.Label50);
            this.TabPage1.Controls.Add(this.Label45);
            this.TabPage1.Controls.Add(this.cmbSection);
            this.TabPage1.Controls.Add(this.Label46);
            this.TabPage1.Controls.Add(this.txtStudentNumber);
            this.TabPage1.Controls.Add(this.lblAge);
            this.TabPage1.Controls.Add(this.btnWebcam);
            this.TabPage1.Controls.Add(this.Label21);
            this.TabPage1.Controls.Add(this.txtMiddleName);
            this.TabPage1.Controls.Add(this.Label26);
            this.TabPage1.Controls.Add(this.Label25);
            this.TabPage1.Controls.Add(this.Label24);
            this.TabPage1.Controls.Add(this.Label23);
            this.TabPage1.Controls.Add(this.Label22);
            this.TabPage1.Controls.Add(this.cmbDOB);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.txtFirstName);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.txtLastName);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.CDPictureBox);
            this.TabPage1.Controls.Add(this.CDWebcam);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(709, 132);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Student Information";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(355, 68);
            this.txtNumber.Mask = "(9999) 000 - 0000";
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.PromptChar = ' ';
            this.txtNumber.Size = new System.Drawing.Size(142, 20);
            this.txtNumber.TabIndex = 223;
            // 
            // Label48
            // 
            this.Label48.AutoSize = true;
            this.Label48.ForeColor = System.Drawing.Color.DimGray;
            this.Label48.Location = new System.Drawing.Point(297, 98);
            this.Label48.Name = "Label48";
            this.Label48.Size = new System.Drawing.Size(35, 13);
            this.Label48.TabIndex = 226;
            this.Label48.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(355, 94);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(142, 20);
            this.txtEmail.TabIndex = 224;
            // 
            // Label50
            // 
            this.Label50.AutoSize = true;
            this.Label50.ForeColor = System.Drawing.Color.DimGray;
            this.Label50.Location = new System.Drawing.Point(297, 72);
            this.Label50.Name = "Label50";
            this.Label50.Size = new System.Drawing.Size(47, 13);
            this.Label50.TabIndex = 225;
            this.Label50.Text = "Number:";
            // 
            // Label45
            // 
            this.Label45.AutoSize = true;
            this.Label45.ForeColor = System.Drawing.Color.Red;
            this.Label45.Location = new System.Drawing.Point(286, 16);
            this.Label45.Name = "Label45";
            this.Label45.Size = new System.Drawing.Size(11, 13);
            this.Label45.TabIndex = 210;
            this.Label45.Text = "*";
            // 
            // cmbSection
            // 
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(355, 16);
            this.cmbSection.MaxDropDownItems = 30;
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(98, 21);
            this.cmbSection.TabIndex = 208;
            // 
            // Label46
            // 
            this.Label46.AutoSize = true;
            this.Label46.ForeColor = System.Drawing.Color.DimGray;
            this.Label46.Location = new System.Drawing.Point(297, 18);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(46, 13);
            this.Label46.TabIndex = 209;
            this.Label46.Text = "Section:";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(96, 16);
            this.txtStudentNumber.MaxLength = 100;
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(173, 20);
            this.txtStudentNumber.TabIndex = 207;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.ForeColor = System.Drawing.Color.DimGray;
            this.lblAge.Location = new System.Drawing.Point(459, 45);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 13);
            this.lblAge.TabIndex = 206;
            this.lblAge.Text = "Age: 0";
            // 
            // btnWebcam
            // 
            this.btnWebcam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWebcam.Image = global::StudentMonitoringSystem.Properties.Resources.Webcam_icon;
            this.btnWebcam.Location = new System.Drawing.Point(665, 91);
            this.btnWebcam.Name = "btnWebcam";
            this.btnWebcam.Size = new System.Drawing.Size(37, 35);
            this.btnWebcam.TabIndex = 203;
            this.btnWebcam.UseVisualStyleBackColor = true;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.ForeColor = System.Drawing.Color.Red;
            this.Label21.Location = new System.Drawing.Point(8, 72);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(11, 13);
            this.Label21.TabIndex = 196;
            this.Label21.Text = "*";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(96, 68);
            this.txtMiddleName.MaxLength = 100;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(173, 20);
            this.txtMiddleName.TabIndex = 2;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.ForeColor = System.Drawing.Color.DimGray;
            this.Label26.Location = new System.Drawing.Point(18, 72);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(72, 13);
            this.Label26.TabIndex = 195;
            this.Label26.Text = "Middle Name:";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.ForeColor = System.Drawing.Color.Red;
            this.Label25.Location = new System.Drawing.Point(286, 43);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(11, 13);
            this.Label25.TabIndex = 191;
            this.Label25.Text = "*";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.ForeColor = System.Drawing.Color.Red;
            this.Label24.Location = new System.Drawing.Point(8, 45);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(11, 13);
            this.Label24.TabIndex = 190;
            this.Label24.Text = "*";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.ForeColor = System.Drawing.Color.Red;
            this.Label23.Location = new System.Drawing.Point(8, 98);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(11, 13);
            this.Label23.TabIndex = 189;
            this.Label23.Text = "*";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.ForeColor = System.Drawing.Color.Red;
            this.Label22.Location = new System.Drawing.Point(8, 18);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(11, 13);
            this.Label22.TabIndex = 188;
            this.Label22.Text = "*";
            // 
            // cmbDOB
            // 
            this.cmbDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cmbDOB.Location = new System.Drawing.Point(355, 41);
            this.cmbDOB.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.cmbDOB.Name = "cmbDOB";
            this.cmbDOB.Size = new System.Drawing.Size(98, 20);
            this.cmbDOB.TabIndex = 7;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.Color.DimGray;
            this.Label4.Location = new System.Drawing.Point(297, 45);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 13);
            this.Label4.TabIndex = 184;
            this.Label4.Text = "Birthday:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(96, 42);
            this.txtFirstName.MaxLength = 100;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(173, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.Color.DimGray;
            this.Label3.Location = new System.Drawing.Point(18, 45);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 13);
            this.Label3.TabIndex = 183;
            this.Label3.Text = "First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(96, 94);
            this.txtLastName.MaxLength = 100;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(173, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.Color.DimGray;
            this.Label2.Location = new System.Drawing.Point(18, 98);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(61, 13);
            this.Label2.TabIndex = 182;
            this.Label2.Text = "Last Name:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.Color.DimGray;
            this.Label1.Location = new System.Drawing.Point(18, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(61, 13);
            this.Label1.TabIndex = 181;
            this.Label1.Text = "Student ID:";
            // 
            // CDPictureBox
            // 
            this.CDPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CDPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CDPictureBox.Location = new System.Drawing.Point(515, 6);
            this.CDPictureBox.Name = "CDPictureBox";
            this.CDPictureBox.Size = new System.Drawing.Size(144, 120);
            this.CDPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CDPictureBox.TabIndex = 204;
            this.CDPictureBox.TabStop = false;
            // 
            // CDWebcam
            // 
            this.CDWebcam.BackColor = System.Drawing.Color.Gainsboro;
            this.CDWebcam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CDWebcam.Location = new System.Drawing.Point(515, 6);
            this.CDWebcam.Name = "CDWebcam";
            this.CDWebcam.Size = new System.Drawing.Size(144, 120);
            this.CDWebcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CDWebcam.TabIndex = 205;
            this.CDWebcam.TabStop = false;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.groupBox3);
            this.TabPage3.Controls.Add(this.groupBox2);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(709, 132);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Guardian";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbCitizenship);
            this.groupBox3.Controls.Add(this.Label18);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 120);
            this.groupBox3.TabIndex = 232;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Guardian";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(69, 50);
            this.maskedTextBox1.Mask = "(9999) 000 - 0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.Size = new System.Drawing.Size(208, 20);
            this.maskedTextBox1.TabIndex = 237;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(10, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 240;
            this.label5.Text = "Email:";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox1.Location = new System.Drawing.Point(69, 76);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 238;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(10, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 239;
            this.label6.Text = "Number:";
            // 
            // cmbCitizenship
            // 
            this.cmbCitizenship.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCitizenship.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCitizenship.FormattingEnabled = true;
            this.cmbCitizenship.Location = new System.Drawing.Point(69, 23);
            this.cmbCitizenship.MaxLength = 100;
            this.cmbCitizenship.Name = "cmbCitizenship";
            this.cmbCitizenship.Size = new System.Drawing.Size(208, 21);
            this.cmbCitizenship.Sorted = true;
            this.cmbCitizenship.TabIndex = 236;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.ForeColor = System.Drawing.Color.DimGray;
            this.Label18.Location = new System.Drawing.Point(10, 26);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(53, 13);
            this.Label18.TabIndex = 231;
            this.Label18.Text = "Guardian:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAutoTxt);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(299, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 117);
            this.groupBox2.TabIndex = 231;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notification";
            // 
            // chkAutoTxt
            // 
            this.chkAutoTxt.AutoSize = true;
            this.chkAutoTxt.ForeColor = System.Drawing.Color.DimGray;
            this.chkAutoTxt.Location = new System.Drawing.Point(15, 18);
            this.chkAutoTxt.Name = "chkAutoTxt";
            this.chkAutoTxt.Size = new System.Drawing.Size(74, 17);
            this.chkAutoTxt.TabIndex = 199;
            this.chkAutoTxt.Text = "Auto SMS";
            this.chkAutoTxt.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox1.Location = new System.Drawing.Point(15, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 225;
            this.checkBox1.Text = "Auto Email";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TabPage5
            // 
            this.TabPage5.Controls.Add(this.txtNote);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage5.Size = new System.Drawing.Size(709, 132);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "Note";
            this.TabPage5.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(6, 6);
            this.txtNote.MaxLength = 2000;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(697, 120);
            this.txtNote.TabIndex = 30;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(289, 177);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(76, 17);
            this.RadioButton1.TabIndex = 245;
            this.RadioButton1.Text = "Master List";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // grdStudents
            // 
            this.grdStudents.AllowUserToAddRows = false;
            this.grdStudents.AllowUserToDeleteRows = false;
            this.grdStudents.AllowUserToOrderColumns = true;
            this.grdStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdStudents.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentNumber,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Birthday,
            this.ImagePath,
            this.EmailAddress,
            this.SectionID,
            this.RFID,
            this.Active,
            this.Note,
            this.CreatedBy,
            this.CreatedDate,
            this.ModifiedBy,
            this.ModifiedDate});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdStudents.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdStudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdStudents.Location = new System.Drawing.Point(0, 205);
            this.grdStudents.Name = "grdStudents";
            this.grdStudents.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdStudents.RowHeadersVisible = false;
            this.grdStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStudents.Size = new System.Drawing.Size(1009, 465);
            this.grdStudents.TabIndex = 247;
            this.grdStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudents_CellContentClick);
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Visible = false;
            this.StudentID.Width = 69;
            // 
            // StudentNumber
            // 
            this.StudentNumber.DataPropertyName = "StudentNumber";
            this.StudentNumber.FillWeight = 113.7177F;
            this.StudentNumber.HeaderText = "Student No.";
            this.StudentNumber.Name = "StudentNumber";
            this.StudentNumber.ReadOnly = true;
            this.StudentNumber.Width = 95;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.FillWeight = 106.1442F;
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 91;
            // 
            // MiddleName
            // 
            this.MiddleName.DataPropertyName = "MiddleName";
            this.MiddleName.FillWeight = 118.0399F;
            this.MiddleName.HeaderText = "Middle Name";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            this.MiddleName.Width = 103;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.FillWeight = 100.3971F;
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 90;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = null;
            this.Birthday.DefaultCellStyle = dataGridViewCellStyle3;
            this.Birthday.FillWeight = 91.95496F;
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.Width = 77;
            // 
            // ImagePath
            // 
            this.ImagePath.DataPropertyName = "ImagePath";
            this.ImagePath.HeaderText = "ImagePath";
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.ReadOnly = true;
            this.ImagePath.Visible = false;
            this.ImagePath.Width = 90;
            // 
            // EmailAddress
            // 
            this.EmailAddress.DataPropertyName = "EmailAddress";
            this.EmailAddress.FillWeight = 122.2845F;
            this.EmailAddress.HeaderText = "Email Address";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            this.EmailAddress.Width = 112;
            // 
            // SectionID
            // 
            this.SectionID.DataPropertyName = "SectionID";
            this.SectionID.FillWeight = 83.95642F;
            this.SectionID.HeaderText = "Section";
            this.SectionID.Name = "SectionID";
            this.SectionID.ReadOnly = true;
            this.SectionID.Width = 73;
            // 
            // RFID
            // 
            this.RFID.DataPropertyName = "RFID";
            this.RFID.HeaderText = "RFID";
            this.RFID.Name = "RFID";
            this.RFID.ReadOnly = true;
            this.RFID.Width = 55;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.FillWeight = 77.23605F;
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Active.Width = 50;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.FillWeight = 65.60966F;
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 57;
            // 
            // CreatedBy
            // 
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.FillWeight = 100.12F;
            this.CreatedBy.HeaderText = "Created By";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.ReadOnly = true;
            this.CreatedBy.Width = 92;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.FillWeight = 110.4636F;
            this.CreatedDate.HeaderText = "Created Date";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            this.CreatedDate.Width = 103;
            // 
            // ModifiedBy
            // 
            this.ModifiedBy.DataPropertyName = "ModifiedBy";
            this.ModifiedBy.FillWeight = 100.0898F;
            this.ModifiedBy.HeaderText = "Modified By";
            this.ModifiedBy.Name = "ModifiedBy";
            this.ModifiedBy.ReadOnly = true;
            this.ModifiedBy.Width = 96;
            // 
            // ModifiedDate
            // 
            this.ModifiedDate.DataPropertyName = "ModifiedDate";
            this.ModifiedDate.FillWeight = 109.986F;
            this.ModifiedDate.HeaderText = "Modified Date";
            this.ModifiedDate.Name = "ModifiedDate";
            this.ModifiedDate.ReadOnly = true;
            this.ModifiedDate.Width = 107;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 692);
            this.Controls.Add(this.grdStudents);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.Label39);
            this.Controls.Add(this.RadioButton2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnViewArchive);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.RadioButton1);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.ContextMenuStrip1.ResumeLayout(false);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CDPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDWebcam)).EndInit();
            this.TabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem RemoveToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RefreshDataToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExportToExcelToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem UpdateSectionToolStripMenuItem;
        internal System.Windows.Forms.ToolStripComboBox ToolStripcmbSection;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripMenuItem ArchiveToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RestoreToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        internal System.Windows.Forms.ToolStripStatusLabel lblCount;
        internal System.Windows.Forms.Button btnRestore;
        internal System.Windows.Forms.Label Label39;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnArchive;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSubmit;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnViewArchive;
        internal System.Windows.Forms.OpenFileDialog CD;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Label lblAge;
        internal System.Windows.Forms.Button btnWebcam;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.TextBox txtMiddleName;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.DateTimePicker cmbDOB;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox CDPictureBox;
        internal System.Windows.Forms.PictureBox CDWebcam;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.CheckBox chkAutoTxt;
        internal System.Windows.Forms.TabPage TabPage5;
        internal System.Windows.Forms.TextBox txtNote;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.TextBox txtStudentNumber;
        internal System.Windows.Forms.Label Label45;
        internal System.Windows.Forms.ComboBox cmbSection;
        internal System.Windows.Forms.Label Label46;
        internal System.Windows.Forms.CheckBox checkBox1;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.ComboBox cmbCitizenship;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.MaskedTextBox txtNumber;
        internal System.Windows.Forms.Label Label48;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label Label50;
        internal System.Windows.Forms.MaskedTextBox maskedTextBox1;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.DataGridView grdStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImagePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedDate;
    }
}