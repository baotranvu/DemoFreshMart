using System;
using DevExpress.XtraEditors;
using Models;
using System.Windows.Forms;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using ViewModels;

namespace Views
{
    public partial class Function : XtraForm
    {
        public Function()
        {
            InitializeComponent();
        }
        SuperMarketEntities db;

        private void btn_Add_Click(object sender, EventArgs e)
        {
            db = new SuperMarketEntities();
            functionsBindingSource.DataSource = db.Functions.ToList();
            List<AppForm> list = new List<AppForm>();
            list.Add(new AppForm() { ID = "Views.Role", FormName = "Role" });
            list.Add(new AppForm() { ID = "Views.User", FormName = "User" });
            list.Add(new AppForm() { ID = "Views.Function", FormName = "Function" });
            list.Add(new AppForm() { ID = "Views.Authentication", FormName = "Authentication" });
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void Function_Load(object sender, EventArgs e)
        {
                
        }
    }
}
