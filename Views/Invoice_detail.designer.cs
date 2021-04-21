namespace Views
{
    partial class Invoice_detail
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.emp_lb = new System.Windows.Forms.Label();
            this.invoice_detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.date_lb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inv_lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.change_lb = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.total_lb = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.item_lb = new System.Windows.Forms.Label();
            this.cash_lb = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.QuantityCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AmountCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_detailBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.emp_lb, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.date_lb, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.inv_lb, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(341, 190);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // emp_lb
            // 
            this.emp_lb.AutoSize = true;
            this.emp_lb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoice_detailBindingSource, "Invoices.Employees.Name", true));
            this.emp_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emp_lb.Location = new System.Drawing.Point(173, 126);
            this.emp_lb.Name = "emp_lb";
            this.emp_lb.Size = new System.Drawing.Size(165, 13);
            this.emp_lb.TabIndex = 8;
            this.emp_lb.Text = "label9";
            this.emp_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoice_detailBindingSource
            // 
            this.invoice_detailBindingSource.DataSource = typeof(Models.Invoice_detail);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Employee:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date_lb
            // 
            this.date_lb.AutoSize = true;
            this.date_lb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoice_detailBindingSource, "Invoices.Date", true));
            this.date_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_lb.Location = new System.Drawing.Point(173, 113);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(165, 13);
            this.date_lb.TabIndex = 6;
            this.date_lb.Text = "label7";
            this.date_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Receipt No:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "FRESH MART";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "8657 Meadow Street Belmont, MA 02478";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inv_lb
            // 
            this.inv_lb.AutoSize = true;
            this.inv_lb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoice_detailBindingSource, "InvID", true));
            this.inv_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inv_lb.Location = new System.Drawing.Point(173, 100);
            this.inv_lb.Name = "inv_lb";
            this.inv_lb.Size = new System.Drawing.Size(165, 13);
            this.inv_lb.TabIndex = 12;
            this.inv_lb.Text = "label3";
            this.inv_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 51);
            this.label3.TabIndex = 13;
            this.label3.Text = "Description:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.change_lb, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label18, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.total_lb, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label13, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.item_lb, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cash_lb, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 453);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(343, 66);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // change_lb
            // 
            this.change_lb.AutoSize = true;
            this.change_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.change_lb.Location = new System.Drawing.Point(242, 45);
            this.change_lb.Name = "change_lb";
            this.change_lb.Size = new System.Drawing.Size(98, 21);
            this.change_lb.TabIndex = 8;
            this.change_lb.Text = "Change";
            this.change_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label18, 2);
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(3, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(233, 21);
            this.label18.TabIndex = 6;
            this.label18.Text = "CHANGE:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label15, 2);
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(233, 19);
            this.label15.TabIndex = 3;
            this.label15.Text = "CASH:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // total_lb
            // 
            this.total_lb.AutoSize = true;
            this.total_lb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoice_detailBindingSource, "Invoices.Total", true));
            this.total_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.total_lb.Location = new System.Drawing.Point(242, 0);
            this.total_lb.Name = "total_lb";
            this.total_lb.Size = new System.Drawing.Size(98, 26);
            this.total_lb.TabIndex = 2;
            this.total_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(105, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 26);
            this.label13.TabIndex = 1;
            this.label13.Text = "(VAT Included)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item_lb
            // 
            this.item_lb.AutoSize = true;
            this.item_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item_lb.Location = new System.Drawing.Point(3, 0);
            this.item_lb.Name = "item_lb";
            this.item_lb.Size = new System.Drawing.Size(96, 26);
            this.item_lb.TabIndex = 0;
            this.item_lb.Text = "Item(s):";
            this.item_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cash_lb
            // 
            this.cash_lb.AutoSize = true;
            this.cash_lb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoice_detailBindingSource, "Invoices.Cash", true));
            this.cash_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cash_lb.Location = new System.Drawing.Point(242, 26);
            this.cash_lb.Name = "cash_lb";
            this.cash_lb.Size = new System.Drawing.Size(98, 19);
            this.cash_lb.TabIndex = 9;
            this.cash_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.invoice_detailBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 192);
            this.gridControl1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.gridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(343, 261);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.QuantityCol,
            this.ProductCol,
            this.AmountCol});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // QuantityCol
            // 
            this.QuantityCol.FieldName = "Quantity";
            this.QuantityCol.Name = "QuantityCol";
            this.QuantityCol.Visible = true;
            this.QuantityCol.VisibleIndex = 0;
            // 
            // ProductCol
            // 
            this.ProductCol.FieldName = "Products.Product";
            this.ProductCol.Name = "ProductCol";
            this.ProductCol.Visible = true;
            this.ProductCol.VisibleIndex = 1;
            // 
            // AmountCol
            // 
            this.AmountCol.FieldName = "Amount";
            this.AmountCol.Name = "AmountCol";
            this.AmountCol.Visible = true;
            this.AmountCol.VisibleIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Products";
            this.dataGridViewTextBoxColumn1.HeaderText = "Products";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 298;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Products";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 149;
            // 
            // Invoice_detail
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(343, 519);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Invoice_detail";
            this.Text = "Receipt";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_detailBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label emp_lb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label date_lb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label change_lb;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label total_lb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label item_lb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label inv_lb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn QuantityCol;
        private DevExpress.XtraGrid.Columns.GridColumn ProductCol;
        private DevExpress.XtraGrid.Columns.GridColumn AmountCol;
        private System.Windows.Forms.BindingSource invoice_detailBindingSource;
        private System.Windows.Forms.Label cash_lb;
    }
}