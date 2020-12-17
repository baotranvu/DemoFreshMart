using System;
using ViewModels;
using DevExpress.XtraEditors;
using Interfaces;
using Unity;

namespace Views
{
    public partial class Invoice : DevExpress.XtraEditors.XtraForm
    {
        
        private InvoiceViewModel vm;
        public Invoice()
        {
            vm = new InvoiceViewModel();
            InitializeComponent();
            vm.InvoiceBindingSource = invoicesBindingSource;
            this.Load += delegate { vm.Load(); };
            this.FormClosing += delegate { vm.Dispose(); };
            Inv.MouseDoubleClick += delegate { vm.ShowDetail(Config.Container.Resolve<IDetailView>()); };
            
        }
        

        

        
    }
}