
using System.ComponentModel;
using System.Data.Entity;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Interfaces;
using Models;
using DevExpress.XtraEditors;


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



        private void Notify([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
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
            XtraMessageBox.Show("Done!");

        }

        public void Dispose()
        {
            CustomerBindingSource.Dispose();
        }

        public void Initializze()
        {
            CustomerBindingSource.CurrentChanged += delegate { Notify("Title"); };
        }
    }
}
