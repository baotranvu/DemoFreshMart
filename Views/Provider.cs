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
        }
    }
}