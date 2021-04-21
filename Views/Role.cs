
using ViewModels;


namespace Views
{
    public partial class Role : DevExpress.XtraEditors.XtraForm
    {
        
        private RoleViewModel vm;
        public Role()
        {
            InitializeComponent();
            vm = new RoleViewModel();
            vm.RoleBindingSource = rolesBindingSource;
            this.Load += delegate { vm.Load(); };
            this.Add_btn.Click += delegate { vm.Add(); };
            this.Save_btn.Click += delegate { vm.SaveAsync(); };
            this.Delete_btn.Click += delegate { vm.Delete(); };
            this.FormClosing += delegate { vm.Dispose(); };
        }

        
    }
}
