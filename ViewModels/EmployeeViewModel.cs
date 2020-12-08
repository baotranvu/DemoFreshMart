using Interfaces;
using System.ComponentModel;
using System.Windows.Forms;
using Models;
using DevExpress.XtraEditors;
using System.Data.Entity;
using DevExpress.XtraLayout;
using System;

namespace ViewModels
{
    public class EmployeeViewModel : INotifyPropertyChanged, IEmployeeViewModel
    {
        private SuperMarketEntities db;
        public EmployeeViewModel() => db = new SuperMarketEntities();
        public BindingSource EmployeeBindingSource { get; set; }

        

        public event PropertyChangedEventHandler PropertyChanged;

        public void AddAsync(string name, string gender, DateTime birth, string address, string phone, string pass)
        {
            try
            {
                db = new SuperMarketEntities();
                int x = db.Database.ExecuteSqlCommand("dbo.sp_AddEmployee {0},{1},{2},{3},{4},{5}", name, gender, birth, address, phone, pass);
                if (x != 0)
                {
                    XtraMessageBox.Show("Done!");
                }
                else
                {
                    XtraMessageBox.Show("False!");
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Error!,try again." + "" + e.Source);
            }
        }

        public void Clear(LayoutControlGroup layoutControl)
        {
            throw new NotImplementedException();
        }

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
            Load();
            XtraMessageBox.Show("Done!");
        }
    }
}
