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

        public void Add(string name, string address, string phone, string mail, string bank, string account)
        {
            try
            {
                db = new SuperMarketEntities();
                int x = db.Database.ExecuteSqlCommand("dbo.sp_AddProvider {0},{1},{2},{3},{4},{5}",name,address,phone,mail,bank,account);
                if(x!=0)
                {
                    XtraMessageBox.Show("Done!");
                }
                else
                {
                    XtraMessageBox.Show("False!");
                }
            }
            catch(Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }
        }

        public void Delete()
        {
            if(XtraMessageBox.Show("Delete?","Warning!",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                db.Providers.Remove(ProviderBindingSource.Current as Providers);
                ProviderBindingSource.RemoveCurrent();           
            }
        }

        public void Dispose()
        {
            ProviderBindingSource.Dispose();
        }

        public void Load()
        {
            db.Providers.Load();
            ProviderBindingSource.DataSource = db.Providers.Local.ToBindingList();
            
        }

        public void Update()
        {
            ProviderBindingSource.EndEdit();
            db.SaveChangesAsync();
        }
    }
}
