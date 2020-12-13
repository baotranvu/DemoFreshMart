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
    public class ProviderViewModel : INotifyPropertyChanged, IProviderViewModel
    {
        private SuperMarketEntities db;
        public ProviderViewModel() => db = new SuperMarketEntities();
        public BindingSource ProviderBindingSource { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void AddAsync(string name, string address, string phone, string mail, string bank, string account)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Load()
        {
            db.Providers.Load();
            ProviderBindingSource.DataSource = db.Providers.Local.ToBindingList();
            
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
