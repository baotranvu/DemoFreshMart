using System;
using ViewModels;

namespace Views
{
    public partial class User : DevExpress.XtraEditors.XtraForm
    {
        private UserViewModel vm;
        public User()
        {
            InitializeComponent();
            vm = new UserViewModel();
            vm.UserBindingSource = usersBindingSource;
            this.Load += delegate { vm.Load(); };
            this.Save_btn.Click += delegate { vm.SaveAsync(); };
            this.Update_btn.Click += delegate { vm.Delete(); };
            this.FormClosing += delegate { vm.Dispose(); };
        }
    }
}
