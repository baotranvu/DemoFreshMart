using System;
using System.Collections.Generic;
using System.ComponentModel;
using ViewModels;

namespace Views
{
    public partial class New_Product : DevExpress.XtraEditors.XtraForm
    {
        private ProductViewModel vm;
        private Functions func;
        public New_Product()
        {
            vm = new ProductViewModel();
            InitializeComponent();
            this.Save_btn.Click += delegate { };
        }

        
    }
}