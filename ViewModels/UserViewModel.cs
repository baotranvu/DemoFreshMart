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
    public class UserViewModel : INotifyPropertyChanged, IUserViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}