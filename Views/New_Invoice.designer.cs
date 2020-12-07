namespace Views
{
    partial class New_Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Invoice));
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabNewInvoice = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuantityCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiscountCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AmountCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Total = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridProductInfo = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SKUCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductCol2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitPriceCol2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabNewInvoice)).BeginInit();
            this.xtraTabNewInvoice.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Customer Info";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // xtraTabNewInvoice
            // 
            this.xtraTabNewInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabNewInvoice.Location = new System.Drawing.Point(0, 0);
            this.xtraTabNewInvoice.Name = "xtraTabNewInvoice";
            this.xtraTabNewInvoice.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabNewInvoice.Size = new System.Drawing.Size(863, 569);
            this.xtraTabNewInvoice.TabIndex = 0;
            this.xtraTabNewInvoice.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.tableLayoutPanel1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(858, 525);
            this.xtraTabPage1.Text = "New Invoice";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.layoutControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(858, 525);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(858, 488);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductCol,
            this.QuantityCol,
            this.UnitPriceCol,
            this.DiscountCol,
            this.AmountCol});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ProductCol
            // 
            this.ProductCol.FieldName = "Product";
            this.ProductCol.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ProductCol.ImageOptions.Image")));
            this.ProductCol.Name = "ProductCol";
            this.ProductCol.Visible = true;
            this.ProductCol.VisibleIndex = 0;
            // 
            // QuantityCol
            // 
            this.QuantityCol.FieldName = "Quantity";
            this.QuantityCol.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("QuantityCol.ImageOptions.Image")));
            this.QuantityCol.Name = "QuantityCol";
            this.QuantityCol.Visible = true;
            this.QuantityCol.VisibleIndex = 1;
            // 
            // UnitPriceCol
            // 
            this.UnitPriceCol.FieldName = "Unit Price";
            this.UnitPriceCol.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("UnitPriceCol.ImageOptions.Image")));
            this.UnitPriceCol.Name = "UnitPriceCol";
            this.UnitPriceCol.Visible = true;
            this.UnitPriceCol.VisibleIndex = 2;
            // 
            // DiscountCol
            // 
            this.DiscountCol.FieldName = "Discount";
            this.DiscountCol.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DiscountCol.ImageOptions.Image")));
            this.DiscountCol.Name = "DiscountCol";
            this.DiscountCol.Visible = true;
            this.DiscountCol.VisibleIndex = 3;
            // 
            // AmountCol
            // 
            this.AmountCol.FieldName = "Amount";
            this.AmountCol.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AmountCol.ImageOptions.Image")));
            this.AmountCol.Name = "AmountCol";
            this.AmountCol.Visible = true;
            this.AmountCol.VisibleIndex = 4;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.Total);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 488);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 67, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(858, 37);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(70, 0);
            this.Total.Margin = new System.Windows.Forms.Padding(0);
            this.Total.Name = "Total";
            this.Total.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Properties.Appearance.Options.UseFont = true;
            this.Total.Size = new System.Drawing.Size(788, 26);
            this.Total.StyleController = this.layoutControl1;
            this.Total.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(858, 37);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Total;
            this.layoutControlItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem1.ImageOptions.Image")));
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(858, 37);
            this.layoutControlItem1.Text = "Total:";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(65, 32);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridProductInfo);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(858, 525);
            this.xtraTabPage2.Text = "Product Info";
            // 
            // gridProductInfo
            // 
            this.gridProductInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProductInfo.Location = new System.Drawing.Point(0, 0);
            this.gridProductInfo.MainView = this.gridView2;
            this.gridProductInfo.Name = "gridProductInfo";
            this.gridProductInfo.Size = new System.Drawing.Size(858, 525);
            this.gridProductInfo.TabIndex = 0;
            this.gridProductInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SKUCol,
            this.ProductCol2,
            this.UnitPriceCol2});
            this.gridView2.GridControl = this.gridProductInfo;
            this.gridView2.Name = "gridView2";
            // 
            // SKUCol
            // 
            this.SKUCol.FieldName = "SKU";
            this.SKUCol.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SKUCol.ImageOptions.Image")));
            this.SKUCol.Name = "SKUCol";
            this.SKUCol.Visible = true;
            this.SKUCol.VisibleIndex = 0;
            // 
            // ProductCol2
            // 
            this.ProductCol2.FieldName = "Product";
            this.ProductCol2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ProductCol2.ImageOptions.Image")));
            this.ProductCol2.Name = "ProductCol2";
            this.ProductCol2.Visible = true;
            this.ProductCol2.VisibleIndex = 1;
            // 
            // UnitPriceCol2
            // 
            this.UnitPriceCol2.FieldName = "Unit Price";
            this.UnitPriceCol2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("UnitPriceCol2.ImageOptions.Image")));
            this.UnitPriceCol2.Name = "UnitPriceCol2";
            this.UnitPriceCol2.Visible = true;
            this.UnitPriceCol2.VisibleIndex = 2;
            // 
            // New_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 569);
            this.Controls.Add(this.xtraTabNewInvoice);
            this.Name = "New_Invoice";
            this.Text = "New_Invoice form";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabNewInvoice)).EndInit();
            this.xtraTabNewInvoice.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Total.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraTab.XtraTabControl xtraTabNewInvoice;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit Total;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridProductInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn SKUCol;
        private DevExpress.XtraGrid.Columns.GridColumn ProductCol2;
        private DevExpress.XtraGrid.Columns.GridColumn UnitPriceCol2;
        private DevExpress.XtraGrid.Columns.GridColumn ProductCol;
        private DevExpress.XtraGrid.Columns.GridColumn QuantityCol;
        private DevExpress.XtraGrid.Columns.GridColumn UnitPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn DiscountCol;
        private DevExpress.XtraGrid.Columns.GridColumn AmountCol;
    }
}