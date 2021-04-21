using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using ViewModels;
using Interfaces;
using Unity;

namespace Views
{
    public partial class Oder : DevExpress.XtraEditors.XtraForm
    {
        private OderViewModel vm;
        public Oder()
        {
            vm = new OderViewModel();
            InitializeComponent();
            vm.OrderBindingSource = ordersBindingSource;
            this.Load += delegate { vm.Load(); };
            this.FormClosing += delegate { vm.Dispose(); };
            ord_grid.MouseDoubleClick += delegate { vm.ShowDetail(Config.Container.Resolve<IOrderDetail>()); };
        }

        
    }
}