using Interfaces;
using System.ComponentModel;
using System.Windows.Forms;
using Models;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace ViewModels
{
    public class EmployeeViewModel : INotifyPropertyChanged, IEmployeeViewModel
    {
        private SuperMarketEntities db;
        public EmployeeViewModel() => db = new SuperMarketEntities();
        public BindingSource EmployeeBindingSource { get; set; }

        public string Title
        {
            get
            {
                
            
                    if (EmployeeBindingSource.Current == null) return "Employees";
                    return $"Employee - {(EmployeeBindingSource?.Current as Employees)?.Name}";
                
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Delete()
        {
            EmployeeBindingSource.RemoveCurrent();
            db.SaveChanges();
            EmployeeBindingSource.EndEdit();
        }

        public void Dispose()
        {
            EmployeeBindingSource.Dispose();
        }

        public void Load()
        {
            db.Employees.Load();
            EmployeeBindingSource.DataSource = db.Employees.Local.ToBindingList();
        }
        public void Update()
        {
            EmployeeBindingSource.EndEdit();
            db.SaveChanges();
            XtraMessageBox.Show("Done!");
        }
    }
}
