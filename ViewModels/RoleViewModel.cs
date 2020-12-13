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
    public class RoleViewModel : INotifyPropertyChanged, IRoleViewModel
    {
        private SuperMarketEntities db;
        public RoleViewModel() => db = new SuperMarketEntities();
        public BindingSource RoleBindingSource { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Add()
        {
            Roles role = new Roles();
            RoleBindingSource.Add(role);
            RoleBindingSource.MoveLast();
            db.Roles.Add(role);
        }

        public void Delete()
        {
            if (XtraMessageBox.Show("Delete?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.Roles.Remove(RoleBindingSource.Current as Roles);
                RoleBindingSource.RemoveCurrent();
            }
        }

        public void Dispose()
        {
            RoleBindingSource.Dispose();
        }

        public void Load()
        {
            db.Roles.Load();
            RoleBindingSource.DataSource = db.Roles.Local.ToBindingList();
        }

        public async void SaveAsync()
        {
            try
            {
                RoleBindingSource.EndEdit();
                await db.SaveChangesAsync();
                XtraMessageBox.Show("Saved!");

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}
