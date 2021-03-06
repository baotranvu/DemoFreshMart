namespace Views
{
    partial class New_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Product));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Name = new DevExpress.XtraEditors.TextEdit();
            this.Unit = new DevExpress.XtraEditors.TextEdit();
            this.Type = new DevExpress.XtraEditors.TextEdit();
            this.UnitPrice = new DevExpress.XtraEditors.TextEdit();
            this.MFG = new DevExpress.XtraEditors.DateEdit();
            this.EXP = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Save_btn = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Clear_btn = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MFG.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MFG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXP.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Clear_btn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.layoutControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Save_btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 362);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.layoutControl1, 2);
            this.layoutControl1.Controls.Add(this.Name);
            this.layoutControl1.Controls.Add(this.Unit);
            this.layoutControl1.Controls.Add(this.Type);
            this.layoutControl1.Controls.Add(this.UnitPrice);
            this.layoutControl1.Controls.Add(this.MFG);
            this.layoutControl1.Controls.Add(this.EXP);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(497, 26, 650, 770);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(648, 108);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(97, 12);
            this.Name.Name = "Name";
            this.Name.Properties.Mask.EditMask = "\\p{L}+";
            this.Name.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.Name.Size = new System.Drawing.Size(126, 20);
            this.Name.StyleController = this.layoutControl1;
            this.Name.TabIndex = 4;
            // 
            // Unit
            // 
            this.Unit.Location = new System.Drawing.Point(312, 12);
            this.Unit.Name = "Unit";
            this.Unit.Properties.Mask.EditMask = "[a-zA-Z]+";
            this.Unit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.Unit.Size = new System.Drawing.Size(121, 20);
            this.Unit.StyleController = this.layoutControl1;
            this.Unit.TabIndex = 5;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(97, 48);
            this.Type.Name = "Type";
            this.Type.Properties.Mask.EditMask = "[a-zA-Z]+";
            this.Type.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.Type.Size = new System.Drawing.Size(126, 20);
            this.Type.StyleController = this.layoutControl1;
            this.Type.TabIndex = 7;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Location = new System.Drawing.Point(312, 48);
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Properties.Mask.EditMask = "n2";
            this.UnitPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.UnitPrice.Size = new System.Drawing.Size(121, 20);
            this.UnitPrice.StyleController = this.layoutControl1;
            this.UnitPrice.TabIndex = 8;
            // 
            // MFG
            // 
            this.MFG.EditValue = null;
            this.MFG.Location = new System.Drawing.Point(522, 12);
            this.MFG.Name = "MFG";
            this.MFG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MFG.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MFG.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.MFG.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.MFG.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.MFG.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.MFG.Properties.Mask.EditMask = "MM-dd-yyyy";
            this.MFG.Size = new System.Drawing.Size(114, 20);
            this.MFG.StyleController = this.layoutControl1;
            this.MFG.TabIndex = 6;
            // 
            // EXP
            // 
            this.EXP.EditValue = null;
            this.EXP.Location = new System.Drawing.Point(522, 48);
            this.EXP.Name = "EXP";
            this.EXP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EXP.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EXP.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.EXP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.EXP.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.EXP.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.EXP.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.EXP.Size = new System.Drawing.Size(114, 20);
            this.EXP.StyleController = this.layoutControl1;
            this.EXP.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(648, 108);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Name;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem1.ImageOptions.Image")));
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(215, 36);
            this.layoutControlItem1.Text = "Product";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(82, 32);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Unit;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem2.ImageOptions.Image")));
            this.layoutControlItem2.Location = new System.Drawing.Point(215, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(210, 36);
            this.layoutControlItem2.Text = "Unit";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(82, 32);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.MFG;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem3.ImageOptions.Image")));
            this.layoutControlItem3.Location = new System.Drawing.Point(425, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(203, 36);
            this.layoutControlItem3.Text = "MFG";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(82, 32);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Type;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem4.ImageOptions.Image")));
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(215, 52);
            this.layoutControlItem4.Text = "Type";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(82, 32);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.UnitPrice;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem5.ImageOptions.Image")));
            this.layoutControlItem5.Location = new System.Drawing.Point(215, 36);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(210, 52);
            this.layoutControlItem5.Text = "Unit Price";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(82, 32);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.EXP;
            this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem6.ImageOptions.Image")));
            this.layoutControlItem6.Location = new System.Drawing.Point(425, 36);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(203, 52);
            this.layoutControlItem6.Text = "EXP";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(82, 32);
            // 
            // Save_btn
            // 
            this.Save_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.Save_btn.Location = new System.Drawing.Point(0, 336);
            this.Save_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(324, 26);
            this.Save_btn.TabIndex = 1;
            this.Save_btn.Text = "Save";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 108);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(648, 228);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Clear_btn
            // 
            this.Clear_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clear_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.Clear_btn.Location = new System.Drawing.Point(324, 336);
            this.Clear_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(324, 26);
            this.Clear_btn.TabIndex = 3;
            this.Clear_btn.Text = "Clear";
            // 
            // New_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 362);
            this.Controls.Add(this.tableLayoutPanel1);
         
            this.Text = "New_Product";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MFG.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MFG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXP.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit Name;
        private DevExpress.XtraEditors.TextEdit Unit;
        private DevExpress.XtraEditors.TextEdit Type;
        private DevExpress.XtraEditors.TextEdit UnitPrice;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton Save_btn;
        private DevExpress.XtraEditors.DateEdit MFG;
        private DevExpress.XtraEditors.DateEdit EXP;
        private DevExpress.XtraEditors.SimpleButton Clear_btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}