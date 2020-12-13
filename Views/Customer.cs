using System;
using Interfaces;
using Unity;
using ViewModels;

namespace Views
{
    public partial class Customers : DevExpress.XtraEditors.XtraForm
    {
        
        
        private CustomerViewModel vm;
        public Customers()
        {
            InitializeComponent();
            vm = new CustomerViewModel();
            vm.CustomerBindingSource = customersBindingSource;
            
            this.Load += delegate { vm.Load(); };
            this.Delete.Click += delegate { vm.Delete(); };
            this.Update.Click += delegate { vm.Update(); };
            this.FormClosing += delegate { vm.Dispose(); };
           

        }

        private void New_Click(object sender, System.EventArgs e)
        {
            New_Customer new_Customer = new New_Customer();
            new_Customer.ShowDialog();

        }

        private void gridCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}