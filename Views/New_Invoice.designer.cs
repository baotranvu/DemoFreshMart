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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Invoice));
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuantityCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiscountCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AmountCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridProductInfo = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SKUCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductCol2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitPriceCol2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.SKU = new DevExpress.XtraEditors.TextEdit();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xtraTabNewInvoice = new DevExpress.XtraTab.XtraTabControl();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SKU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabNewInvoice)).BeginInit();
            this.xtraTabNewInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
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
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 29);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(819, 537);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView4,
            this.gridView3});
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
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridProductInfo);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(819, 588);
            this.xtraTabPage2.Text = "Product Info";
            // 
            // gridProductInfo
            // 
            this.gridProductInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProductInfo.Location = new System.Drawing.Point(0, 0);
            this.gridProductInfo.MainView = this.gridView2;
            this.gridProductInfo.Name = "gridProductInfo";
            this.gridProductInfo.Size = new System.Drawing.Size(819, 588);
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
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.tableLayoutPanel1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(819, 597);
            this.xtraTabPage1.Text = "New Invoice";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.layoutControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.layoutControl2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(819, 597);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 566);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 67, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(819, 31);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleLabelItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(802, 36);
            this.Root.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.SKU);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControl2.Location = new System.Drawing.Point(3, 3);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(273, 0, 650, 400);
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(180, 23);
            this.layoutControl2.TabIndex = 2;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // SKU
            // 
            this.SKU.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productsBindingSource, "SKU", true));
            this.SKU.Location = new System.Drawing.Point(28, 2);
            this.SKU.Name = "SKU";
            this.SKU.Properties.Mask.EditMask = "PD.\\d{2}";
            this.SKU.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.SKU.Size = new System.Drawing.Size(133, 20);
            this.SKU.StyleController = this.layoutControl2;
            this.SKU.TabIndex = 4;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(Models.Products);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(163, 24);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.SKU;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(163, 24);
            this.layoutControlItem2.Text = "SKU:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(23, 13);
            // 
            // xtraTabNewInvoice
            // 
            this.xtraTabNewInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabNewInvoice.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabNewInvoice.Location = new System.Drawing.Point(0, 0);
            this.xtraTabNewInvoice.Name = "xtraTabNewInvoice";
            this.xtraTabNewInvoice.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabNewInvoice.Size = new System.Drawing.Size(863, 602);
            this.xtraTabNewInvoice.TabIndex = 0;
            this.xtraTabNewInvoice.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleLabelItem1.ImageOptions.Image")));
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(802, 36);
            this.simpleLabelItem1.Text = "Total:";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(65, 32);
            // 
            // New_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 602);
            this.Controls.Add(this.xtraTabNewInvoice);
            this.Name = "New_Invoice";
            this.Text = "New_Invoice form";
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SKU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabNewInvoice)).EndInit();
            this.xtraTabNewInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridProductInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn SKUCol;
        private DevExpress.XtraGrid.Columns.GridColumn ProductCol2;
        private DevExpress.XtraGrid.Columns.GridColumn UnitPriceCol2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraTab.XtraTabControl xtraTabNewInvoice;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ProductCol;
        private DevExpress.XtraGrid.Columns.GridColumn QuantityCol;
        private DevExpress.XtraGrid.Columns.GridColumn UnitPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn DiscountCol;
        private DevExpress.XtraGrid.Columns.GridColumn AmountCol;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.TextEdit SKU;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
    }
}