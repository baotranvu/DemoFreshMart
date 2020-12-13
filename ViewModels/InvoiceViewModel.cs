﻿using System.ComponentModel;
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
    public class InvoiceViewModel : INotifyPropertyChanged, IInvoiceViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
