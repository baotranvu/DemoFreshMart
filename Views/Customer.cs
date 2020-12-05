using System.ComponentModel;
using System.Windows.Forms;
using Interfaces;
using Unity;
using ViewModels;

namespace Views
{
    public partial class Customer : DevExpress.XtraEditors.XtraForm
    {
        
        private ICustomerViewModel _vm = Config.Container.Resolve<ICustomerViewModel>();
        private CustomerViewModel vm;
        public Customer()
        {
            InitializeComponent();
            vm = new CustomerViewModel();
            vm.CustomerBindingSource = customersBindingSource;
            this.Load += delegate { vm.Load(); };
            this.New.Click += delegate { vm.New(); };
            this.Delete.Click += delegate { vm.Delete(); };
            this.Update.Click += delegate { vm.Save(); };
            this.FormClosing += delegate { vm.Dispose(); };
            
        }

       

        
    }
}