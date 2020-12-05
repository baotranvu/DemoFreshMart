using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Windows.Forms;
using Interfaces;
using Models;





namespace ViewModels
{
    public class CustomerViewModel : INotifyPropertyChanged, ICustomerViewModel
    {
        private SuperMarketEntities db;
        public CustomerViewModel() => db = new SuperMarketEntities();
        public BindingSource CustomerBindingSource { get; set; }
        

        public string Title
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Delete()
        {
            CustomerBindingSource.RemoveCurrent();
        }

        

        private void Notify(string v)
        {
            throw new NotImplementedException();
        }

        public void Load()
        {
            db.Customers.Load();
            CustomerBindingSource.DataSource = db.Customers.Local.ToBindingList();
            
        }

        public void New()
        {
            CustomerBindingSource.AddNew();
        }

        public void Save()
        {
            CustomerBindingSource.EndEdit();
            db.SaveChanges();
            
        }

        public void Dispose()
        {
            CustomerBindingSource.Dispose();
        }
    }
}
