﻿namespace StudentMonitoringSystem.Forms.Enroll
{
    partial class FormSection
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
            this.grdSection = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.course_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSectioninfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdSection)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vSectioninfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSection
            // 
            this.grdSection.AllowUserToAddRows = false;
            this.grdSection.AllowUserToDeleteRows = false;
            this.grdSection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSection.AutoGenerateColumns = false;
            this.grdSection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.course_code,
            this.course_name});
            this.grdSection.DataSource = this.vSectioninfoBindingSource;
            this.grdSection.Location = new System.Drawing.Point(3, 110);
            this.grdSection.Name = "grdSection";
            this.grdSection.ReadOnly = true;
            this.grdSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSection.Size = new System.Drawing.Size(799, 260);
            this.grdSection.TabIndex = 208;
            this.grdSection.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSection_CellClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(529, 20);
            this.txtName.TabIndex = 209;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 214;
            this.label7.Text = "Name.:";
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
            this.cmbCourse.Size = new System.Drawing.Size(529, 21);
            this.cmbCourse.TabIndex = 213;
            this.cmbCourse.ValueMember = "id";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.ForeColor = System.Drawing.Color.Red;
            this.Label22.Location = new System.Drawing.Point(19, 44);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(11, 13);
            this.Label22.TabIndex = 215;
            this.Label22.Text = "*";
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
            // course_code
            // 
            this.course_code.DataPropertyName = "course_code";
            this.course_code.HeaderText = "Course Code";
            this.course_code.Name = "course_code";
            this.course_code.ReadOnly = true;
            // 
            // course_name
            // 
            this.course_name.DataPropertyName = "course_name";
            this.course_name.HeaderText = "Course";
            this.course_name.Name = "course_name";
            this.course_name.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vSectioninfoBindingSource
            // 
            this.vSectioninfoBindingSource.DataSource = typeof(StudentMonitoringSystem.Entities.vsectioninfo);
            // 
            // FormSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 372);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.Label22);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.grdSection);
            this.Name = "FormSection";
            this.TabText = "Section";
            this.Tag = "";
            this.Text = "Section";
            this.Load += new System.EventHandler(this.FormSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSection)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vSectioninfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCourse;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label label27;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView grdSection;
        private System.Windows.Forms.BindingSource vSectioninfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_name;
    }
}