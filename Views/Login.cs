using DevExpress.XtraEditors;
using System;
using ViewModels;

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
            Main main = new Main();
            main.ShowDialog();
            this.Hide();
            this.Close();
        }
    }

       
    
}