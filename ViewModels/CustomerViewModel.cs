using System;
using System.ComponentModel;
using System.Windows.Forms;
using Interfaces;

namespace ViewModels
{
    public class CustomerViewModel : INotifyPropertyChanged, ICustomerViewModel
    {
        public BindingSource CustomerBindingSource
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

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
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            
                CustomerBindingSource.CurrentChanged += delegate { Notify("Title"); };
             

                
            
        }

        private void Notify(string v)
        {
            throw new NotImplementedException();
        }

        public void Load()
        {
            throw new NotImplementedException();
        }

        public void New()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
        public void ShowDetail(IDetailView detail)
        {
            detail.BindingSource.DataSource = CustomerBindingSource.Current;
            detail.ShowModal();
        }
    }
}
