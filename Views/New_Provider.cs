using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ViewModels;
namespace Views
{
    public partial class New_Provider : DevExpress.XtraEditors.XtraForm
    {
        private ProviderViewModel vm;
        private Functions func;
        public New_Provider()
        {
            InitializeComponent();
            vm = new ProviderViewModel();
            func = new Functions();
            this.Save_btn.Click += delegate { vm.Add(Name_edt.Text,Add_edt.Text,Phone_edt.Text,Mail_edt.Text,Bank_edt.Text,Account_edt.Text); };
            this.Clear_btn.Click += delegate { func.Clear(Root); };
        }

        
    }
}