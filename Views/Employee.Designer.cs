namespace Views
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridEmployee = new DevExpress.XtraGrid.GridControl();
            this.gridEmployeeView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EmpIDCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.EmpPhone = new DevExpress.XtraEditors.TextEdit();
            this.EmpAdd = new DevExpress.XtraEditors.TextEdit();
            this.EmpBirth = new DevExpress.XtraEditors.DateEdit();
            this.EmpGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.EmpID = new DevExpress.XtraEditors.TextEdit();
            this.Update = new DevExpress.XtraEditors.SimpleButton();
            this.Delete = new DevExpress.XtraEditors.SimpleButton();
            this.EmpName = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Root1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Phone = new DevExpress.XtraLayout.LayoutControlItem();
            this.Address = new DevExpress.XtraLayout.LayoutControlItem();
            this.Birthday = new DevExpress.XtraLayout.LayoutControlItem();
            this.ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Name = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.Gender = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployeeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpAdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpBirth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpBirth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Birthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.gridEmployee, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.layoutControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.controlNavigator1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 510);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridEmployee
            // 
            this.gridEmployee.DataSource = this.employeeBindingSource;
            this.gridEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEmployee.Location = new System.Drawing.Point(0, 0);
            this.gridEmployee.MainView = this.gridEmployeeView;
            this.gridEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.gridEmployee.Name = "gridEmployee";
            this.gridEmployee.Size = new System.Drawing.Size(434, 480);
            this.gridEmployee.TabIndex = 0;
            this.gridEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridEmployeeView});
            // 
            // gridEmployeeView
            // 
            this.gridEmployeeView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EmpIDCol,
            this.EmpNameCol});
            this.gridEmployeeView.GridControl = this.gridEmployee;
            this.gridEmployeeView.Name = "gridEmployeeView";
            // 
            // EmpIDCol
            // 
            this.EmpIDCol.FieldName = "ID";
            this.EmpIDCol.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("EmpIDCol.ImageOptions.Image")));
            this.EmpIDCol.Name = "EmpIDCol";
            this.EmpIDCol.Visible = true;
            this.EmpIDCol.VisibleIndex = 0;
            this.EmpIDCol.Width = 104;
            // 
            // EmpNameCol
            // 
            this.EmpNameCol.FieldName = "Name";
            this.EmpNameCol.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("EmpNameCol.ImageOptions.Image")));
            this.EmpNameCol.Name = "EmpNameCol";
            this.EmpNameCol.Visible = true;
            this.EmpNameCol.VisibleIndex = 1;
            this.EmpNameCol.Width = 311;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.EmpPhone);
            this.layoutControl1.Controls.Add(this.EmpAdd);
            this.layoutControl1.Controls.Add(this.EmpBirth);
            this.layoutControl1.Controls.Add(this.EmpGender);
            this.layoutControl1.Controls.Add(this.EmpID);
            this.layoutControl1.Controls.Add(this.Update);
            this.layoutControl1.Controls.Add(this.Delete);
            this.layoutControl1.Controls.Add(this.EmpName);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(434, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(19, 85, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.tableLayoutPanel1.SetRowSpan(this.layoutControl1, 2);
            this.layoutControl1.Size = new System.Drawing.Size(290, 510);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // EmpPhone
            // 
            this.EmpPhone.Location = new System.Drawing.Point(2, 410);
            this.EmpPhone.Name = "EmpPhone";
            this.EmpPhone.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.EmpPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.EmpPhone.Size = new System.Drawing.Size(286, 20);
            this.EmpPhone.StyleController = this.layoutControl1;
            this.EmpPhone.TabIndex = 7;
            // 
            // EmpAdd
            // 
            this.EmpAdd.Location = new System.Drawing.Point(2, 319);
            this.EmpAdd.Name = "EmpAdd";
            this.EmpAdd.Properties.Mask.EditMask = "\\p{L}+";
            this.EmpAdd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.EmpAdd.Size = new System.Drawing.Size(286, 20);
            this.EmpAdd.StyleController = this.layoutControl1;
            this.EmpAdd.TabIndex = 6;
            // 
            // EmpBirth
            // 
            this.EmpBirth.EditValue = null;
            this.EmpBirth.Location = new System.Drawing.Point(2, 223);
            this.EmpBirth.Name = "EmpBirth";
            this.EmpBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmpBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmpBirth.Properties.DisplayFormat.FormatString = "";
            this.EmpBirth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.EmpBirth.Properties.EditFormat.FormatString = "";
            this.EmpBirth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.EmpBirth.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.EmpBirth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.EmpBirth.Size = new System.Drawing.Size(286, 20);
            this.EmpBirth.StyleController = this.layoutControl1;
            this.EmpBirth.TabIndex = 5;
            // 
            // EmpGender
            // 
            this.EmpGender.Location = new System.Drawing.Point(185, 127);
            this.EmpGender.Name = "EmpGender";
            this.EmpGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmpGender.Properties.DropDownRows = 2;
            this.EmpGender.Properties.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.EmpGender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.EmpGender.Size = new System.Drawing.Size(103, 20);
            this.EmpGender.StyleController = this.layoutControl1;
            this.EmpGender.TabIndex = 4;
            // 
            // EmpID
            // 
            this.EmpID.Enabled = false;
            this.EmpID.Location = new System.Drawing.Point(0, 35);
            this.EmpID.Name = "EmpID";
            this.EmpID.Properties.ReadOnly = true;
            this.EmpID.Size = new System.Drawing.Size(119, 20);
            this.EmpID.StyleController = this.layoutControl1;
            this.EmpID.TabIndex = 11;
            // 
            // Update
            // 
            this.Update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Update.ImageOptions.Image")));
            this.Update.Location = new System.Drawing.Point(99, 470);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(93, 38);
            this.Update.StyleController = this.layoutControl1;
            this.Update.TabIndex = 14;
            this.Update.Text = "Update";
            // 
            // Delete
            // 
            this.Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Delete.ImageOptions.Image")));
            this.Delete.Location = new System.Drawing.Point(196, 470);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(92, 38);
            this.Delete.StyleController = this.layoutControl1;
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Delete";
            // 
            // EmpName
            // 
            this.EmpName.Location = new System.Drawing.Point(2, 127);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(179, 20);
            this.EmpName.StyleController = this.layoutControl1;
            this.EmpName.TabIndex = 10;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(2, 470);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 38);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "New";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Root1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(290, 510);
            this.Root.TextVisible = false;
            // 
            // Root1
            // 
            this.Root1.CustomizationFormText = "Root";
            this.Root1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root1.GroupBordersVisible = false;
            this.Root1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Phone,
            this.Address,
            this.Birthday,
            this.ID,
            this.layoutControlItem3,
            this.Name,
            this.emptySpaceItem1,
            this.Gender,
            this.layoutControlItem4,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.emptySpaceItem6,
            this.layoutControlItem1});
            this.Root1.Location = new System.Drawing.Point(0, 0);
            this.Root1.Name = "Root1";
            this.Root1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root1.Size = new System.Drawing.Size(290, 510);
            this.Root1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root1.Text = "Root";
            this.Root1.TextVisible = false;
            // 
            // Phone
            // 
            this.Phone.Control = this.EmpPhone;
            this.Phone.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Phone.CustomizationFormText = "Phone";
            this.Phone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Phone.ImageOptions.Image")));
            this.Phone.Location = new System.Drawing.Point(0, 373);
            this.Phone.Name = "Phone";
            this.Phone.OptionsTableLayoutItem.RowIndex = 4;
            this.Phone.Size = new System.Drawing.Size(290, 59);
            this.Phone.TextLocation = DevExpress.Utils.Locations.Top;
            this.Phone.TextSize = new System.Drawing.Size(97, 32);
            // 
            // Address
            // 
            this.Address.Control = this.EmpAdd;
            this.Address.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Address.CustomizationFormText = "Address";
            this.Address.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Address.ImageOptions.Image")));
            this.Address.Location = new System.Drawing.Point(0, 282);
            this.Address.Name = "Address";
            this.Address.OptionsTableLayoutItem.RowIndex = 3;
            this.Address.Size = new System.Drawing.Size(290, 59);
            this.Address.TextLocation = DevExpress.Utils.Locations.Top;
            this.Address.TextSize = new System.Drawing.Size(97, 32);
            // 
            // Birthday
            // 
            this.Birthday.Control = this.EmpBirth;
            this.Birthday.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Birthday.CustomizationFormText = "Birthday";
            this.Birthday.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Birthday.ImageOptions.Image")));
            this.Birthday.Location = new System.Drawing.Point(0, 186);
            this.Birthday.Name = "Birthday";
            this.Birthday.OptionsTableLayoutItem.RowIndex = 2;
            this.Birthday.Size = new System.Drawing.Size(290, 59);
            this.Birthday.TextLocation = DevExpress.Utils.Locations.Top;
            this.Birthday.TextSize = new System.Drawing.Size(97, 32);
            // 
            // ID
            // 
            this.ID.Control = this.EmpID;
            this.ID.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ID.CustomizationFormText = "Customer ID";
            this.ID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ID.ImageOptions.Image")));
            this.ID.Location = new System.Drawing.Point(0, 0);
            this.ID.Name = "ID";
            this.ID.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ID.Size = new System.Drawing.Size(119, 55);
            this.ID.Text = "Employee ID";
            this.ID.TextLocation = DevExpress.Utils.Locations.Top;
            this.ID.TextSize = new System.Drawing.Size(97, 32);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.Update;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "Update";
            this.layoutControlItem3.Location = new System.Drawing.Point(97, 468);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(97, 42);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // Name
            // 
            this.Name.Control = this.EmpName;
            this.Name.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Name.CustomizationFormText = "Name";
            this.Name.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Name.ImageOptions.Image")));
            this.Name.Location = new System.Drawing.Point(0, 90);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(183, 59);
            this.Name.TextLocation = DevExpress.Utils.Locations.Top;
            this.Name.TextSize = new System.Drawing.Size(97, 32);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(119, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.emptySpaceItem1.Size = new System.Drawing.Size(171, 55);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Gender
            // 
            this.Gender.Control = this.EmpGender;
            this.Gender.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Gender.CustomizationFormText = "Gender";
            this.Gender.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Gender.ImageOptions.Image")));
            this.Gender.Location = new System.Drawing.Point(183, 90);
            this.Gender.Name = "Gender";
            this.Gender.OptionsTableLayoutItem.RowIndex = 1;
            this.Gender.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Gender.Size = new System.Drawing.Size(107, 59);
            this.Gender.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Gender.TextLocation = DevExpress.Utils.Locations.Top;
            this.Gender.TextSize = new System.Drawing.Size(97, 32);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Delete;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "Delete";
            this.layoutControlItem4.Location = new System.Drawing.Point(194, 468);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(96, 42);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 55);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.emptySpaceItem2.Size = new System.Drawing.Size(290, 35);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 149);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.emptySpaceItem3.Size = new System.Drawing.Size(290, 37);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 245);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(290, 37);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 432);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(290, 36);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 341);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(290, 32);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.CustomizationFormText = "New";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 468);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(97, 42);
            this.layoutControlItem1.Text = "New";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Buttons.Append.Visible = false;
            this.controlNavigator1.Buttons.CancelEdit.Visible = false;
            this.controlNavigator1.Buttons.Edit.Visible = false;
            this.controlNavigator1.Buttons.EndEdit.Visible = false;
            this.controlNavigator1.Buttons.NextPage.Visible = false;
            this.controlNavigator1.Buttons.PrevPage.Visible = false;
            this.controlNavigator1.Buttons.Remove.Visible = false;
            this.controlNavigator1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.controlNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlNavigator1.Location = new System.Drawing.Point(0, 480);
            this.controlNavigator1.Margin = new System.Windows.Forms.Padding(0);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.NavigatableControl = this.gridEmployee;
            this.controlNavigator1.Size = new System.Drawing.Size(434, 30);
            this.controlNavigator1.TabIndex = 2;
            this.controlNavigator1.Text = "controlNavigator1";
            // 
            // employeeBindingSource
            // 
           
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 510);
            this.Controls.Add(this.tableLayoutPanel1);
           
            this.Text = "Employee";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployeeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmpPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpAdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpBirth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpBirth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Birthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridEmployeeView;
        private DevExpress.XtraGrid.Columns.GridColumn EmpIDCol;
        private DevExpress.XtraGrid.Columns.GridColumn EmpNameCol;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit EmpPhone;
        private DevExpress.XtraEditors.TextEdit EmpAdd;
        private DevExpress.XtraEditors.DateEdit EmpBirth;
        private DevExpress.XtraEditors.ComboBoxEdit EmpGender;
        private DevExpress.XtraEditors.TextEdit EmpID;
        private DevExpress.XtraEditors.SimpleButton Update;
        private DevExpress.XtraEditors.SimpleButton Delete;
        private DevExpress.XtraEditors.TextEdit EmpName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup Root1;
        private DevExpress.XtraLayout.LayoutControlItem Phone;
        private DevExpress.XtraLayout.LayoutControlItem Address;
        private DevExpress.XtraLayout.LayoutControlItem Birthday;
        private DevExpress.XtraLayout.LayoutControlItem Gender;
        private DevExpress.XtraLayout.LayoutControlItem ID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem Name;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
    }
}