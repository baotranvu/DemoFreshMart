using System.ComponentModel;
using System.Data.Entity;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Interfaces;
using Models;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using System.Threading;
using System;


namespace ViewModels
{
    public class InvoiceViewModel : INotifyPropertyChanged, IInvoiceViewModel
    {
        
        private SuperMarketEntities db;
        public InvoiceViewModel() => db = new SuperMarketEntities();
        public BindingSource InvoiceBindingSource { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        
      
        public void Dispose()
        {
            InvoiceBindingSource.Dispose();
        }

        public void Load()
        {
            db.Invoices.Load();
            InvoiceBindingSource.DataSource = db.Invoices.Local.ToBindingList();
        }

        public void ShowDetail(IInvoiceDetail detail)
        {
            detail.BindingSource.DataSource = InvoiceBindingSource.Current;
            detail.BindingSource.DataMember = "Invoice_detail";
            detail.ShowModal();
        }
    }
}
