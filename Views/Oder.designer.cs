namespace Views
{
    partial class Oder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oder));
            this.ord_grid = new DevExpress.XtraGrid.GridControl();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OrdID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrdDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ord_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // ord_grid
            // 
            this.ord_grid.DataSource = this.ordersBindingSource;
            this.ord_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ord_grid.Location = new System.Drawing.Point(0, 0);
            this.ord_grid.MainView = this.gridOrder;
            this.ord_grid.Name = "ord_grid";
            this.ord_grid.Size = new System.Drawing.Size(687, 403);
            this.ord_grid.TabIndex = 0;
            this.ord_grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridOrder});
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(Models.Orders);
            // 
            // gridOrder
            // 
            this.gridOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.OrdID,
            this.EmpID,
            this.ProID,
            this.OrdDate,
            this.Total});
            this.gridOrder.GridControl = this.ord_grid;
            this.gridOrder.Name = "gridOrder";
            this.gridOrder.OptionsBehavior.Editable = false;
            // 
            // OrdID
            // 
            this.OrdID.FieldName = "OrdID";
            this.OrdID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("OrdID.ImageOptions.Image")));
            this.OrdID.Name = "OrdID";
            this.OrdID.Visible = true;
            this.OrdID.VisibleIndex = 0;
            // 
            // EmpID
            // 
            this.EmpID.FieldName = "EmpID";
            this.EmpID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("EmpID.ImageOptions.Image")));
            this.EmpID.Name = "EmpID";
            this.EmpID.Visible = true;
            this.EmpID.VisibleIndex = 1;
            // 
            // ProID
            // 
            this.ProID.FieldName = "ProID";
            this.ProID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ProID.ImageOptions.Image")));
            this.ProID.Name = "ProID";
            this.ProID.Visible = true;
            this.ProID.VisibleIndex = 2;
            // 
            // OrdDate
            // 
            this.OrdDate.FieldName = "Orddate";
            this.OrdDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("OrdDate.ImageOptions.Image")));
            this.OrdDate.Name = "OrdDate";
            this.OrdDate.Visible = true;
            this.OrdDate.VisibleIndex = 3;
            // 
            // Total
            // 
            this.Total.FieldName = "Total";
            this.Total.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Total.ImageOptions.Image")));
            this.Total.Name = "Total";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 4;
            // 
            // Oder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 403);
            this.Controls.Add(this.ord_grid);
            this.Name = "Oder";
            this.Text = "Oder form";
            ((System.ComponentModel.ISupportInitialize)(this.ord_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ord_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridOrder;
        private DevExpress.XtraGrid.Columns.GridColumn OrdID;
        private DevExpress.XtraGrid.Columns.GridColumn EmpID;
        private DevExpress.XtraGrid.Columns.GridColumn ProID;
        private DevExpress.XtraGrid.Columns.GridColumn OrdDate;
        
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private System.Windows.Forms.BindingSource ordersBindingSource;
    }
}