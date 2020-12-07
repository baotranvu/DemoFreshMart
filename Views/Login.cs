using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Views
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public static string name;
        public Login()
        {
            InitializeComponent();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();        
            name = user_edt.Text;
            connect.ConnectToServer(user_edt.Text, pass_edt.Text, this);

        }
    }

       
    
}