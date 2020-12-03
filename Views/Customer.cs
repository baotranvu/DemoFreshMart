using System.ComponentModel;
using System.Windows.Forms;
using Interfaces;
using Unity;

namespace Views
{
    public partial class Customer : DevExpress.XtraEditors.XtraForm
    {
        private ICustomerViewModel _vm = Config.Container.Resolve<ICustomerViewModel>();
        public Customer()
        {
            InitializeComponent();
        }

        private void New_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}