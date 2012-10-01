namespace Ctl
{
    partial class ctlCity
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.grdCity = new Telerik.WinControls.UI.RadGridView();
            this.vcityinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcityinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 222;
            this.label7.Text = "Name.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 220;
            this.label4.Text = "Province:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(19, 19);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(11, 13);
            this.label27.TabIndex = 224;
            this.label27.Text = "*";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(392, 20);
            this.txtName.TabIndex = 219;
            // 
            // cmbProvince
            // 
            this.cmbProvince.DisplayMember = "name";
            this.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(87, 19);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(392, 21);
            this.cmbProvince.TabIndex = 221;
            this.cmbProvince.ValueMember = "id";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.ForeColor = System.Drawing.Color.Red;
            this.Label22.Location = new System.Drawing.Point(19, 51);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(11, 13);
            this.Label22.TabIndex = 223;
            this.Label22.Text = "*";
            // 
            // grdCity
            // 
            this.grdCity.Location = new System.Drawing.Point(13, 88);
            // 
            // grdCity
            // 
            this.grdCity.MasterTemplate.AllowAddNewRow = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "id";
            gridViewDecimalColumn1.FormatString = "";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "id";
            gridViewDecimalColumn1.Width = 19;
            gridViewTextBoxColumn1.FieldName = "name";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "name";
            gridViewTextBoxColumn1.Width = 38;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "province_id";
            gridViewDecimalColumn2.FormatString = "";
            gridViewDecimalColumn2.HeaderText = "province_id";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "province_id";
            gridViewTextBoxColumn2.FieldName = "province_name";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Province";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "province_name";
            gridViewTextBoxColumn2.Width = 51;
            this.grdCity.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn2});
            this.grdCity.MasterTemplate.DataSource = this.vcityinfoBindingSource;
            this.grdCity.Name = "grdCity";
            this.grdCity.ReadOnly = true;
            this.grdCity.Size = new System.Drawing.Size(459, 208);
            this.grdCity.TabIndex = 226;
            this.grdCity.Text = "radGridView1";
            this.grdCity.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.grdCity_CurrentRowChanged);
            
            // 
            // vcityinfoBindingSource
            // 
            this.vcityinfoBindingSource.DataSource = typeof(StudentMonitoringSystem.Entities.vcityinfo);
            // 
            // ctlCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbProvince);
            this.Controls.Add(this.Label22);
            this.Name = "ctlCity";
            this.Size = new System.Drawing.Size(497, 299);
            ((System.ComponentModel.ISupportInitialize)(this.grdCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vcityinfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbProvince;
        internal System.Windows.Forms.Label Label22;
        private Telerik.WinControls.UI.RadGridView grdCity;
        private System.Windows.Forms.BindingSource vcityinfoBindingSource;
    }
}
