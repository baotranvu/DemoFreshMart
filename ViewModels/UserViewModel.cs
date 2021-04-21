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
using System.Linq;

namespace ViewModels
{
    public class UserViewModel : INotifyPropertyChanged, IUserViewModel
    {
        public BindingSource UserBindingSource { get; set; }
        public BindingSource RoleBindingSource { get; set; }
        private SuperMarketEntities db;
        public UserViewModel() => db = new SuperMarketEntities();
        public event PropertyChangedEventHandler PropertyChanged;

        public void Add()
        {
            Users user = new Users();
            UserBindingSource.Add(user);
            db.Users.Add(user);
        }

        public void Delete()
        {
            if (XtraMessageBox.Show("Delete?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.Users.Remove(UserBindingSource.Current as Users);
                UserBindingSource.RemoveCurrent();
            }
        }

        public void Dispose()
        {
            UserBindingSource.Dispose();
        }

        public void Load()
        {
            
            UserBindingSource.DataSource = db.Users.ToList();

        }

        public async void SaveAsync()
        {
            try
            {
                UserBindingSource.EndEdit();
                await db.SaveChangesAsync();
                XtraMessageBox.Show("Saved!");

            }
            catch(Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }
        }
    }
}
