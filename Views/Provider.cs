using System;
using Interfaces;
using Unity;
using ViewModels;

namespace Views
{
    public partial class Provider : DevExpress.XtraEditors.XtraForm
    {
        private ProviderViewModel vm;
        public Provider()
        {
            InitializeComponent();
            vm = new ProviderViewModel();
            vm.ProviderBindingSource = providersBindingSource;
            this.Load += delegate { vm.Load(); };
            this.Update_btn.Click += delegate { vm.Update(); };
            this.Delete_btn.Click += delegate { vm.Delete(); };
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            New_Provider new_Provider = new New_Provider();
            new_Provider.ShowDialog();

        }

       
    }
}