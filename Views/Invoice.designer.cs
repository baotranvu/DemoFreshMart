namespace App
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.Inv = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.InvID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InvDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Inv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mInvoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Inv
            // 
            this.Inv.DataSource = this.mInvoiceBindingSource;
            this.Inv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inv.Location = new System.Drawing.Point(0, 0);
            this.Inv.MainView = this.gridView1;
            this.Inv.Name = "Inv";
            this.Inv.Size = new System.Drawing.Size(727, 283);
            this.Inv.TabIndex = 0;
            this.Inv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Inv.Click += new System.EventHandler(this.Inv_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.InvID,
            this.InvDate,
            this.EmpID});
            this.gridView1.GridControl = this.Inv;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // InvID
            // 
            this.InvID.FieldName = "InvID";
            this.InvID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("InvID.ImageOptions.Image")));
            this.InvID.Name = "InvID";
            this.InvID.Visible = true;
            this.InvID.VisibleIndex = 0;
            this.InvID.Width = 94;
            // 
            // InvDate
            // 
            this.InvDate.FieldName = "Date";
            this.InvDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("InvDate.ImageOptions.Image")));
            this.InvDate.Name = "InvDate";
            this.InvDate.Visible = true;
            this.InvDate.VisibleIndex = 2;
            // 
            // EmpID
            // 
            this.EmpID.FieldName = "EmpID";
            this.EmpID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("EmpID.ImageOptions.Image")));
            this.EmpID.Name = "EmpID";
            this.EmpID.Visible = true;
            this.EmpID.VisibleIndex = 1;
            // 
            // mInvoiceBindingSource
            // 
           
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 283);
            this.Controls.Add(this.Inv);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Inv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mInvoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Inv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn InvID;
        private DevExpress.XtraGrid.Columns.GridColumn InvDate;
        private DevExpress.XtraGrid.Columns.GridColumn EmpID;
        private System.Windows.Forms.BindingSource mInvoiceBindingSource;
    }
}