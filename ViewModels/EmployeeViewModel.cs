using Interfaces;
using System.ComponentModel;
using System.Windows.Forms;
using Models;
using System;

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
                throw new NotImplementedException();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void Load()
        {
            throw new System.NotImplementedException();
        }
        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
