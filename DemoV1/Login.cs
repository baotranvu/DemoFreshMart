using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;


namespace App
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
            this.Hide();
            Main main_form = new Main();
            main_form.ShowDialog();
            this.Close();
          
        }
    }

       
    
}