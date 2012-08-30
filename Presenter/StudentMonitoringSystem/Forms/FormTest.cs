using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentMonitoringSystem.Entities;
using System.Data.Objects;
using Telerik.WinControls.UI;

namespace StudentMonitoringSystem.Forms
{
    public partial class FormTest : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private const string THEME = "ControlDefault";

        public FormTest()
        {
            InitializeComponent();

            RadMultiColumnComboBoxElement multiColumnComboElement = this.radMultiColumnComboBox1.MultiColumnComboBoxElement;
            multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
            //multiColumnComboElement.DropDownMinSize = new Size(300, 300);

            multiColumnComboElement.EditorControl.MasterTemplate.AutoGenerateColumns = false;

            //GridViewTextBoxColumn column = new GridViewTextBoxColumn("id");
            //column.HeaderText = "Customer ID";
            //multiColumnComboElement.Columns.Add(column);

            //column = new GridViewTextBoxColumn("Name");
            //column.HeaderText = "Contact Name";
            //multiColumnComboElement.Columns.Add(column);
    
        }

        private void Test_Load(object sender, EventArgs e)
        {
            var c = new StudentMonitoringSystem.Presenter.Controller();
            var list = c.GetObject<core_city>().ToList();

            this.corecityBindingSource.DataSource = list;

            //this.radMultiColumnComboBox1.DataSource = list;
            this.radMultiColumnComboBox1.ThemeName = THEME;

        }

        private void CalculateTotalPages()
        {

        }


    }
}
