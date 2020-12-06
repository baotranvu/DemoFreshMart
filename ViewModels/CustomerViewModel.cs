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
                if (CustomerBindingSource.Current == null) return "Customers";
                return $"Customer - {(CustomerBindingSource?.Current as Customers)?.Name}";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Delete()
        {
            CustomerBindingSource.RemoveCurrent();
            db.SaveChanges();
            CustomerBindingSource.EndEdit();
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

        

        public void Update()
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
