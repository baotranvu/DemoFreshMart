namespace Views
{
    partial class New_Provider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Provider));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Name_edt = new DevExpress.XtraEditors.TextEdit();
            this.Add_edt = new DevExpress.XtraEditors.TextEdit();
            this.Phone_edt = new DevExpress.XtraEditors.TextEdit();
            this.Mail_edt = new DevExpress.XtraEditors.TextEdit();
            this.Bank_edt = new DevExpress.XtraEditors.TextEdit();
            this.Account_edt = new DevExpress.XtraEditors.TextEdit();
            this.Save_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Clear_btn = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Name_edt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_edt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone_edt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mail_edt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bank_edt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Account_edt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.Name_edt);
            this.layoutControl1.Controls.Add(this.Add_edt);
            this.layoutControl1.Controls.Add(this.Phone_edt);
            this.layoutControl1.Controls.Add(this.Mail_edt);
            this.layoutControl1.Controls.Add(this.Bank_edt);
            this.layoutControl1.Controls.Add(this.Account_edt);
            this.layoutControl1.Controls.Add(this.Save_btn);
            this.layoutControl1.Controls.Add(this.Clear_btn);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(591, 40, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(847, 549);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Name_edt
            // 
            this.Name_edt.Location = new System.Drawing.Point(12, 47);
            this.Name_edt.Name = "Name_edt";
            this.Name_edt.Properties.Mask.EditMask = "[a-zA-Z]+";
            this.Name_edt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.Name_edt.Size = new System.Drawing.Size(400, 20);
            this.Name_edt.StyleController = this.layoutControl1;
            this.Name_edt.TabIndex = 4;
            // 
            // Add_edt
            // 
            this.Add_edt.Location = new System.Drawing.Point(12, 123);
            this.Add_edt.Name = "Add_edt";
            this.Add_edt.Properties.Mask.EditMask = "\\p{L}+";
            this.Add_edt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.Add_edt.Size = new System.Drawing.Size(400, 20);
            this.Add_edt.StyleController = this.layoutControl1;
            this.Add_edt.TabIndex = 5;
            // 
            // Phone_edt
            // 
            this.Phone_edt.Location = new System.Drawing.Point(12, 352);
            this.Phone_edt.Name = "Phone_edt";
            this.Phone_edt.Properties.Mask.EditMask = "(999) 000-0000";
            this.Phone_edt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.Phone_edt.Size = new System.Drawing.Size(400, 20);
            this.Phone_edt.StyleController = this.layoutControl1;
            this.Phone_edt.TabIndex = 6;
            // 
            // Mail_edt
            // 
            this.Mail_edt.Location = new System.Drawing.Point(12, 276);
            this.Mail_edt.Name = "Mail_edt";
            this.Mail_edt.Properties.Mask.EditMask = "([A-Z|a-z|0-9](\\.|_){0,1})+[A-Z|a-z|0-9]\\@([A-Z|a-z|0-9])+((\\.){0,1}[A-Z|a-z|0-9]" +
    "){2}\\.[a-z]{2,3}";
            this.Mail_edt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.Mail_edt.Size = new System.Drawing.Size(400, 20);
            this.Mail_edt.StyleController = this.layoutControl1;
            this.Mail_edt.TabIndex = 7;
            // 
            // Bank_edt
            // 
            this.Bank_edt.Location = new System.Drawing.Point(12, 199);
            this.Bank_edt.Name = "Bank_edt";
            this.Bank_edt.Properties.Mask.EditMask = "[a-zA-Z]+";
            this.Bank_edt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.Bank_edt.Size = new System.Drawing.Size(400, 20);
            this.Bank_edt.StyleController = this.layoutControl1;
            this.Bank_edt.TabIndex = 8;
            // 
            // Account_edt
            // 
            this.Account_edt.Location = new System.Drawing.Point(12, 429);
            this.Account_edt.Name = "Account_edt";
            this.Account_edt.Properties.Mask.BeepOnError = true;
            this.Account_edt.Properties.Mask.EditMask = "\\d+";
            this.Account_edt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.Account_edt.Size = new System.Drawing.Size(400, 20);
            this.Account_edt.StyleController = this.layoutControl1;
            this.Account_edt.TabIndex = 8;
            // 
            // Save_btn
            // 
            this.Save_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Save_btn.ImageOptions.Image")));
            this.Save_btn.Location = new System.Drawing.Point(12, 499);
            this.Save_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(409, 38);
            this.Save_btn.StyleController = this.layoutControl1;
            this.Save_btn.TabIndex = 9;
            this.Save_btn.Text = "Save";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem4,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(847, 549);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Name_edt;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem1.ImageOptions.Image")));
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(404, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(116, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(827, 76);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Provider name :";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(113, 32);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Add_edt;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem2.ImageOptions.Image")));
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(404, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(116, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(827, 76);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Address :";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(113, 32);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.Phone_edt;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem3.ImageOptions.Image")));
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 305);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(404, 0);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(116, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(827, 77);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Phone number :";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(113, 32);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.Account_edt;
            this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem6.ImageOptions.Image")));
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 382);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(404, 0);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(116, 40);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(827, 105);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "Account:";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(113, 32);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.Bank_edt;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem5.ImageOptions.Image")));
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 152);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(404, 0);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(116, 40);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(827, 77);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "Bank:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(113, 32);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.Save_btn;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 487);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(413, 42);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Mail_edt;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem4.ImageOptions.Image")));
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 229);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(404, 0);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(116, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(827, 76);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Email:";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(113, 32);
            // 
            // Clear_btn
            // 
            this.Clear_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Clear_btn.ImageOptions.Image")));
            this.Clear_btn.Location = new System.Drawing.Point(425, 499);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(410, 38);
            this.Clear_btn.StyleController = this.layoutControl1;
            this.Clear_btn.TabIndex = 10;
            this.Clear_btn.Text = "Clear";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.Clear_btn;
            this.layoutControlItem8.Location = new System.Drawing.Point(413, 487);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(414, 42);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // New_Provider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 549);
            this.Controls.Add(this.layoutControl1);
            this.Name = "New_Provider";
            this.Text = "New_Provider";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Name_edt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_edt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone_edt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mail_edt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bank_edt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Account_edt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit Name_edt;
        private DevExpress.XtraEditors.TextEdit Add_edt;
        private DevExpress.XtraEditors.TextEdit Phone_edt;
        private DevExpress.XtraEditors.TextEdit Mail_edt;
        private DevExpress.XtraEditors.TextEdit Bank_edt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit Account_edt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton Save_btn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton Clear_btn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}