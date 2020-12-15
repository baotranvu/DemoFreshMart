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
    public class ProductViewModel : INotifyPropertyChanged, IProductViewModel
    {
        public BindingSource ProductBindingSource { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(string name, string type, string unit, decimal unitprice, DateTime mfg, DateTime exp)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Load()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
