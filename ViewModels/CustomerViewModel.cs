
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
            var token = new CancellationTokenSource();
           

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
                Load();
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

        public async void AddAsync(string name, string gender, System.DateTime birth, string address, string phone, string mail ,string temp )
        {

            try
            {
                db = new SuperMarketEntities();
                int x = db.Database.ExecuteSqlCommand("dbo.sp_AddCustomer {0},{1},{2},{3},{4},{5},{6}",name, gender, birth, address, phone, mail, temp);
                if (x != 0)
                {
                    XtraMessageBox.Show("Done!");
                }
                else
                {
                    XtraMessageBox.Show("False!");
                }
            }catch(Exception e)
            {
                XtraMessageBox.Show("Error!,try again."+""+e.Source);
            }
            }
           
              
                

           
        

        public void Clear(LayoutControlGroup layoutControl)
        {
            DevExpress.XtraLayout.Utils.LayoutGroupItemCollection items = layoutControl.Items;
            foreach (BaseLayoutItem item in items)
            {
                LayoutControlItem edt = item as LayoutControlItem;
                TextEdit textEdit = edt.Control as TextEdit;
                if( textEdit != null)
                {
                    textEdit.Text = string.Empty;
                }
                else
                {
                    continue;
                }
                
            }



        }
    }
}
