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
    public class OderViewModel : INotifyPropertyChanged, IOrderViewModel
    {
        private SuperMarketEntities db;
        public OderViewModel() => db = new SuperMarketEntities();
        public BindingSource OrderBindingSource { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public void Dispose()
        {
            OrderBindingSource.Dispose();
        }

        public void Load()
        {
            db.Orders.Load();
            OrderBindingSource.DataSource = db.Orders.Local.ToBindingList();
        }

        public void ShowDetail(IOrderDetail detail)
        {
            detail.BindingSource.DataSource = OrderBindingSource.Current;
            detail.BindingSource.DataMember = "Order_Detail";
            detail.ShowModal();
        }
    }
}
