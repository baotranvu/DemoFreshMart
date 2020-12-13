namespace Views
{
    partial class Function
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Function));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.gridFunction = new DevExpress.XtraGrid.GridControl();
            this.functionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridFunctionView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFunctionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFunctionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFunctionView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Delete, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridFunction, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Add, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Save, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(640, 418);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(80, 32);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // gridFunction
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gridFunction, 4);
            this.gridFunction.DataSource = this.functionsBindingSource;
            this.gridFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFunction.Location = new System.Drawing.Point(0, 0);
            this.gridFunction.MainView = this.gridFunctionView;
            this.gridFunction.Margin = new System.Windows.Forms.Padding(0);
            this.gridFunction.Name = "gridFunction";
            this.gridFunction.Size = new System.Drawing.Size(800, 418);
            this.gridFunction.TabIndex = 0;
            this.gridFunction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridFunctionView});
            // 
            // functionsBindingSource
            // 
            this.functionsBindingSource.DataSource = typeof(Models.Functions);
            // 
            // gridFunctionView
            // 
            this.gridFunctionView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFunctionId,
            this.colFunctionName,
            this.colFormName});
            this.gridFunctionView.GridControl = this.gridFunction;
            this.gridFunctionView.Name = "gridFunctionView";
            // 
            // colFunctionId
            // 
            this.colFunctionId.FieldName = "FunctionId";
            this.colFunctionId.Name = "colFunctionId";
            this.colFunctionId.Visible = true;
            this.colFunctionId.VisibleIndex = 0;
            // 
            // colFunctionName
            // 
            this.colFunctionName.FieldName = "FunctionName";
            this.colFunctionName.Name = "colFunctionName";
            this.colFunctionName.Visible = true;
            this.colFunctionName.VisibleIndex = 2;
            this.colFunctionName.Width = 91;
            // 
            // colFormName
            // 
            this.colFormName.FieldName = "FormName";
            this.colFormName.Name = "colFormName";
            this.colFormName.Visible = true;
            this.colFormName.VisibleIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.Location = new System.Drawing.Point(560, 418);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(80, 32);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(720, 418);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(80, 32);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Function";
            this.Text = "Function";
            this.Load += new System.EventHandler(this.Function_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFunctionView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridFunction;
        private DevExpress.XtraGrid.Views.Grid.GridView gridFunctionView;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private System.Windows.Forms.BindingSource functionsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFunctionId;
        private DevExpress.XtraGrid.Columns.GridColumn colFormName;
        private DevExpress.XtraGrid.Columns.GridColumn colFunctionName;
    }
}