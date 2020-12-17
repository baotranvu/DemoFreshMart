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
            this.signIn.Click += delegate { this.Hide(); new Main().ShowDialog(); this.Close(); };
        }

        
    }

       
    
}