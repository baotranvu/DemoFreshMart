namespace Views
{
    partial class Role
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Role));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Delete_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Save_btn = new DevExpress.XtraEditors.SimpleButton();
            this.GridRole = new DevExpress.XtraGrid.GridControl();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridRoleView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRoleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Add_btn = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRoleView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.Delete_btn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Save_btn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.GridRole, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Add_btn, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Delete_btn.ImageOptions.Image")));
            this.Delete_btn.Location = new System.Drawing.Point(560, 414);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(120, 36);
            this.Delete_btn.TabIndex = 3;
            this.Delete_btn.Text = "Delete";
            
            // 
            // Save_btn
            // 
            this.Save_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Save_btn.ImageOptions.Image")));
            this.Save_btn.Location = new System.Drawing.Point(680, 414);
            this.Save_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(120, 36);
            this.Save_btn.TabIndex = 2;
            this.Save_btn.Text = "Save";
            
            // 
            // GridRole
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.GridRole, 4);
            this.GridRole.DataSource = this.rolesBindingSource;
            this.GridRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridRole.Location = new System.Drawing.Point(0, 0);
            this.GridRole.MainView = this.GridRoleView;
            this.GridRole.Margin = new System.Windows.Forms.Padding(0);
            this.GridRole.Name = "GridRole";
            this.GridRole.Size = new System.Drawing.Size(800, 414);
            this.GridRole.TabIndex = 0;
            this.GridRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridRoleView});
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataSource = typeof(Models.Roles);
            // 
            // GridRoleView
            // 
            this.GridRoleView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoleId,
            this.colRoleName});
            this.GridRoleView.GridControl = this.GridRole;
            this.GridRoleView.Name = "GridRoleView";
            // 
            // colRoleId
            // 
            this.colRoleId.FieldName = "RoleId";
            this.colRoleId.Name = "colRoleId";
            this.colRoleId.Visible = true;
            this.colRoleId.VisibleIndex = 0;
            // 
            // colRoleName
            // 
            this.colRoleName.FieldName = "RoleName";
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.Visible = true;
            this.colRoleName.VisibleIndex = 1;
            // 
            // Add_btn
            // 
            this.Add_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Add_btn.ImageOptions.Image")));
            this.Add_btn.Location = new System.Drawing.Point(440, 414);
            this.Add_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(120, 36);
            this.Add_btn.TabIndex = 1;
            this.Add_btn.Text = "Add";
           
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Role";
            this.Text = "Role";
            this.Load += new System.EventHandler(this.Role_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRoleView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl GridRole;
        private DevExpress.XtraGrid.Views.Grid.GridView GridRoleView;
        private DevExpress.XtraEditors.SimpleButton Add_btn;
        private DevExpress.XtraEditors.SimpleButton Delete_btn;
        private DevExpress.XtraEditors.SimpleButton Save_btn;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleId;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
    }
}