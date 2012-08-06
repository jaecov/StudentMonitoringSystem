namespace StudentMonitoringSystem.Forms.SMS
{
    partial class FormNetworkProviderCode
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
            this.grdNetworkProviderCode = new System.Windows.Forms.DataGridView();
            this.vNetworkProviderCodeinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNetworkProvider = new System.Windows.Forms.ComboBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.networkprovider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdNetworkProviderCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNetworkProviderCodeinfoBindingSource)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdNetworkProviderCode
            // 
            this.grdNetworkProviderCode.AllowUserToAddRows = false;
            this.grdNetworkProviderCode.AllowUserToDeleteRows = false;
            this.grdNetworkProviderCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdNetworkProviderCode.AutoGenerateColumns = false;
            this.grdNetworkProviderCode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdNetworkProviderCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNetworkProviderCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.networkprovider});
            this.grdNetworkProviderCode.DataSource = this.vNetworkProviderCodeinfoBindingSource;
            this.grdNetworkProviderCode.Location = new System.Drawing.Point(3, 110);
            this.grdNetworkProviderCode.Name = "grdNetworkProviderCode";
            this.grdNetworkProviderCode.ReadOnly = true;
            this.grdNetworkProviderCode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdNetworkProviderCode.Size = new System.Drawing.Size(799, 260);
            this.grdNetworkProviderCode.TabIndex = 208;
            this.grdNetworkProviderCode.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNetworkProviderCode_CellClick);
            // 
            // vNetworkProviderCodeinfoBindingSource
            // 
            this.vNetworkProviderCodeinfoBindingSource.DataSource = typeof(StudentMonitoringSystem.Entities.vnetworkprovidercodeinfo);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(489, 20);
            this.txtName.TabIndex = 209;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 214;
            this.label7.Text = "Code :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 212;
            this.label4.Text = "Network Provider:";
            // 
            // cmbNetworkProvider
            // 
            this.cmbNetworkProvider.DisplayMember = "name";
            this.cmbNetworkProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNetworkProvider.FormattingEnabled = true;
            this.cmbNetworkProvider.Location = new System.Drawing.Point(127, 12);
            this.cmbNetworkProvider.Name = "cmbNetworkProvider";
            this.cmbNetworkProvider.Size = new System.Drawing.Size(489, 21);
            this.cmbNetworkProvider.TabIndex = 213;
            this.cmbNetworkProvider.ValueMember = "id";
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
            // networkprovider
            // 
            this.networkprovider.DataPropertyName = "networkprovider";
            this.networkprovider.HeaderText = "Network Provider";
            this.networkprovider.Name = "networkprovider";
            this.networkprovider.ReadOnly = true;
            // 
            // FormNetworkProviderCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 372);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbNetworkProvider);
            this.Controls.Add(this.Label22);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.grdNetworkProviderCode);
            this.Name = "FormNetworkProviderCode";
            this.TabText = "NetworkProviderCode";
            this.Tag = "";
            this.Text = "NetworkProviderCode";
            this.Load += new System.EventHandler(this.FormNetworkProviderCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNetworkProviderCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNetworkProviderCodeinfoBindingSource)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNetworkProvider;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label label27;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView grdNetworkProviderCode;
        private System.Windows.Forms.BindingSource vNetworkProviderCodeinfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetworkProviderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetworkProvideridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn networkprovider;
    }
}