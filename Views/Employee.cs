using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Interfaces;
using Unity;
using ViewModels;


namespace Views
{

    public partial class Employees : DevExpress.XtraEditors.XtraForm
    {
        private IEmployeeViewModel _vm = Config.Container.Resolve<IEmployeeViewModel>();
        private EmployeeViewModel vm;
        public Employees()
        {
            InitializeComponent();
            vm = new EmployeeViewModel();
            vm.EmployeeBindingSource = employeesBindingSource;
            this.Load += delegate { vm.Load(); };
            this.Update.Click += delegate { vm.Update(); };
            this.Delete.Click += delegate { vm.Delete(); };
            DataBindings.Add("Text", vm, "Title");


        }

        private void New_Click(object sender, EventArgs e)
        {
            
        }
    }
}